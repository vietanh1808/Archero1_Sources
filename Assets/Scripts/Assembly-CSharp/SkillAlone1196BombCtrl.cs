using System;
using UnityEngine;

public class SkillAlone1196BombCtrl : SkillAloneGoodCtrlBase
{
	private ConditionBase mCondition1;

	private ConditionBase mCondition2;

	private float DelayTimeEnable;

	private int m_nCallId;

	private float m_fCallTime;

	private int m_nAddTimePerKill;

	private float m_fAttackRatio;

	private float m_fBodyHitRatio;

	private float m_fLvUpAttackUp;

	private int m_nBuffId;

	private int m_nDebuffId;

	private float m_fInheritAttackSpeed;

	private Action<SkillAlone1196BombCtrl> OnDeInitEvent;

	private Action<EntityPartBodyBase> OnCallEvent;

	private SphereCollider mCollider => null;

	public void Init(EntityBase entity, int[] debuffs, float time, int callId, float callTime, int nAddTimePerKill, float fAttackRatio, float fLvUpAttackUp, int nBuffId, float fBodyHitRatio, int nDebuffId, float fInheritAttackSpeed, Action<SkillAlone1196BombCtrl> OnDeInitEvent, Action<EntityPartBodyBase> OnCallEvent)
	{
	}

	protected override void OnInit()
	{
	}

	protected override void OnDeInit()
	{
	}

	protected override void UpdateProcess()
	{
	}

	private void BoxEnable(bool bEnable)
	{
	}

	private void OnCondition2End()
	{
	}

	protected override void OnTrigger()
	{
	}
}
