using System.Collections.Generic;

public class SkillAlone2164 : SkillAlone2163
{
	private float CONFIG_BOMB_HIT_RATIO;

	private List<int> CONFIG_END_DEBUFF_IDS;

	private List<int> CONFIG_END_BUFF_IDS;

	private float CONFIG_DISTANCE;

	private float CONFIG_RADIUS;

	protected override void OnInstall()
	{
	}

	protected override bool OnExcuteOneArg(string str)
	{
		return false;
	}

	protected override void OnEnd()
	{
	}
}
