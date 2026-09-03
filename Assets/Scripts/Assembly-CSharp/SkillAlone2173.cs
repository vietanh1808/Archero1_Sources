using System.Collections.Generic;

public class SkillAlone2173 : SkillAloneBase
{
	private float addDeBuffRate;

	private int enemyBuffId;

	private float enemyCdTime;

	private int buffId;

	private Dictionary<int, float> m_EnemyCdDict;

	private int snakeBuffId;

	protected override void OnInstall()
	{
	}

	private void ParseParams()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnHitted(EntityBase enemy, HitStruct hs, HittedData ht)
	{
	}

	private void GotoNextRoom(RoomGenerateBase.Room room)
	{
	}
}
