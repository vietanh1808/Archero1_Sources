using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Soldier_soldier : LocalBean
	{
		private ObscuredInt _CharID;

		private ObscuredString _Notes;

		private ObscuredInt _GoldDropLevel;

		private ObscuredInt _ScrollDropLevel;

		private ObscuredString[] _Drops;

		private ObscuredInt _GoldDropGold1;

		private ObscuredInt _GoldDropGold2;

		private ObscuredFloat _EquipRate;

		private ObscuredInt _Exp;

		private ObscuredInt _SlgCrystal;

		private ObscuredInt _Energy;

		private ObscuredInt _Anger;

		private ObscuredInt _PetEnergy;

		private ObscuredInt _CooperationScore;

		private ObscuredInt _EndlessExp;

		private ObscuredInt _DropRadius;

		private ObscuredInt _HPDrop1;

		private ObscuredInt _HPDrop2;

		private ObscuredInt _HPDrop3;

		private ObscuredInt _MPDrop1;

		private ObscuredInt _MPDrop2;

		private ObscuredInt _MPDrop3;

		private ObscuredInt _BodyHitSoundID;

		private ObscuredInt _Type;

		private ObscuredInt _PVEExp;

		private ObscuredInt _PVESoul;

		private ObscuredInt _Hard_PVESoul;

		public int CharID => 0;

		public string Notes => null;

		public int GoldDropLevel => 0;

		public int ScrollDropLevel => 0;

		public string[] Drops => null;

		public int GoldDropGold1 => 0;

		public int GoldDropGold2 => 0;

		public float EquipRate => 0f;

		public int Exp => 0;

		public int SlgCrystal => 0;

		public int Energy => 0;

		public int Anger => 0;

		public int PetEnergy => 0;

		public int CooperationScore => 0;

		public int EndlessExp => 0;

		public int DropRadius => 0;

		public int HPDrop1 => 0;

		public int HPDrop2 => 0;

		public int HPDrop3 => 0;

		public int MPDrop1 => 0;

		public int MPDrop2 => 0;

		public int MPDrop3 => 0;

		public int BodyHitSoundID => 0;

		public int Type => 0;

		public int PVEExp => 0;

		public int PVESoul => 0;

		public int Hard_PVESoul => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Soldier_soldier Copy()
		{
			return null;
		}
	}
}
