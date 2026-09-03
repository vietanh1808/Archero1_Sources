using System.Collections.Generic;

public class SkillAloneBabyBase : SkillAloneBase
{
	protected EntityBabyBase baby;

	protected int mBabyID;

	private const string REFINE_TAG_ATT = "[精炼属性-宝宝]";

	private const string REFINE_TAG_SKILL = "[精炼技能-宝宝]";

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	protected void babyLearnAttributes(LocalSave.EquipOne one)
	{
	}

	protected void babyLearnSkills(LocalSave.EquipOne one)
	{
	}

	protected void babyLearnCarvingItemSkills(LocalSave.EquipOne one)
	{
	}

	protected void babyLearnRefineAttr()
	{
	}

	protected void babyLearnRefineSkill()
	{
	}

	private List<int> getBabyRefineSkillIds(int curPosLevel, int curPos)
	{
		return null;
	}
}
