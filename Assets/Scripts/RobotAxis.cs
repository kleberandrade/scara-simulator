using UnityEngine;
using System.Collections;

public class RobotAxis : MonoBehaviour
{
	public AxisType axisType = AxisType.None;

	void Start () 
	{
	
	}

	void Update () 
	{
	
	}
}

public enum AxisType
{
	None,
	Rotate,
	Translate,
	Grasp
}