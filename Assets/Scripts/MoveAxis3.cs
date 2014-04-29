using UnityEngine;
using System.Collections;

public class MoveAxis3 : MonoBehaviour
{

    public float curso = 260.0f;
    public float velocity = 10.0f;

    private float top = 24.5f;
    private float low = -2.7f;

    //private MessageManager manager;

    void Start()
    {
       // manager = GameObject.FindGameObjectWithTag("Connection").GetComponent<MessageManager>();
    }

    void Update()
    {
        /*if (manager && manager.Server.IsConnected)
        {
            transform.localPosition = new Vector3(transform.localPosition.x, Move((float)manager.scaraRealTo3d.Joints[2].Position), transform.localPosition.z);
        }
        */
    }

    float Move(float position)
    {
        float result = top + ((top - low) * (-position) / curso);
        return Mathf.Clamp(result, low, top);
    }
}



