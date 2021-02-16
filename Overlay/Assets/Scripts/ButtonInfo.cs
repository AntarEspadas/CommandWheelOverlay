using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class ButtonInfo : MonoBehaviour
{
    public Color Color
    {
        get => _color;
        set
        {
            _color = value;
            Text text = transform.Find("Text").GetComponent<Text>();
            text.color = _color;
        }
    }
    private Color _color;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetInfo(string buttonLabel, string imgPath)
    {
        Text text = transform.Find("Text").GetComponent<Text>();
        RawImage image = transform.Find("Image").GetComponent<RawImage>();

        bool showLabel = !string.IsNullOrWhiteSpace(buttonLabel);
        bool imageLoaded = false;
        Texture2D texture = new Texture2D(1, 1);
        try
        {
            byte[] img = File.ReadAllBytes(imgPath);
            imageLoaded = texture.LoadImage(img);
        }
        catch (System.Exception) { }
        if (imageLoaded)
        {
            var imgTransform = (RectTransform)image.transform;
            var imgSize = imgTransform.sizeDelta;
            if (texture.width < texture.height)
            {
                imgSize.x = imgSize.y * texture.width / texture.height;
            }
            else if (texture.width > texture.height)
            {
                imgSize.y = imgSize.x * texture.height / texture.width;
            }
            imgTransform.sizeDelta = imgSize;
            image.texture = texture;
        }
        text.text = buttonLabel;
        text.color = Color;

        if (!showLabel || !imageLoaded)
        {
            text.transform.localPosition = new Vector3();
            image.transform.localPosition = new Vector3();
        }

        image.gameObject.SetActive(imageLoaded);
        text.gameObject.SetActive(showLabel);
    }
}
