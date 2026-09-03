using UnityEngine;

public class XR_script_rotator01 : MonoBehaviour
{
	[Tooltip("旋转轴(无需归一化,会自动处理)")]
	public Vector3 rotationAxis;

	[Tooltip("旋转速度(度/秒)")]
	public float rotationSpeed;

	[Tooltip("旋转参考坐标系")]
	public Space rotationSpace;

	private void Update()
	{
	}
}
