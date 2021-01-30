using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using Linearstar.Windows.RawInput;
using UnityEngine;

public class CursorMovement : MonoBehaviour
{
    public RectTransform constraint;
    public int sensitivity;
    private Vector2 movement = new Vector2(0, 0);
    private TcpListener listener = new TcpListener(IPAddress.Any, 25565);
    private Socket client = null;
    private NetworkStream stream;
    private BinaryFormatter formatter;
    // Start is called before the first frame update

    void Start()
    {
        Cursor.visible = false;
        listener.Start();
    }
    
    // Update is called once per frame
    void Update()
    {
        if (client is null && listener.Pending())
        {
            client = listener.AcceptSocket();
            stream = new NetworkStream(client);
            formatter = new BinaryFormatter();
        }
        if (client != null)
        {
            while (stream.DataAvailable)
            {
                object line = formatter.Deserialize(stream);
                if (line is long[] data)
                {
                    movement.x = data[0] * sensitivity;
                    movement.y = data[1] * -sensitivity;
                    //movement = new Vector2(data[0], data[1] * -1) * (speed / 10);
                    Debug.Log($"{data[0]}, {data[1]}");
                }
            }
        }
        else
        {
            movement.x += Input.GetAxis("Mouse X") * sensitivity * 5;
            movement.y += Input.GetAxis("Mouse Y") * sensitivity * 5;
        }

        var rect = constraint.rect;

        Vector3 pos = transform.position;

        float xMin = rect.x + rect.width / 2;
        float xMax = rect.x - rect.width / 2;
        xMax *= -1;
        float yMin = rect.y + rect.height / 2;
        float yMax = rect.y - rect.height / 2;
        yMax *= -1;
        float x = pos.x + movement.x;
        float y = pos.y + movement.y;
        pos.x = Mathf.Clamp(x, xMin, xMax);
        pos.y = Mathf.Clamp(y, yMin, yMax);

        transform.position = pos;
        movement.x = 0;
        movement.y = 0;

    }
}
