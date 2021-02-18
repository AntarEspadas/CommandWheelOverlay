using CommandWheelOverlay.View;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WheelSegment : MonoBehaviour
{
    public Color bgColor = new Color(25, 140, 210, 128);
    public Color accentColor = Color.white;

    public float radious;
    public float innerRadious;
    public float degrees;
    public int index;

    public SimplifiedWheelButton ButtonTemplate { get; set; }
    public int ButtonIndex { get; set; }

    public bool Highlighted { get => _highlighted; set => SetHighlighted(value); }
    private bool _highlighted = false;

    private int _tweenId;

    private Transform highlight;

    // Start is called before the first frame update
    void Start()
    {
        var size = new Vector2(radious * 2, radious * 2);
        ((RectTransform)transform).sizeDelta = size;
        highlight = transform.Find("Highlight");
        var highlightImage = highlight.GetComponent<Image>();
        highlightImage.fillAmount = degrees / 360;
        highlightImage.color = bgColor;
        float r = Mathf.Sqrt(800 * 800 + 450 * 450);
        ((RectTransform)highlight.transform).sizeDelta = new Vector2(r, r);

        var info = transform.Find("Info");
        info.GetComponent<ButtonInfo>().SetInfo(ButtonTemplate.Label, ButtonTemplate.ImgPath);
        info.localPosition += Quaternion.Euler(0,0,degrees / -2) * new Vector3(0, (radious + innerRadious) / 2);
        info.rotation = Quaternion.Euler(0,0,0);
        info.SetAsLastSibling();
        info.GetComponent<ButtonInfo>().Color = accentColor;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetHighlighted(bool highlighted)
    {
        if (highlighted == _highlighted) return;
        _highlighted = highlighted;
        var group = highlight.GetComponent<CanvasGroup>();
        LeanTween.cancel(_tweenId);
        if (_highlighted)
        {
            highlight.gameObject.SetActive(true);
            _tweenId = group.LeanAlpha(1, 0.2f).id;
            return;
        }
        _tweenId = group.LeanAlpha(0, 0.5f).setOnComplete(() => highlight.gameObject.SetActive(false)).id;
    }

    public void ForceUnhighlight()
    {
        var group = highlight.GetComponent<CanvasGroup>();

        LeanTween.cancel(_tweenId);
        group.alpha = 0;
        highlight.gameObject.SetActive(false);
        _highlighted = false;
    }
}
