using System.Collections.Generic;
using TableTool;
using UnityEngine;

public class SkillAlone2111 : SkillAloneBase
{
	private float CONFIG_HIT_RATE;

	private float CONFIG_KILL_RATE;

	protected float CONFIG_TIME;

	private float CONFIG_REDUCE_TIME;

	private List<Goods_goods.GoodData> m_listAttrs;

	protected SkillAlone2111Ctrl mSkillAlone2111Ctrl;

	private float m_fTime;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnUpdate(float delta)
	{
	}

	private void OnHit(EntityBase entity, HitStruct hs, HittedData data)
	{
	}

	private void OnKill(EntityBase entity, Vector3 HittedDirection, HitStruct hs)
	{
	}

	private void CreateGoldBall(float rate)
	{
	}

	protected virtual bool DoCreateGoldBall()
	{
		return false;
	}

	private void OnHitted(EntityBase entity, long value)
	{
	}

	protected virtual void OnTrigger()
	{
	}

	protected virtual void End()
	{
	}
}
