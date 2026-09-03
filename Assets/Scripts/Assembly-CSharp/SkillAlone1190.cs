using System.Collections.Generic;

public class SkillAlone1190 : SkillAloneBase
{
	private class SkillWeight
	{
		public int id;

		public int weight;

		public SkillWeight(string str)
		{
		}
	}

	private int m_nSkinId;

	private List<SkillWeight> m_listNpcSkills;

	private int m_nWeightAll;

	protected override void OnInstall()
	{
	}

	private void InitChallengeNpcAttrs()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnLearnSkill(int skinId, int skillId)
	{
	}
}
