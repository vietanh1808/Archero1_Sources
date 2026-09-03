using UnityEngine;

public class SkillAlone2227 : SkillAlone2226
{
	private int perKillAddEjectCount;

	private int addMaxNum;

	private int addMaxEjectCount;

	private float perKillAddSkillBoomDmgScale;

	private float addMaxSkillBoomDmgScale;

	private int haveAddNum;

	private float haveAddSkillBoomDmgScale;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnKillEnemy(EntityBase entity, Vector3 pos, HitStruct hs)
	{
	}

	protected override void SkillClear()
	{
	}

	protected override float GetSkillFinalBoomDmgScale()
	{
		return 0f;
	}
}
