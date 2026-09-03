using System;
using UnityEngine;

public class AIDragonBase : ActionBasic
{
	public EntityDragonBase m_Entity;

	public Transform BulletNode;

	protected float FixedDeltaSpeed;

	protected float FixedContinuousDeltaSpeed;

	private GameObject goPlayerEffect;

	private const int QUALITY_PURPLE = 4;

	private AIBase.ActionSequence seq;

	protected virtual int AttackLoopCount => 0;

	protected string Tag => null;

	protected EntityBase HostEntity => null;

	protected float deltaMagicReleaseSpeed => 0f;

	protected virtual float deltaSpeed => 0f;

	protected override void OnInit1()
	{
	}

	public override void DeInit()
	{
	}

	public virtual void BeforeStartAttack()
	{
	}

	public virtual void AfterAttackCompleted()
	{
	}

	public void StartAttack()
	{
	}

	protected virtual void BeforeSkillAppear()
	{
	}

	protected virtual void AfterSkillAppear()
	{
	}

	protected virtual void BeforeSkillAttackPre()
	{
	}

	protected virtual void AfterSkillAttackPre()
	{
	}

	protected virtual void BeforeSkillContinuousAttack()
	{
	}

	protected virtual void AfterSkillContinuousAttack()
	{
	}

	protected virtual void BeforeSkillAttackEnd()
	{
	}

	protected virtual void AfterSkillAttackEnd()
	{
	}

	protected virtual void BeforeSkillDisappear()
	{
	}

	protected virtual void AfterSkillDisappear()
	{
	}

	private void AfterSkillDisappearInternal()
	{
	}

	private void tryCreateDragon()
	{
	}

	public virtual void StopAndDisappear()
	{
	}

	public bool IsAttacking()
	{
		return false;
	}

	protected virtual AIBase.ActionSequence getAnimSequenceAction()
	{
		return null;
	}

	protected ActionBase getWaitTimeAction(string anim)
	{
		return null;
	}

	protected ActionBase getPlayAction(string anim)
	{
		return null;
	}

	protected ActionBase getBeforeAnimAction(Action callback)
	{
		return null;
	}

	protected ActionBase getAfterAnimAction(Action callback)
	{
		return null;
	}

	protected BulletBase CreateBulletInternal(EntityBase entity, int BulletID, Vector3 pos, Quaternion rota, bool clear, Transform parent = null)
	{
		return null;
	}

	private void playQualityEffectForPlayer()
	{
	}
}
