using System.Collections.Generic;
using CodeStage.AntiCheat.ObscuredTypes;

namespace Dxx.AntiCheat
{
	public class PvpHeroVO
	{
		public ObscuredInt skinId;

		public List<SlotSkillVO> skillVOList;

		public string equipment0 => null;

		public PvpHeroVO(int skinId)
		{
		}

		public void RandomizeCryptoKey()
		{
		}

		public void AddSlotSkillVO(SlotSkillVO skillVO)
		{
		}

		public SlotSkillVO GetSlotSkillVO(int skillId)
		{
			return null;
		}

		public ObscuredInt[] GetRandomSkillIds()
		{
			return null;
		}
	}
}
