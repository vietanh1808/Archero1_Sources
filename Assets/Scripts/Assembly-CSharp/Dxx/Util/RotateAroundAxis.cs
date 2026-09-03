using UnityEngine;

namespace Dxx.Util
{
	public class RotateAroundAxis
	{
		public enum AxisEnum
		{
			X = 0,
			Y = 1,
			Z = 2
		}

		private string updateID;

		private Transform targetTrans;

		private float rotateSpeedPerSecond;

		private AxisEnum axisEnum;

		public Transform TargetTrans => null;

		public bool RotateEnable { get; set; }

		public float RotateSpeedPerSecond
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public RotateAroundAxis(Transform _targetTrans, float _rotateSpeedPerSecond = 0f, AxisEnum _axisEnum = AxisEnum.Y)
		{
		}

		public void Destroy()
		{
		}

		public void Init(string _updateID)
		{
		}

		public void DeInit()
		{
		}

		public void OnUpdate(float delta)
		{
		}
	}
}
