using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Pet_Pet : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _Rare;

		private ObscuredInt _FragmentId;

		private ObscuredInt _FragmentNum;

		private ObscuredInt _Type;

		private ObscuredInt _LeaveType;

		private ObscuredInt _MoveType;

		private ObscuredInt _CharacterID;

		private ObscuredInt[] _PetModelModify;

		private ObscuredString[] _Attributes;

		private ObscuredInt[] _LevelAttributes;

		private ObscuredInt _BattleSkill;

		private ObscuredInt _TalentSkill1;

		private ObscuredInt _TalentSkill2;

		private ObscuredInt _InheritSkill1;

		private ObscuredInt _InheritSkillNum;

		private ObscuredInt[] _SkillUnlockStar;

		private ObscuredInt[] _StarUnlock;

		private ObscuredString[] _StarUnlock_Attributes;

		private ObscuredString[] _StarUnlock_Language;

		private ObscuredInt[] _LevelUnlock;

		private ObscuredString[] _LevelUnlock_Attributes;

		private ObscuredString[] _LevelUnlock_Language;

		private ObscuredInt _UpgradeItem;

		private ObscuredInt _DivideVersion;

		private ObscuredInt _DivideVersionLevel;

		private ObscuredString[] _Attributes_Ship;

		private ObscuredInt[] _ShipPower;

		public int ID => 0;

		public int Rare => 0;

		public int FragmentId => 0;

		public int FragmentNum => 0;

		public int Type => 0;

		public int LeaveType => 0;

		public int MoveType => 0;

		public int CharacterID => 0;

		public int[] PetModelModify => null;

		public string[] Attributes => null;

		public int[] LevelAttributes => null;

		public int BattleSkill => 0;

		public int TalentSkill1 => 0;

		public int TalentSkill2 => 0;

		public int InheritSkill1 => 0;

		public int InheritSkillNum => 0;

		public int[] SkillUnlockStar => null;

		public int[] StarUnlock => null;

		public string[] StarUnlock_Attributes => null;

		public string[] StarUnlock_Language => null;

		public int[] LevelUnlock => null;

		public string[] LevelUnlock_Attributes => null;

		public string[] LevelUnlock_Language => null;

		public int UpgradeItem => 0;

		public int DivideVersion => 0;

		public int DivideVersionLevel => 0;

		public string[] Attributes_Ship => null;

		public int[] ShipPower => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Pet_Pet Copy()
		{
			return null;
		}
	}
}
