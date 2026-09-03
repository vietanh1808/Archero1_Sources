using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class PlayerCharacter_SkinUp : LocalBean
	{
		private ObscuredInt _LevelId;

		private ObscuredInt _UpCoins;

		private ObscuredInt _UpMaterials1;

		private ObscuredInt _UpMaterials2;

		private ObscuredInt _UpMaterials3;

		private ObscuredInt _UpMaterials4;

		private ObscuredInt _ResetGems;

		private ObscuredInt _ResetMaterialsNum;

		public int LevelId => 0;

		public int UpCoins => 0;

		public int UpMaterials1 => 0;

		public int UpMaterials2 => 0;

		public int UpMaterials3 => 0;

		public int UpMaterials4 => 0;

		public int ResetGems => 0;

		public int ResetMaterialsNum => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public PlayerCharacter_SkinUp Copy()
		{
			return null;
		}
	}
}
