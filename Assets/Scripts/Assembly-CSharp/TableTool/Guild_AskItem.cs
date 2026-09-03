using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Guild_AskItem : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredString _ItemId;

		private ObscuredInt _Type;

		private ObscuredInt _Limit;

		private ObscuredInt _NumAsk;

		private ObscuredInt _Score;

		private ObscuredInt _Show;

		public int ID => 0;

		public string ItemId => null;

		public int Type => 0;

		public int Limit => 0;

		public int NumAsk => 0;

		public int Score => 0;

		public int Show => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Guild_AskItem Copy()
		{
			return null;
		}
	}
}
