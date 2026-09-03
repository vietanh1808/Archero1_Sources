using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class SLG_HeroDispatch : LocalBean
	{
		private ObscuredInt _Id;

		private ObscuredString[] _ResAddWood;

		private ObscuredString[] _ResAddIron;

		private ObscuredString[] _ResAddFood;

		private ObscuredString[] _ResAddCrystal;

		private ObscuredString[] _ResAddHoly;

		public int Id => 0;

		public string[] ResAddWood => null;

		public string[] ResAddIron => null;

		public string[] ResAddFood => null;

		public string[] ResAddCrystal => null;

		public string[] ResAddHoly => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public SLG_HeroDispatch Copy()
		{
			return null;
		}
	}
}
