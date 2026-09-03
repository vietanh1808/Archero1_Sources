using System;

public class SkillBodyScale2OtherNew : SkillX2Y
{
	public Action<float, float> onChangedCallback;

	public SkillBodyScale2OtherNew(EntityBase entity, string _externalTag)
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

	protected override float GetOriginalValue()
	{
		return 0f;
	}

	protected override void onChanged(float oldPercent, float curPercent)
	{
	}
}
