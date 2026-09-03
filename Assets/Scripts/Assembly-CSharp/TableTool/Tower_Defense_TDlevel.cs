using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Tower_Defense_TDlevel : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _Type;

		private ObscuredInt _Wave;

		private ObscuredInt _TDStone;

		private ObscuredInt _BaseCampHP;

		private ObscuredInt _OpenDay;

		private ObscuredInt _AdReborn;

		private ObscuredString[] _StyleSequence;

		private ObscuredInt[] _UnlockTD;

		private ObscuredInt _TDMax;

		private ObscuredString _Rooms;

		private ObscuredString[] _ActivityItem;

		private ObscuredString[] _ActivityItemBOSS;

		private ObscuredFloat _IntegralRate;

		private ObscuredInt _ExpBase;

		private ObscuredInt _ExpAdd;

		private ObscuredInt _ActivityItemMAX;

		private ObscuredInt _GoldMAX;

		private ObscuredInt _ExpMAX;

		private ObscuredInt _CleanDropID;

		private ObscuredString[] _RewardDisplay;

		private ObscuredString[] _RewardSweepDisplay;

		private ObscuredFloat[] _AttackPar;

		private ObscuredFloat[] _HPPar;

		private ObscuredFloat[] _BodyHitPar;

		private ObscuredFloat[] _IntegralRatePar;

		private ObscuredFloat[] _ExpPar;

		private ObscuredFloat[] _BaseCampHPPar;

		public int ID => 0;

		public int Type => 0;

		public int Wave => 0;

		public int TDStone => 0;

		public int BaseCampHP => 0;

		public int OpenDay => 0;

		public int AdReborn => 0;

		public string[] StyleSequence => null;

		public int[] UnlockTD => null;

		public int TDMax => 0;

		public string Rooms => null;

		public string[] ActivityItem => null;

		public string[] ActivityItemBOSS => null;

		public float IntegralRate => 0f;

		public int ExpBase => 0;

		public int ExpAdd => 0;

		public int ActivityItemMAX => 0;

		public int GoldMAX => 0;

		public int ExpMAX => 0;

		public int CleanDropID => 0;

		public string[] RewardDisplay => null;

		public string[] RewardSweepDisplay => null;

		public float[] AttackPar => null;

		public float[] HPPar => null;

		public float[] BodyHitPar => null;

		public float[] IntegralRatePar => null;

		public float[] ExpPar => null;

		public float[] BaseCampHPPar => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Tower_Defense_TDlevel Copy()
		{
			return null;
		}
	}
}
