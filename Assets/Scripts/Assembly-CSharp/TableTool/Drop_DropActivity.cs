using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Drop_DropActivity : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _Tag;

		private ObscuredInt _Version;

		private ObscuredInt _ChestType;

		private ObscuredInt _Type;

		private ObscuredInt _Type2;

		private ObscuredInt _Type3;

		private ObscuredString _Normal_before;

		private ObscuredString _Normal;

		private ObscuredString _Normal_Artifact;

		private ObscuredString _Normal_MagicCrystal;

		private ObscuredInt _OpenTime;

		private ObscuredInt _EndTime;

		private ObscuredString _ActivityEquipId;

		private ObscuredString _ActivityEquipId2;

		private ObscuredString _ActivityEquipId3;

		private ObscuredInt _Rate;

		private ObscuredString _ServerRate;

		private ObscuredString _New1;

		private ObscuredString _New2;

		private ObscuredString _New3;

		private ObscuredString _GuaranteeEquipId1;

		private ObscuredString _GuaranteeEquipId2;

		private ObscuredString _GuaranteeEquipId3;

		private ObscuredInt _GuaranteeTimes1;

		private ObscuredInt _GuaranteeTimes2;

		private ObscuredInt _GuaranteeTimes3;

		private ObscuredInt _ClearGuaranteeTimes;

		public int ID => 0;

		public int Tag => 0;

		public int Version => 0;

		public int ChestType => 0;

		public int Type => 0;

		public int Type2 => 0;

		public int Type3 => 0;

		public string Normal_before => null;

		public string Normal => null;

		public string Normal_Artifact => null;

		public string Normal_MagicCrystal => null;

		public int OpenTime => 0;

		public int EndTime => 0;

		public string ActivityEquipId => null;

		public string ActivityEquipId2 => null;

		public string ActivityEquipId3 => null;

		public int Rate => 0;

		public string ServerRate => null;

		public string New1 => null;

		public string New2 => null;

		public string New3 => null;

		public string GuaranteeEquipId1 => null;

		public string GuaranteeEquipId2 => null;

		public string GuaranteeEquipId3 => null;

		public int GuaranteeTimes1 => 0;

		public int GuaranteeTimes2 => 0;

		public int GuaranteeTimes3 => 0;

		public int ClearGuaranteeTimes => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Drop_DropActivity Copy()
		{
			return null;
		}
	}
}
