using System;

public class SkillCrit : SkillRefineBase
{
	public float BuffRate;

	public int BuffId;

	public Action<EntityBase, long> CritCallback;

	public Action<EntityBase, EntityBase, long> BabyCritCallback;

	public SkillCrit(EntityBase entity)
		: base(null)
	{
	}

	public override void Init()
	{
	}

	public override void DeInit()
	{
	}

	private void OnCrit(EntityBase attackTarget, long hit)
	{
	}
}
