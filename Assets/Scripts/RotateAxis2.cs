using UnityEngine;
using System.Collections;

public class RotateAxis2 : MonoBehaviour {

    public float curso = 135.0f;    // degree
    public float velocity = 10.0f;
    private float left = 55.41f;
    //private float right = 280.41f;  // -79.59

    //private MessageManager manager;
	private float angle = 0.0f;

    void Start()
    {
   //     manager = GameObject.FindGameObjectWithTag("Connection").GetComponent<MessageManager>();
    }

    void Update()
    {
		/*
        if (manager && manager.Server.IsConnected)
        {
            float angle = Move((float)manager.scaraRealTo3d.Joints[1].Position);
            transform.localRotation = Quaternion.Euler(transform.localRotation.eulerAngles.x, angle, transform.localRotation.eulerAngles.z);
        }
        */
		angle += Input.GetAxis ("Motor2");
		transform.localRotation = Quaternion.Euler(transform.localRotation.eulerAngles.x, angle, transform.localRotation.eulerAngles.z);
    }


    float Move(float angle)
    {
        float result = left - angle;
        if (result < 360)
            return 360 + result;
        return result;
    }
}


