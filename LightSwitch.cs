using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{
    private Light lamp;

    public Transform obj_1;
    public Transform obj_2;
    public float distantion;

    // Start is called before the first frame update
    void Start()
    {
        lamp = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        distantion = Vector3.Distance(obj_1.position, obj_2.position);

        if (distantion <= 3)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                lamp.enabled = !lamp.enabled;
            }
        }
    }
}
