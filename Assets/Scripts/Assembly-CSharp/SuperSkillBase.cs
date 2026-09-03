using TableTool;

public class SuperSkillBase
{
	private float mLastUseTime;

	public int SkillID { get; private set; }

	public Skill_super m_Data { get; private set; }

	public EntityHero m_Entity { get; private set; }

	public bool CanUseSkill => false;

	public void Init(EntityHero entity)
	{
	}

	protected virtual void OnInit()
	{
	}

	public void DeInit()
	{
	}

	protected virtual void OnDeInit()
	{
	}

	public void UseSkill()
	{
	}

	protected virtual void OnUseSkill()
	{
	}
}
