using System;

public class RealFlashSuperSkillVO
{
	protected bool m_bSuperSkill;

	public EntityHero m_Entity;

	public Action OnSuperSkillStartCallback;

	public Action OnSuperSkillEndCallback;

	public void Init()
	{
	}

	public void DeInit()
	{
	}

	private void OnHammerChangeState(bool isFlash)
	{
	}

	public bool IsSuperSkillWorking()
	{
		return false;
	}
}
