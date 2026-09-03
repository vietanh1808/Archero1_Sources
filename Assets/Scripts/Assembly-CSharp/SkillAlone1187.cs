using System.Collections.Generic;

public class SkillAlone1187 : SkillAloneBase
{
	private float ratio;

	private float radius;

	private float interval;

	private int debuffId_1;

	private int debuffId_2;

	private int debuffId_3;

	private float lastAttackSpeed;

	private float time;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnParentChangeHP(long currentHP, long maxHP, float percent, long change)
	{
	}

	protected virtual void AddAttackSpeed()
	{
	}

	protected virtual void OnUpdate(float delta)
	{
	}

	protected virtual List<EntityBase> GetEnemies()
	{
		return null;
	}

	protected virtual bool CheckEnemy(EntityBase entity)
	{
		return false;
	}

	protected void AddDebuff(EntityBase entity)
	{
	}
}
