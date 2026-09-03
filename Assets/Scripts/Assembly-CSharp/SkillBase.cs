using System.Collections.Generic;
using TableTool;

public class SkillBase
{
	protected EntityBase m_Entity;

	protected Skill_skill m_Data;

	private bool m_bInstalled;

	private List<SkillAloneBase> effects;

	public Skill_skill Data => null;

	public bool Installed => false;

	public void Install(EntityBase entity, Skill_skill data, params object[] args)
	{
	}

	private void InstallEffects(params object[] args)
	{
	}

	public SkillAloneBase GetSkillAloneInstance(int index = 0)
	{
		return null;
	}

	protected virtual SkillAloneBase GetSkillAloneBase(int skillId)
	{
		return null;
	}

	private void UpdateAttributes(int symbol)
	{
	}

	public void Uninstall()
	{
	}

	protected virtual void OnInstall(params object[] args)
	{
	}

	protected virtual void OnUninstall()
	{
	}

	public SkillAloneBase GetSkillAloneBaseById(int skillAloneId)
	{
		return null;
	}

	public int GetSkillId()
	{
		return 0;
	}
}
