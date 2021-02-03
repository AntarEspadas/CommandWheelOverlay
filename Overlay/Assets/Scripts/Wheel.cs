using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//[ExecuteInEditMode()]
public class Wheel : MonoBehaviour
{
    public int buttons;
    public float radious;
    public float innerRadious;
    public RectTransform separator;
    public WheelSegment segment;
    private WheelSegment[] childSegments;

    public int Highlighted { get => highlighted; set => SetHighlighted(value); }
    public Vector2 StartVector { get; private set; }
    public float InnerRadiousDelta { get; private set; }
    public float ActualRadious { get; private set; }
    private int highlighted = -1;

    // Start is called before the first frame update
    void Start()
    {
        var mask = transform.Find("Mask");
        transform.localScale = new Vector2(innerRadious * 2, innerRadious * 2);
        float angleDiff = 360f / buttons;
        float offset = angleDiff / 2;
        childSegments = new WheelSegment[buttons];
        for (int i = 0; i < buttons; i++)
        {
            float angle = angleDiff * i + offset;
            var seg = Instantiate(segment, transform.position, Quaternion.Euler(0, 0, angle), mask);
            childSegments[i] = seg;
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
        StartVector = childSegments[buttons - 1].transform.up;
        InnerRadiousDelta = ((RectTransform)mask).sizeDelta.x;
        ActualRadious =  ((RectTransform)transform).sizeDelta.y * radious;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SetHighlighted(int value)
    {
        if (value == highlighted) return;
        Transform highlight;
        if (highlighted >= 0)
        {
            highlight = childSegments[highlighted].transform.Find("Highlight");
            highlight.GetComponent<Image>().enabled = false;
        }
        if (value >= 0)
        {
            highlight = childSegments[value].transform.Find("Highlight");
            highlight.GetComponent<Image>().enabled = true;
        }
        highlighted = value;
    }
}
