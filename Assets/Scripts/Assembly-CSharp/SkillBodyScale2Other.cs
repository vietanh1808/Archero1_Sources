using System;

public class SkillBodyScale2Other : SkillIndependent2Dependent
{
	public Action<float, float> onChangedCallback;

	public SkillBodyScale2Other(EntityBase entity, string _externalTag)
		: base(null, null)
	{
	}

	protected override void OnBeforeInit()
	{
	}

	protected override void OnBeforeDeInit()
	{
	}

	public override float GetIndependentAttributeValue()
	{
		return 0f;
	}

	protected override void onChanged(float oldPercent, float curPercent)
	{
	}
}
