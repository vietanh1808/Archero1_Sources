using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Box_BagChoiceBox : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredString _Name;

		private ObscuredString[] _ChoiceFragment;

		private ObscuredInt _Order;

		public int ID => 0;

		public string Name => null;

		public string[] ChoiceFragment => null;

		public int Order => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Box_BagChoiceBox Copy()
		{
			return null;
		}
	}
}
