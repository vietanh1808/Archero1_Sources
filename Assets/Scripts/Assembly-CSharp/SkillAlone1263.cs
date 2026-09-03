using System.Collections.Generic;

public class SkillAlone1263 : SkillAloneBase
{
	private float m_fRate;

	private int m_nMonsterId;

	private int m_nCnt;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnAddEnemy(EntityBase entity)
	{
	}

	private IEnumerable<(int, int, bool, bool)> OnMonsterDeadDivide(EntityBase e)
	{
		return null;
	}

	private void OnRemoveEnemy(EntityBase entity)
	{
	}
}
