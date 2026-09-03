using System.Collections.Generic;

public class SkillAlone1166 : SkillAloneBase
{
	private class SkillPlus
	{
		public enum Trigger_Event
		{
			None = 0,
			AbsorbHp = 1
		}

		private EntityBase m_Entity;

		public bool CanTrigger { get; set; }

		public Trigger_Event TriggerEvent { get; private set; }

		public int EffectId { get; private set; }

		public string AttrName { get; private set; }

		public float AddPercent { get; private set; }

		public float Max { get; private set; }

		public float AddedPercent { get; private set; }

		public float AddedPercentPerRoom { get; private set; }

		public SkillPlus(EntityBase entity, int effectId, string arg)
		{
		}

		public void DeInit()
		{
		}

		private void ParseEvent(string arg)
		{
		}

		private void OnAbsorbHpFood(FoodBase food)
		{
		}

		private bool Trigger()
		{
			return false;
		}

		public void Trgger(string attrName, float value)
		{
		}

		public void Save()
		{
		}
	}

	private Dictionary<int, List<SkillPlus>> m_dicSkillAddtions;

	protected override void OnInstall()
	{
	}

	private void ParseArgs()
	{
	}

	private void InitSavedDatas()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void onLearNewSkill(int skillId)
	{
	}

	private void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}
}
