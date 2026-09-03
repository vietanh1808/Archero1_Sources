using System;
using PureMVC.Patterns;

public class ChooseSkillProxy : Proxy
{
	public enum ChooseSkillType
	{
		eLevel = 0,
		eFirst = 1,
		eEquip = 2,
		eSkill = 3,
		eEventTowerBossHp = 4,
		eSLGSkill = 5,
		eTowerDefenceSkill = 6
	}

	public class Transfer
	{
		public ChooseSkillType type;

		public int level;

		public int num;

		public int id;

		public Action OnCloseEvent;

		public BattleBossHPCtrl.BossHPSkillVO BossHPSkillVO;

		public void RefreshLevel()
		{
		}
	}

	public new const string NAME = "ChooseSkillProxy";

	public ChooseSkillProxy(object data)
	{
	}
}
