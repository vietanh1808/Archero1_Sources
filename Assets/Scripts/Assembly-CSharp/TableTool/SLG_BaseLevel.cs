using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class SLG_BaseLevel : LocalBean
	{
		private ObscuredInt _LevelId;

		private ObscuredInt _UpNeedWood;

		private ObscuredInt _UpNeedIron;

		private ObscuredInt _UpNeedGrain;

		private ObscuredInt _UpNeedCrystal;

		private ObscuredInt _TalentDrop;

		private ObscuredInt _WoodMax;

		private ObscuredInt _IronMax;

		private ObscuredInt _GrainMax;

		private ObscuredInt _CrystalMax;

		private ObscuredInt _GoldMax;

		private ObscuredInt _ArrowDrop;

		private ObscuredInt _Convert;

		private ObscuredInt _HeroMax;

		private ObscuredString[] _Attribute;

		private ObscuredInt[] _AddAttribute;

		public int LevelId => 0;

		public int UpNeedWood => 0;

		public int UpNeedIron => 0;

		public int UpNeedGrain => 0;

		public int UpNeedCrystal => 0;

		public int TalentDrop => 0;

		public int WoodMax => 0;

		public int IronMax => 0;

		public int GrainMax => 0;

		public int CrystalMax => 0;

		public int GoldMax => 0;

		public int ArrowDrop => 0;

		public int Convert => 0;

		public int HeroMax => 0;

		public string[] Attribute => null;

		public int[] AddAttribute => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public SLG_BaseLevel Copy()
		{
			return null;
		}
	}
}
