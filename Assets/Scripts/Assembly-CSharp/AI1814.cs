using Dxx.Util;
using UnityEngine;

public class AI1814 : AIBase
{
	private float m_fTime;

	private SequencePool mSeqPool;

	protected virtual float AttackRatio { get; set; }

	protected virtual float BodyHitRatio { get; set; }

	protected virtual int AddTimePerKill { get; set; }

	protected virtual float LvUpAttackUp { get; set; }

	protected virtual int BuffId { get; set; }

	protected virtual int DebuffId { get; set; }

	private EntityBase Parent => null;

	public void Init(float fAttackRatio, int nAddTimePerKill, float fLvUpAttackUp, int nBuffId, float fBodyHitRatio, int nDebuffId)
	{
	}

	protected override void OnInit()
	{
	}

	protected virtual void InitAttribute()
	{
	}

	protected override void OnAIDeInit()
	{
	}

	protected virtual ActionBase GetAttackAction()
	{
		return null;
	}

	protected override void OnUpdate(float delta)
	{
	}

	private void ExcuteAttribute(string name, long value)
	{
	}

	protected virtual void RefreshAIAction()
	{
	}

	private void OnLevelUpEvent(int lv)
	{
	}

	private void OnKillAction(EntityBase entity, Vector3 HittedDirection, HitStruct hs)
	{
	}

	private void OnHitAction(EntityBase entity, HitStruct hs, HittedData data)
	{
	}
}
