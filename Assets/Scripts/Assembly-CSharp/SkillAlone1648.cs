using System.Collections.Generic;

public class SkillAlone1648 : SkillAloneBase
{
	private float m_fInterval;

	private List<int> m_listDebuffs;

	private float m_fLastDebuffTime;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnChangeHP(long currentHP, long maxHP, float percent, long change)
	{
	}

	protected virtual List<EntityBase> GetEnemies()
	{
		return null;
	}

	protected virtual void SendBuff(EntityBase target, int id)
	{
	}
}
