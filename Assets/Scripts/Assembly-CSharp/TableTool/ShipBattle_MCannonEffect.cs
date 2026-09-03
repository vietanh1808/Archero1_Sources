using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class ShipBattle_MCannonEffect : LocalBean
	{
		private ObscuredInt _Id;

		private ObscuredString[] _Effect1;

		private ObscuredString[] _Effect2;

		private ObscuredString _Effect3;

		private ObscuredString _Effect4;

		private ObscuredString _Effect5;

		public int Id => 0;

		public string[] Effect1 => null;

		public string[] Effect2 => null;

		public string Effect3 => null;

		public string Effect4 => null;

		public string Effect5 => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public ShipBattle_MCannonEffect Copy()
		{
			return null;
		}
	}
}
