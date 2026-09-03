using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class ShipBattle_EventsAction : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _Type;

		private ObscuredString[] _Language;

		private ObscuredString[] _StringValue;

		private ObscuredInt[] _NextAction;

		private ObscuredInt _Server;

		public int ID => 0;

		public int Type => 0;

		public string[] Language => null;

		public string[] StringValue => null;

		public int[] NextAction => null;

		public int Server => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public ShipBattle_EventsAction Copy()
		{
			return null;
		}
	}
}
