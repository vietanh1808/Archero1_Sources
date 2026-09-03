using UnityEngine;

public class PVPAimCtrl : PVPAimCtrlBase
{
	[Header("最大旋转角度")]
	private int MaxAngle;

	[Header("箭头旋转速度（每秒）")]
	private int AngleSpeedPerSec;

	[Header("扇形旋转速度（每秒）")]
	private int SectorAngleSpeedPerSec;

	public Transform left;

	public Transform right;

	public Transform rotateChild;

	private int state;

	private float currentAngle;

	private int lastState;

	private int Local_MaxAngle => 0;

	private int Local_AngleSpeedPerSec => 0;

	private int Local_SectorAngleSpeedPerSec => 0;

	public override void Init(EntityBase entity)
	{
	}

	public override void DeInit()
	{
	}

	public override void OnUpdate()
	{
	}

	public void ResetRotation()
	{
	}

	private void updateRotateTransform()
	{
	}

	public override void SetCurrentAngle(float angle)
	{
	}

	public override float GetCurrentAngle()
	{
		return 0f;
	}

	public override void StartAttack()
	{
	}

	public override void StopAttack()
	{
	}

	public override Quaternion GetLineDir()
	{
		return default;
	}

	public override void SetLineDir(Quaternion rot)
	{
	}

	private bool isMoving()
	{
		return false;
	}

	public override float GetCurrentAttackAngle()
	{
		return 0f;
	}
}
