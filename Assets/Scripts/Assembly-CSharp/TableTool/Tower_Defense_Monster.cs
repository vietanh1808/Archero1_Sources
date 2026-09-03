using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Tower_Defense_Monster : LocalBean
	{
		private ObscuredInt _MonsterID;

		private ObscuredFloat _HeroHittedRadius;

		private ObscuredFloat _HeroSpeedTimes;

		private ObscuredFloat _BaseSpeedTimes;

		private ObscuredFloat _BaseCheckRadius;

		private ObscuredFloat _HeroCheckRadius;

		private ObscuredInt _Attack;

		private ObscuredInt _HP;

		private ObscuredInt _Collision;

		private ObscuredInt[] _InternalStone;

		private ObscuredInt _InternalExp;

		public int MonsterID => 0;

		public float HeroHittedRadius => 0f;

		public float HeroSpeedTimes => 0f;

		public float BaseSpeedTimes => 0f;

		public float BaseCheckRadius => 0f;

		public float HeroCheckRadius => 0f;

		public int Attack => 0;

		public int HP => 0;

		public int Collision => 0;

		public int[] InternalStone => null;

		public int InternalExp => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Tower_Defense_Monster Copy()
		{
			return null;
		}
	}
}
