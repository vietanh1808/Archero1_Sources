using System.Collections.Generic;
using CodeStage.AntiCheat.ObscuredTypes;

namespace Dxx.AntiCheat
{
	public class AntiCheatLegalData
	{
		public ObscuredInt[] AllSlotinPvpSkillIds { get; set; }

		public ObscuredInt[] RandomSlotinPvpSkillIds { get; set; }

		public void Init()
		{
		}

		public void ClearPvpRecordData()
		{
		}

		public void RandomizeCryptoKey()
		{
		}

		public void RandomizeCryptoKeyInPvp()
		{
		}

		private void initAllPvpSkillIds()
		{
		}

		public bool IsInLegalSkillIdsInPvp(int _skillId)
		{
			return false;
		}

		public bool IsInAllSkillIdsInPvp(int _skillId)
		{
			return false;
		}

		public List<ObscuredInt> GetSelfSkillIdsInPvp(List<ObscuredInt> allSkillIds)
		{
			return null;
		}

		private bool findSkillId(ObscuredInt[] skillIds, int _skillId)
		{
			return false;
		}
	}
}
