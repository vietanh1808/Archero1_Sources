using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Equip_Upgrade : LocalBean
	{
		private ObscuredInt _LevelId;

		private ObscuredInt _UpMaterials;

		private ObscuredInt _UpCoins;

		private ObscuredInt _UpMaterialsSum;

		private ObscuredInt _UpCoinsSum;

		private ObscuredInt _ResetGems;

		public int LevelId => 0;

		public int UpMaterials => 0;

		public int UpCoins => 0;

		public int UpMaterialsSum => 0;

		public int UpCoinsSum => 0;

		public int ResetGems => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Equip_Upgrade Copy()
		{
			return null;
		}
	}
}
