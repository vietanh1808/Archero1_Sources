public abstract class SkillRefineBase
{
	public string ExternalTag;

	public EntityBase m_Entity;

	protected string Tag => null;

	public SkillRefineBase(EntityBase entity)
	{
	}

	public abstract void Init();

	public abstract void DeInit();
}
