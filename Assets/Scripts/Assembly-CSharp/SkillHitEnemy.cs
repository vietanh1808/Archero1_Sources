using System;

public class SkillHitEnemy : SkillRefineBase
{
	public int BuffId;

	public float BuffRate;

	public Action<EntityBase, HitStruct, HittedData> HitCallback;

	public SkillHitEnemy(EntityBase entity)
		: base(null)
	{
	}

	public override void Init()
	{
	}

	public override void DeInit()
	{
	}

	private void onHit(EntityBase attackTarget, HitStruct data, HittedData hitteddata)
	{
	}
}
