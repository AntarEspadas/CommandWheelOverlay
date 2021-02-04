using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using Linearstar.Windows.RawInput;
using UnityEngine;

public class CursorMovement : MonoBehaviour
{
    public RectTransform constraint;
    public float sensitivity;
    private Vector2 movement = new Vector2(0, 0);
    // Start is called before the first frame update

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        var rect = constraint.rect;

        Vector3 pos = transform.localPosition;

#if UNITY_EDITOR
        movement.x += Input.GetAxis("Mouse X") * sensitivity * 10;
        movement.y += Input.GetAxis("Mouse Y") * sensitivity * 10;
#endif

        float x = pos.x + movement.x;
        float y = pos.y + movement.y;
        pos.x = Mathf.Clamp(x, rect.width / -2, rect.width / 2);
        pos.y = Mathf.Clamp(y, rect.height / -2, rect.height / 2);

        transform.localPosition = pos;
        movement.x = 0;
        movement.y = 0;

    }

    public void AddMovement(Vector2 movement)
    {
        this.movement += movement * sensitivity * 0.75f;
    }
}
