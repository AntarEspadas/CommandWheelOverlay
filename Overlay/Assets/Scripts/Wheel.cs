using CommandWheelOverlay.View;
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

    public SimplifiedWheel? Template { get; set; } = null;
    public SimplifiedWheelButton[] ButtonTemplates { get; set; } = null;

    public int Highlighted { get => highlighted; set => SetHighlighted(value); }
    public Vector2 StartVector { get; private set; }
    public float ActualInnerRadious { get; private set; }
    public float ActualRadious { get; private set; }
    private int highlighted = -1;

    // Start is called before the first frame update
    void Start()
    {
        bool fromTemplate = false;
        if (Template.HasValue && ButtonTemplates != null)
        {
            fromTemplate = true;
            buttons = Template.Value.ButtonIndices.Length;
        }

        var mask = (RectTransform)transform.Find("Mask");
        var innerSize = new Vector2(innerRadious * 2, innerRadious * 2);
        ((RectTransform)transform).sizeDelta = innerSize;
        mask.sizeDelta = innerSize;
        //transform.localScale = new Vector2(innerRadious * 2, innerRadious * 2);
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
            seg.innerRadious = innerRadious;
            if (fromTemplate)
            {
                int buttonIndex = Template.Value.ButtonIndices[i];
                seg.ButtonTemplate = ButtonTemplates[buttonIndex];
                seg.ButtonIndex = buttonIndex;
                gameObject.SetActive(false);
            }
        }
        for (int i = 0; i < buttons; i++)
        {
            float angle = angleDiff * i - offset;
            var sep = Instantiate(separator, transform.position, Quaternion.Euler(0, 0, angle), mask);
            var sepTransform = ((RectTransform)sep.transform);
            var sepSize = sepTransform.sizeDelta;
            sepSize.y = radious;
            sepTransform.sizeDelta = sepSize;
            sep.transform.localPosition += sep.up * (sep.rect.height / 2);
        }
        StartVector = childSegments[buttons - 1].transform.up;
        ActualInnerRadious = ((RectTransform)transform).sizeDelta.y * innerRadious;
        ActualRadious =  ((RectTransform)transform).sizeDelta.y * radious;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SetHighlighted(int value)
    {
        if (value == highlighted) return;
        if (highlighted >= 0)
        {
            childSegments[highlighted].Highlighted = false;
        }
        if (value >= 0)
        {
            childSegments[value].Highlighted = true; ;
        }
        highlighted = value;
    }

    public int GetHighlightedButton()
    {
        return childSegments[highlighted].ButtonIndex;
    }

    public void ForceUnhighlightAll()
    {
        highlighted = -1;
        foreach (WheelSegment segment in childSegments)
        {
            segment.ForceUnhighlight();
        }
    }
}
