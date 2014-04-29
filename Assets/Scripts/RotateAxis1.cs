using UnityEngine;
using System.Collections;

public class RotateAxis1 : MonoBehaviour {

    public float curso = 200.0f;    // degree
    public float velocity = 10.0f;

    // 0 - 200
    private float left = 62.13f;
    //private float right = 222.13f;  // -79.59

    //private MessageManager manager;

	private float angle = 0.0f;


    void Start()
    {
     //   manager = GameObject.FindGameObjectWithTag("Connection").GetComponent<MessageManager>();
    }

    void Update()
    {
		/*
        if (manager && manager.Server.IsConnected)
        {
            float angle = Move((float)manager.scaraRealTo3d.Joints[0].Position);
            transform.localRotation = Quaternion.Euler(transform.localRotation.eulerAngles.x, angle, transform.localRotation.eulerAngles.z);
        }
        */

		angle += Input.GetAxis ("Motor1");
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

