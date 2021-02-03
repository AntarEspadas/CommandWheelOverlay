using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[ExecuteInEditMode()]
public class Wheel : MonoBehaviour
{
    public int buttons;
    public RectTransform obj;
    // Start is called before the first frame update
    void Start()
    {
        float angleDiff = 360f / buttons;
        float offset = angleDiff / 2;
        for (int i = 0; i < buttons; i++)
        {
            float angle = angleDiff * i + offset;
            var t = Instantiate(obj, transform, true);
            t.position = transform.position + (Vector3)VectorFromPolar(angle + 90, 50);
            t.rotation = Quaternion.Euler(0, 0, angle);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private Vector2 VectorFromPolar(float theta, float r)
    {
        float radians = 2 * Mathf.PI * theta;
        radians /= 360;
        float x = Mathf.Cos(radians) * r;
        float y = Mathf.Sin(radians) * r;
        return new Vector2(x, y);
    }
}
