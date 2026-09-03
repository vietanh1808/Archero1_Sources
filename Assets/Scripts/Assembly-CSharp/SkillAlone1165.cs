using System.Collections.Generic;

public class SkillAlone1165 : SkillAloneBase
{
	private int m_nSkillCnt;

	private float m_fElementCritRate;

	private int m_nMaxElementSkillCnt;

	private List<int> m_listLearnedElementSkills;

	private Dictionary<string, int> m_dicElementBuffs;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void onLearNewSkill(int skillId)
	{
	}
}
