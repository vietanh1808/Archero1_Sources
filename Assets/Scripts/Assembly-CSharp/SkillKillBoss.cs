using System;
using UnityEngine;

public class SkillKillBoss : SkillRefineBase
{
	public int BuffId;

	public Action<EntityBase, Vector3, HitStruct> KillCallback;

	public SkillKillBoss(EntityBase entity)
		: base(null)
	{
	}

	public override void Init()
	{
	}

	public override void DeInit()
	{
	}

	private void onkill(EntityBase enemy, Vector3 pos, HitStruct hit)
	{
	}
}
