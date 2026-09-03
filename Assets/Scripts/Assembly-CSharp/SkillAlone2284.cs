using System.Collections.Generic;
using UnityEngine;

public class SkillAlone2284 : SkillAloneBase
{
	public class Skill2284_IceState : CustomJsonActionVO
	{
		public Vector3 Pos;
	}

	private float cfg_rate;

	private float cfg_radius;

	private float cfg_ratio;

	private int cfg_buffid;

	private float cfg_boomTime;

	private float cfg_boomRatio;

	private float cfg_dtime;

	private float nextTime;

	private const string SyncSkill2284_IceState = "SyncSkill2284_IceState";

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	protected virtual void OnHitAction(EntityBase entity, HitStruct hs, HittedData ht)
	{
	}

	private void createIceField(Vector3 pos)
	{
	}

	private List<EntityBase> GetMonsterList(Vector3 center, float radius)
	{
		return null;
	}

	private void syncIceState(Vector3 pos)
	{
	}

	private void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}
}
