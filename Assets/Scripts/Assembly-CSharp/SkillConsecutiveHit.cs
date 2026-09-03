using System;

public class SkillConsecutiveHit : SkillRefineBase
{
	public int consecutiveCount;

	private int deBuffId;

	public Action<EntityBase, BulletBase.ConsecutiveHitsData> OnConsecutiveHitCallback;

	public SkillConsecutiveHit(EntityBase entity)
		: base(null)
	{
	}

	public override void Init()
	{
	}

	public override void DeInit()
	{
	}

	private void OnConsecutiveHit(EntityBase attackTarget, BulletBase.ConsecutiveHitsData lightData)
	{
	}
}
