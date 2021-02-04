﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CursorHighlight : MonoBehaviour
{
    public Wheel wheel;
    public RectTransform test;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var cursorPosition = transform.localPosition - wheel.transform.localPosition;
        float cursorDistance = cursorPosition.magnitude;
        if (wheel.radious >= cursorDistance &&cursorDistance >= wheel.innerRadious)
        {
            float buttonAngle = 360f / wheel.buttons;
            float cursorAngle = Angle360(wheel.StartVector, cursorPosition);
            int index = (int)(cursorAngle / buttonAngle);
            wheel.Highlighted = index;
        }
        else
        {
            wheel.Highlighted = -1;
        }
    }
    private static float Angle360(Vector2 start, Vector2 point)
    {
        float angle = Vector2.SignedAngle(start, point);
        return angle + (angle < 0 ? 360 : 0);
    }
}