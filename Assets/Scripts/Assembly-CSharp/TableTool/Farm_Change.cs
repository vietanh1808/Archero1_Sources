using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Farm_Change : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredString _NeedItem;

		private ObscuredString _GetItem;

		private ObscuredString _CostItem;

		private ObscuredInt _MinLayer;

		private ObscuredInt _MaxLayer;

		private ObscuredInt _Weights;

		private ObscuredString _NeedItemLimit;

		public int ID => 0;

		public string NeedItem => null;

		public string GetItem => null;

		public string CostItem => null;

		public int MinLayer => 0;

		public int MaxLayer => 0;

		public int Weights => 0;

		public string NeedItemLimit => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Farm_Change Copy()
		{
			return null;
		}
	}
}
