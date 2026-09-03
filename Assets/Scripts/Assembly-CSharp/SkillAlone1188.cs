using System.Collections.Generic;

public class SkillAlone1188 : SkillAlone1187
{
	private float iceTime;

	private int debuffId;

	private Dictionary<EntityBase, float> m_dicAddDebuffTimes;

	protected override void OnInstall()
	{
	}

	protected override void OnUpdate(float delta)
	{
	}

	protected override bool CheckEnemy(EntityBase entity)
	{
		return false;
	}
}
