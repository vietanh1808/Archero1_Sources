using UnityEngine;

public class SkillAlone2236 : SkillAlone2235
{
	private int perKillAddSkillDmgPercent;

	private int addSkillDmgMaxCount;

	private int perKillAddSkillLastTimePercent;

	private int addSkillLastTimeMaxCount;

	private float skillLastTimeAddScale;

	protected override float RealSkillLastTime => 0f;

	private LocalSave.Skill2236VO Skill2236VO => null;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnKillEnemy(EntityBase entity, Vector3 pos, HitStruct hs)
	{
	}
}
