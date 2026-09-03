using System;

public class SkillHitted : SkillRefineBase
{
	public int BuffId;

	public float BuffRate;

	public Action<EntityBase, long> OnHittedCallback;

	public SkillHitted(EntityBase entity)
		: base(null)
	{
	}

	public override void Init()
	{
	}

	public override void DeInit()
	{
	}

	private void onHitted(EntityBase enemy, long realhit)
	{
	}
}
