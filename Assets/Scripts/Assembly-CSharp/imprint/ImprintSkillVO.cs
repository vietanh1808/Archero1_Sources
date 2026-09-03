using System.Collections.Generic;

namespace imprint
{
	public class ImprintSkillVO
	{
		private const string TAG = "[ImprintSkillVO]";

		public int ImprintId;

		public LocalSave.ImprintOne ImprintOne;

		public Dictionary<int, SkillMappingVO> MappingDict;

		public ImprintSkillVO(LocalSave.ImprintOne one)
		{
		}

		public void Init()
		{
		}

		public void DeInit()
		{
		}

		public override string ToString()
		{
			return null;
		}

		private string GetMappingSkillInfo()
		{
			return null;
		}

		public bool ConstainProtoSkill(int skillId)
		{
			return false;
		}

		private void logError(string info)
		{
		}

		public void InitMappingDict()
		{
		}

		public int GetMappingSkillId(int protoSkillId)
		{
			return 0;
		}

		private int GetUnlockedImprintSkillId(int imprintSkillMetaId, int unlockLevel)
		{
			return 0;
		}

		private int GetUnlockedImprintSkillIdInternal(int[] unlockedLevels, string[] unlockedLevelAttributes, int unlockedLevel)
		{
			return 0;
		}
	}
}
