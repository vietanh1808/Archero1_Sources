using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Purchase_Shop : LocalBean
	{
		private ObscuredString _ID;

		private ObscuredString _Reward;

		public string ID => null;

		public string Reward => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Purchase_Shop Copy()
		{
			return null;
		}
	}
}
