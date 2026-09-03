using System;

public class LanceShieldSuperSkill
{
	protected bool m_bSuperSkill;

	public EntityHero m_Entity;

	public Action OnSuperSkillStartCallback;

	public Action OnSuperSkillEndCallback;

	public virtual void Init()
	{
	}

	public virtual void DeInit()
	{
	}

	private void OnLanceShieldChangeState(bool isCannon)
	{
	}

	public bool IsSuperSkillWorking()
	{
		return false;
	}
}
