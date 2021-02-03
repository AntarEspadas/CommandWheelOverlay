using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[ExecuteInEditMode()]
public class Wheel : MonoBehaviour
{
    public int buttons;
    public float radious;
    public float innerRadious;
    public RectTransform obj;
    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = new Vector2(innerRadious * 2, innerRadious * 2);
        float angleDiff = 360f / buttons;
        float offset = angleDiff / 2;
        for (int i = 0; i < buttons; i++)
        {
            float angle = angleDiff * i + offset;
            var t = Instantiate(obj, transform.position, Quaternion.Euler(0, 0, angle), transform);
            var separatorSize = t.sizeDelta;
            separatorSize.x /= transform.localScale.x;
            separatorSize.y /= transform.localScale.y * radious;
            t.sizeDelta = separatorSize;
            t.transform.localPosition += t.up * (t.rect.height / 2);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
