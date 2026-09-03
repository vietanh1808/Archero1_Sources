using System.Collections.Generic;
using TableTool;

public class MBSkillBase
{
	protected EntityMonsterBase m_Entity;

	protected Farm_BattleMonsterSkill m_Data;

	private List<MBSkillAloneBase> effects;

	public void Install(EntityMonsterBase entity, Farm_BattleMonsterSkill data, params object[] args)
	{
	}

	public void Uninstall()
	{
	}

	private void installEffects(params object[] args)
	{
	}

	private void updateAttributes(int symbol)
	{
	}
}
