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

        var info = transform.Find("Info");
        info.rotation = Quaternion.Euler(0, 0, (degrees * index));
        info.position += info.up * radious / 2;
        info.rotation = Quaternion.Euler(0,0,0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
