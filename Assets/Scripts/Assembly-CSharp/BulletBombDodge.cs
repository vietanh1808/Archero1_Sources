using UnityEngine;

public class BulletBombDodge : BulletBase
{
	[Header("延迟时间")]
	public float DelayTime;

	[Header("爆炸冲击时间")]
	public float BombTime;

	private Transform effect;

	private Vector3 shadowScaleInit;

	private float height;

	private Vector3 endpos;

	private Vector3 dir;

	private bool bStartBomb;

	private float showCircleTime;

	private const float MaxColliderSize = 20f;

	private float mDelaytime;

	private float mBombTime;

	private bool bColliderUpdate;

	private float addspeed;

	protected override void AwakeInit()
	{
	}

	public void SetEndPos(Vector3 endpos)
	{
	}

	protected override void OnInit()
	{
	}

	protected override void OnDeInit()
	{
	}

	private void SetEffectScale(float value)
	{
	}

	private void SetEffectShow(bool value)
	{
	}

	protected override void OnUpdate()
	{
	}

	private void create_divide()
	{
	}

	protected override void UpdateProcess()
	{
	}
}
