using CommandWheelOverlay.View;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WheelSegment : MonoBehaviour
{
    public float radious;
    public float degrees;
    public int index;

    public SimplifiedWheelButton ButtonTemplate { get; set; }
    public int ButtonIndex { get; set; }

    // Start is called before the first frame update
    void Start()
    {
        var size = new Vector2(radious * 2, radious * 2);
        ((RectTransform)transform).sizeDelta = size;
        var highlight = transform.Find("Highlight");
        var highlightImage = highlight.GetComponent<Image>();
        highlightImage.fillAmount = degrees / 360;
        ((RectTransform)highlight.transform).sizeDelta = size;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
