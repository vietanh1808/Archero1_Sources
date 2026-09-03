using CodeStage.AntiCheat.ObscuredTypes;

namespace Dxx.AntiCheat
{
	public class AntiCheatValidator
	{
		private AntiCheatLegalData legalData;

		private AntiCheatGameData gameData;

		public AntiCheatValidator(AntiCheatLegalData legalData, AntiCheatGameData gameData)
		{
		}

		public void Init()
		{
		}

		public AntiCheatPvpValidatedResult GetPvpDcResult()
		{
			return null;
		}

		public ObscuredUInt GetAntiCheatPvpEnum()
		{
			return default;
		}

		private string getMixEquipment0(ObscuredUInt cheatEnum)
		{
			return null;
		}

		private string getMixEquipment_0(ObscuredUInt cheatEnum)
		{
			return null;
		}

		private string getAttrInfo()
		{
			return null;
		}

		private string getPvpEquipment0()
		{
			return null;
		}

		private string getPvpEquipment_0()
		{
			return null;
		}

		private string getNonPvpEquipment0()
		{
			return null;
		}

		private string getNonPvpEquipment_0()
		{
			return null;
		}

		private string formatEquipmentString(params string[] infos)
		{
			return null;
		}

		private string closeInfo(string info)
		{
			return null;
		}

		public static bool ContainCheatEnum(ObscuredUInt cheatEnum, ObscuredInt shiftBits)
		{
			return false;
		}

		private bool isInvalidSlotPvpSkillCountAfterPvp()
		{
			return false;
		}

		private string formatSkillIds(ObscuredInt[] skillIds)
		{
			return null;
		}

		private bool isNonPvpSkillConsistent()
		{
			return false;
		}

		private bool isSlotinPvpSkillCountConsistent()
		{
			return false;
		}

		private bool isSlotinPvpSkillConsistent()
		{
			return false;
		}

		private bool isSkillsLegalWeight()
		{
			return false;
		}

		private bool isLegalWeight(int weight)
		{
			return false;
		}
	}
}
