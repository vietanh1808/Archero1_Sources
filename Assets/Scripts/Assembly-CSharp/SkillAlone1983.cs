using System.Collections.Generic;
using UnityEngine;

public class SkillAlone1983 : SkillAloneBase
{
	protected float CONFIG_RATE;

	protected float CONFIG_CD;

	protected float CONFIG_SKILL_TIME;

	protected int CONFIG_BUFF_ID;

	protected float CONFIG_HP_RECOVER_PERCENT;

	protected float CONFIG_SKILL_HIT_RATIO;

	protected float CONFIG_SKILL_BOMB_HIT_RATIO;

	protected int CONFIG_RADIUS;

	protected float CONFIG_SKILL_RADIUS;

	protected const int EFFECT_ID = 1983;

	protected SkillAlone1983Ctrl m_ctrl;

	private float? m_fLastUseTime;

	private List<EntityBase> m_listHittedEnemies;

	private GameObject m_gourd;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnUpdate(float delta)
	{
	}

	private void OnKillAction(EntityBase entity, Vector3 HittedDirection, HitStruct hs)
	{
	}

	private void OnHitted(EntityBase entity, long hit)
	{
	}

	protected virtual void CreateEffect(Vector3 pos)
	{
	}

	private void OnEnterCircle(EntityBase entity)
	{
	}

	private void OnExitCircle(EntityBase entity)
	{
	}

	protected virtual void ShowGourd(bool show)
	{
	}

	private void DestroyGourd()
	{
	}

	private void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void CacheCircle()
	{
	}
}
