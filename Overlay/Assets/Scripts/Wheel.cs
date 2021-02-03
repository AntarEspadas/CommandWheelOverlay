using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[ExecuteInEditMode()]
public class Wheel : MonoBehaviour
{
    public int buttons;
    public float radious;
    public float innerRadious;
    public RectTransform separator;
    public WheelSegment segment;
    // Start is called before the first frame update
    void Start()
    {
        var mask = transform.Find("Mask");
        transform.localScale = new Vector2(innerRadious * 2, innerRadious * 2);
        float angleDiff = 360f / buttons;
        float offset = angleDiff / 2;
        for (int i = 0; i < buttons; i++)
        {
            float angle = angleDiff * i - offset;
            var seg = Instantiate(segment, transform.position, Quaternion.Euler(0, 0, angle), mask);
            seg.degrees = angleDiff;
            seg.index = i;
            seg.radious = radious;
        }
        for (int i = 0; i < buttons; i++)
        {
            float angle = angleDiff * i - offset;
            var sep = Instantiate(separator, transform.position, Quaternion.Euler(0, 0, angle), mask);
            var separatorSize = sep.sizeDelta;
            separatorSize.x /= transform.localScale.x;
            separatorSize.y /= transform.localScale.y;
            separatorSize.y *= radious;
            sep.sizeDelta = separatorSize;
            sep.transform.localPosition += sep.up * (sep.rect.height / 2);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
