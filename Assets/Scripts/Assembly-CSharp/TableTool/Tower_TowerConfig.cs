using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Tower_TowerConfig : LocalBean
	{
		private ObscuredInt _Id;

		private ObscuredInt _GameType;

		private ObscuredInt[] _GameArgs;

		private ObscuredInt _Pic;

		private ObscuredString _StyleSequence;

		private ObscuredInt _OpenCondition;

		private ObscuredInt _SkillPool;

		private ObscuredInt[] _Event;

		private ObscuredInt _SkillNum;

		private ObscuredInt[] _Monster;

		private ObscuredString[] _Reward;

		private ObscuredFloat _TimeReward;

		private ObscuredString[] _Attributes;

		private ObscuredString[] _MapAttributes;

		private ObscuredString[] _RoomIDs;

		private ObscuredLong _StandardDefence;

		private ObscuredFloat _IfRevival;

		private ObscuredString[] _HeroReward;

		private ObscuredFloat _RuneReward;

		private ObscuredString[] _HeroAttributesUp;

		private ObscuredFloat _HeroRate;

		public int Id => 0;

		public int GameType => 0;

		public int[] GameArgs => null;

		public int Pic => 0;

		public string StyleSequence => null;

		public int OpenCondition => 0;

		public int SkillPool => 0;

		public int[] Event => null;

		public int SkillNum => 0;

		public int[] Monster => null;

		public string[] Reward => null;

		public float TimeReward => 0f;

		public string[] Attributes => null;

		public string[] MapAttributes => null;

		public string[] RoomIDs => null;

		public long StandardDefence => 0L;

		public float IfRevival => 0f;

		public string[] HeroReward => null;

		public float RuneReward => 0f;

		public string[] HeroAttributesUp => null;

		public float HeroRate => 0f;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Tower_TowerConfig Copy()
		{
			return null;
		}
	}
}
