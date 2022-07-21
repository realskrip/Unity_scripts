using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dampingGlassesFilter : MonoBehaviour
{
    private bool snap_event = false;
    private float step = 20f;
    private Color default_color;
    private Color _color;

    
    public void start_snap_event()
    {
        snap_event = true;
    }

    public void stop_snap_event()
    {
        snap_event = false;
    }

    public void damping()
    {
        _color = GetComponent<Renderer>().material.color;

        if (_color.a > 0)
        {
            _color.a -= step / 100000;
            GetComponent<Renderer>().material.color = _color;
        }
    }

    public void undamping()
    {
        _color = default_color;
        GetComponent<Renderer>().material.color = _color;

    }

    public void Default_color()
    {
        default_color = GetComponent<Renderer>().material.color;
    }

    void Start()
    {
        Default_color();
    }

    void Update()
    {
        if (snap_event == true)
        {
            damping();
        }
        else
        {
            undamping();
        }
    }
}
