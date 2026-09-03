using System;
using UnityEngine;

public class SkillKillEnemy : SkillRefineBase
{
	public int BuffId;

	public float BuffRate;

	public Action<EntityBase, Vector3, HitStruct> KillCallback;

	public SkillKillEnemy(EntityBase entity)
		: base(null)
	{
	}

	public override void Init()
	{
	}

	public override void DeInit()
	{
	}

	private void onKill(EntityBase attackTarget, Vector3 HittedDirection, HitStruct hs)
	{
	}
}
