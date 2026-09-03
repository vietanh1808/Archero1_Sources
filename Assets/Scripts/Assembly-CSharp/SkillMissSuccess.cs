using System;

public class SkillMissSuccess : SkillRefineBase
{
	public int BuffId;

	public float BuffRate;

	public Action MissCallback;

	public SkillMissSuccess(EntityBase entity)
		: base(null)
	{
	}

	public override void Init()
	{
	}

	public override void DeInit()
	{
	}

	private void onMiss()
	{
	}
}
