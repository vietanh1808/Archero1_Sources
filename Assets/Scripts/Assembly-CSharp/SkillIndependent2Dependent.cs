public abstract class SkillIndependent2Dependent : SkillAloneIndependent2DependentBase
{
	public float MaxIncreasedValue;

	public string ValueKey;

	public string DependentAttr;

	public float Indepent2DependentRatio;

	public long Independent2Dependent;

	public float OriginalAttrValue;

	private string UniqueId => null;

	public abstract float GetIndependentAttributeValue();

	public SkillIndependent2Dependent(EntityBase entity, string _externalTag)
		: base(null)
	{
	}

	public void Init()
	{
	}

	public void DeInit()
	{
	}

	private void onCreatePlayer()
	{
	}

	private void SetOriginalValue()
	{
	}

	protected virtual void OnBeforeInit()
	{
	}

	protected virtual void OnBeforeDeInit()
	{
	}

	protected virtual void onChanged(float oldPercent, float curPercent)
	{
	}
}
