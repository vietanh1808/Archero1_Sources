using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Box_ChoiceBox : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredString _Name;

		private ObscuredInt _Icon;

		private ObscuredString[] _ChoiceFragment;

		private ObscuredInt _Limit;

		public int ID => 0;

		public string Name => null;

		public int Icon => 0;

		public string[] ChoiceFragment => null;

		public int Limit => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Box_ChoiceBox Copy()
		{
			return null;
		}
	}
}
