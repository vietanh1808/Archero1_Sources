using System.Collections.Generic;

public class SkillAlone1429 : SkillAloneCritBase
{
	private Dictionary<int, bool> dict;

	private float lastTimestamp;

	private float headShotRate;

	private float timeInterval;

	private float pvpCritDmgBoost;

	protected override void ParseArgs()
	{
	}

	protected override void OnAfterSkillInit()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnCritPvp(EntityBase target, long hit, HitStruct hs)
	{
	}

	private void onCrit(EntityBase attackTarget, long hit)
	{
	}
}
