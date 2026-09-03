using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Equip_Replace : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _Position;

		private ObscuredInt _Quality;

		private ObscuredString _Weights;

		private ObscuredInt _Gems;

		public int ID => 0;

		public int Position => 0;

		public int Quality => 0;

		public string Weights => null;

		public int Gems => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Equip_Replace Copy()
		{
			return null;
		}
	}
}
