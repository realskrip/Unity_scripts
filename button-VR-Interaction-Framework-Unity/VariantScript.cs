//Взаимодействие с кнопкой для https://assetstore.unity.com/packages/templates/systems/vr-interaction-framework-161066#description
//https://wiki.beardedninjagames.com/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariantScript : MonoBehaviour //наследование от класса MonoBehaviour
{
    public bool isClicked { get; set; } = false; // с помощью { get; set; } для переменной указывается значение по умолчанию false

    public GameObject GOBJ; // Доступ к компонентам других объектов GameObjects (https://docs.unity3d.com/Manual/class-GameObject.html) Позволяет выбрать объект в скрипте

    public void SetFalse() // Метод SetFalse
    {
        GOBJ.SetActive(false); // https://docs.unity3d.com/ScriptReference/GameObject.SetActive.html
    }

    public void SetTrue() // Метод SetTrue
    {
        GOBJ.SetActive(true); // https://docs.unity3d.com/ScriptReference/GameObject.SetActive.html
    }

    void Start() //Метод. вызывается перед прорисовкой первого фрейма, только если сценарий определён
    {

    }

    void Update() //Метод. вызывается один раз за кадр. Это основное событие для прорисовки кадра
    {
        if (isClicked == true)
        {
            SetFalse(); // Вызов метода SetFalse
        }
    }
}
