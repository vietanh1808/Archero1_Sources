public abstract class SkillX2Y : SkillAloneIndependent2DependentBase
{
	public float MaxIncreasedValue;

	public string ValueKey;

	public string DependentAttr;

	public float Indepent2DependentRatio;

	public long Independent2Dependent;

	public float OriginalAttrValue;

	private string UniqueId => null;

	public abstract float GetIndependentAttributeValue();

	public SkillX2Y(EntityBase entity, string _externalTag)
		: base(null)
	{
	}

	public void Init()
	{
	}

	public void DeInit()
	{
	}

	protected virtual void OnBeforeInit()
	{
	}

	protected virtual void OnBeforeDeInit()
	{
	}

	protected virtual float GetOriginalValue()
	{
		return 0f;
	}

	protected virtual void onChanged(float oldPercent, float curPercent)
	{
	}
}
