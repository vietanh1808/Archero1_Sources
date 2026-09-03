using System.Collections.Generic;

public class SkillAlone1174 : SkillAloneBase
{
	private List<EntityBase> m_listEntities;

	private float m_fTime;

	private float m_fRange;

	private float m_fValue;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnUpdate(float delta)
	{
	}

	private void OnMonsterDead(EntityBase entity)
	{
	}

	private void OnRemoveEntity(EntityBase entity)
	{
	}

	protected virtual List<EntityBase> GetEnemies()
	{
		return null;
	}
}
