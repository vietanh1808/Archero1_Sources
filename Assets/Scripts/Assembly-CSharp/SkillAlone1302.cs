using System.Collections.Generic;

public class SkillAlone1302 : SkillAloneBase
{
	private Dictionary<EntityBase, int> m_dicEnemies;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void UpdateEnemies(List<EntityBase> enemies)
	{
	}

	private void UpdateEnemy(EntityBase enemy)
	{
	}

	private void OnRemoveEnemy(EntityBase enemy)
	{
	}

	private float OnEnemyHitted(EntityBase entity, HitStruct hit)
	{
		return 0f;
	}
}
