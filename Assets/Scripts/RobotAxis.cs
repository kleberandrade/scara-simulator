using UnityEngine;
using System.Collections;

public class RobotAxis : MonoBehaviour
{
	public AxisType axisType = AxisType.None;
	public string axisName = string.Empty;
	[Range(-360.0f, 360.0f)]
	public float origin = 0.0f;
	[Range(0.0f, 360.0f)]
	public float range = 0.0f;

	public float height = 0.0f;

	private float position = 0.0f;
	private float movement = 0.0f;


	void Update () 
	{
		movement += Input.GetAxis (axisName);

		switch (axisType) 
		{
			case AxisType.Rotate:
				position = RotateAxis(origin, movement);
				transform.localRotation = Quaternion.Euler(transform.localRotation.eulerAngles.x, position, transform.localRotation.eulerAngles.z);
				break;

			case AxisType.Translate:
				position = TranslateAxis(movement);
				transform.localPosition = new Vector3(transform.localPosition.x, position, transform.localPosition.z);
				break;
		}
	}

	private float RotateAxis(float origin, float angle)
	{
		float result = origin - angle;
		if (result < 360.0f)
			return 360.0f + result;
		return result;
	}

	float TranslateAxis(float position)
	{
		float result = origin + ((origin - height) * (-position) / range);
		return Mathf.Clamp(result, height, origin);
	}
}

public enum AxisType
{
	None,
	Rotate,
	Translate,
	Grasp
}