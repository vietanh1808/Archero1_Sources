public class SkillMissRate2Other : SkillIndependent2Dependent
{
	public SkillMissRate2Other(EntityBase entity, string _externalTag)
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
}
