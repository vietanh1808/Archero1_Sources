using System.Collections.Generic;
using UnityEngine;

public class SkillAlone2298 : SkillAloneBase
{
	public class Skill2298_State : CustomJsonActionVO
	{
		public Vector3 Pos;
	}

	private float m_rate;

	private float m_radius;

	private float m_hurtPercent;

	private int m_buffid;

	private float m_hpPercent;

	private float m_dtime;

	private float nextTime;

	private const string SyncSkill2298_State = "SyncSkill2298_State";

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	protected virtual void OnHitAction(EntityBase entity, HitStruct hs, HittedData ht)
	{
	}

	private void hit(EntityBase entity)
	{
	}

	private void createEffect(Vector3 pos, bool executeLogic = true)
	{
	}

	private List<EntityBase> GetMonsterList(Vector3 center, float radius)
	{
		return null;
	}

	private void syncEffectState(Vector3 pos)
	{
	}

	private void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}
}
