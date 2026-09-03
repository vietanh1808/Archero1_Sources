using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Equip_Monster : LocalBean
	{
		private ObscuredInt _Id;

		private ObscuredString _Name;

		private ObscuredInt _Type;

		private ObscuredInt _EggId;

		private ObscuredString _ModelID;

		private ObscuredFloat _BodyScale;

		private ObscuredInt _Land;

		private ObscuredString _TextureID;

		private ObscuredInt _Icon;

		private ObscuredInt _Speed;

		private ObscuredInt[] _Quality_config;

		private ObscuredInt[] _Quality_Level_Limit;

		private ObscuredInt[] _Quality_Farm_Limit;

		private ObscuredInt[] _Quality_StarNum;

		private ObscuredInt[] _Star_MonsterNum;

		private ObscuredInt[] _Star_CoinsNum;

		private ObscuredString _Star_Attributes1;

		private ObscuredInt[] _Star_Attributes1Up;

		private ObscuredString _Star_Attributes2;

		private ObscuredInt[] _Star_Attributes2Up;

		private ObscuredString _Star_Attributes3;

		private ObscuredInt[] _Star_Attributes3Up;

		private ObscuredString _Star_Attributes4;

		private ObscuredInt[] _Star_Attributes4Up;

		private ObscuredString _Star_Attributes5;

		private ObscuredInt[] _Star_Attributes5Up;

		private ObscuredInt[] _Quality_Skill;

		private ObscuredInt[] _Quality_Battle_Skill;

		private ObscuredInt[] _StoryCond;

		private ObscuredString[] _Attributes;

		private ObscuredString[] _StarUnlock_Attributes;

		private ObscuredString _BattleMaxKill;

		private ObscuredString _HeroBattleMaxKill;

		private ObscuredString _HellBattleMaxKill;

		private ObscuredString[] _DailyMaxKill;

		private ObscuredString[] _InfiniteMaxKill;

		private ObscuredString[] _NormaGo;

		private ObscuredString[] _HeroGo;

		private ObscuredString[] _HellGo;

		private ObscuredString[] _EventsGo;

		private ObscuredInt _UnlockChapter;

		private ObscuredInt _RandomWeight;

		private ObscuredInt _Quality;

		private ObscuredFloat _MoveSpeed;

		private ObscuredInt _TurnRate;

		public int Id => 0;

		public string Name => null;

		public int Type => 0;

		public int EggId => 0;

		public string ModelID => null;

		public float BodyScale => 0f;

		public int Land => 0;

		public string TextureID => null;

		public int Icon => 0;

		public int Speed => 0;

		public int[] Quality_config => null;

		public int[] Quality_Level_Limit => null;

		public int[] Quality_Farm_Limit => null;

		public int[] Quality_StarNum => null;

		public int[] Star_MonsterNum => null;

		public int[] Star_CoinsNum => null;

		public string Star_Attributes1 => null;

		public int[] Star_Attributes1Up => null;

		public string Star_Attributes2 => null;

		public int[] Star_Attributes2Up => null;

		public string Star_Attributes3 => null;

		public int[] Star_Attributes3Up => null;

		public string Star_Attributes4 => null;

		public int[] Star_Attributes4Up => null;

		public string Star_Attributes5 => null;

		public int[] Star_Attributes5Up => null;

		public int[] Quality_Skill => null;

		public int[] Quality_Battle_Skill => null;

		public int[] StoryCond => null;

		public string[] Attributes => null;

		public string[] StarUnlock_Attributes => null;

		public string BattleMaxKill => null;

		public string HeroBattleMaxKill => null;

		public string HellBattleMaxKill => null;

		public string[] DailyMaxKill => null;

		public string[] InfiniteMaxKill => null;

		public string[] NormaGo => null;

		public string[] HeroGo => null;

		public string[] HellGo => null;

		public string[] EventsGo => null;

		public int UnlockChapter => 0;

		public int RandomWeight => 0;

		public int Quality => 0;

		public float MoveSpeed => 0f;

		public int TurnRate => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Equip_Monster Copy()
		{
			return null;
		}
	}
}
