public class SkillStatic : SkillRefineBase
{
	public float m_fStillTime;

	public float m_fValue;

	public string m_sAttr;

	private float m_fTime;

	private bool m_bAddAttrFlag;

	public SkillStatic(EntityBase entity)
		: base(null)
	{
	}

	public override void Init()
	{
	}

	public override void DeInit()
	{
	}

	private void OnUpdate(float delta)
	{
	}
}
