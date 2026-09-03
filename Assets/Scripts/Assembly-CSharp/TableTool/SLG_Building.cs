using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class SLG_Building : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _BuildingType;

		private ObscuredInt _Img;

		private ObscuredInt _Level;

		private ObscuredInt _LevelBG;

		private ObscuredInt _OccupyNeedValue;

		private ObscuredInt _OccupyType;

		private ObscuredInt[] _BattleType;

		private ObscuredInt _OpenTime;

		private ObscuredInt _CloseTime;

		private ObscuredInt _BattleWinOccupyAdd;

		private ObscuredInt _BattleLoseOccupyBase;

		private ObscuredInt _BattleLoseOccupyAdd;

		private ObscuredInt _CoinIntegralRate;

		private ObscuredFloat[] _CoinChapterRatio;

		private ObscuredInt _ExpBase;

		private ObscuredInt _ExpAdd;

		private ObscuredInt _SweepExpAdd;

		private ObscuredFloat[] _ExpChapterRatio;

		private ObscuredInt _BattleWinHonorAdd;

		private ObscuredInt _BattleLoseHonorBase;

		private ObscuredInt _BattleLoseHonorAdd;

		private ObscuredInt _BattleWinDropId;

		private ObscuredInt _SweepDropId;

		private ObscuredString[] _BattleRewardDisplay;

		private ObscuredString[] _OccupyReward;

		private ObscuredInt _HarvestReward1;

		private ObscuredInt _HarvestReward2;

		private ObscuredInt _HarvestReward3;

		private ObscuredInt _HarvestReward4;

		private ObscuredInt _HarvestReward5;

		private ObscuredInt[] _BuffId;

		private ObscuredInt _HolyNumber;

		private ObscuredInt[] _PersonalBuffId;

		private ObscuredInt _BuildVision;

		public int ID => 0;

		public int BuildingType => 0;

		public int Img => 0;

		public int Level => 0;

		public int LevelBG => 0;

		public int OccupyNeedValue => 0;

		public int OccupyType => 0;

		public int[] BattleType => null;

		public int OpenTime => 0;

		public int CloseTime => 0;

		public int BattleWinOccupyAdd => 0;

		public int BattleLoseOccupyBase => 0;

		public int BattleLoseOccupyAdd => 0;

		public int CoinIntegralRate => 0;

		public float[] CoinChapterRatio => null;

		public int ExpBase => 0;

		public int ExpAdd => 0;

		public int SweepExpAdd => 0;

		public float[] ExpChapterRatio => null;

		public int BattleWinHonorAdd => 0;

		public int BattleLoseHonorBase => 0;

		public int BattleLoseHonorAdd => 0;

		public int BattleWinDropId => 0;

		public int SweepDropId => 0;

		public string[] BattleRewardDisplay => null;

		public string[] OccupyReward => null;

		public int HarvestReward1 => 0;

		public int HarvestReward2 => 0;

		public int HarvestReward3 => 0;

		public int HarvestReward4 => 0;

		public int HarvestReward5 => 0;

		public int[] BuffId => null;

		public int HolyNumber => 0;

		public int[] PersonalBuffId => null;

		public int BuildVision => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public SLG_Building Copy()
		{
			return null;
		}
	}
}
