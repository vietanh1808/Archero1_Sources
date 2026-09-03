using UnityEngine;

public class BulletBombBase : BulletBase
{
	[Header("延迟时间")]
	public float DelayTime;

	[Header("爆炸冲击时间")]
	public float BombTime;

	private float showCircleTime;

	protected const float MaxColliderSize = 11f;

	private float mDelaytime;

	protected float mBombTime;

	private bool bColliderUpdate;

	protected override void AwakeInit()
	{
	}

	public override void SetTarget(EntityBase entity, int size = 1)
	{
	}

	protected override void OnInit()
	{
	}

	protected override void OnDeInit()
	{
	}

	public void SetDelayTime(float delayTime)
	{
	}

	protected override void UpdateProcess()
	{
	}

	protected virtual void UpdateBoxSize()
	{
	}

	protected virtual int GetEffectId()
	{
		return 0;
	}
}
