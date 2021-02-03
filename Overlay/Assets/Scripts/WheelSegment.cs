using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WheelSegment : MonoBehaviour
{
    public float radious;
    public float degrees;
    public int index;
    // Start is called before the first frame update
    void Start()
    {
        transform.localScale *= (radious * 2);
        var highlight = transform.Find("Highlight");
        var highlightImage = highlight.GetComponent<Image>();
        highlightImage.fillAmount = degrees / 360;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
