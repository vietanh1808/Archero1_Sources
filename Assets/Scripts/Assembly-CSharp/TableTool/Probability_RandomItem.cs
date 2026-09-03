using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Probability_RandomItem : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _ItemType;

		private ObscuredString[] _Weight;

		public int ID => 0;

		public int ItemType => 0;

		public string[] Weight => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Probability_RandomItem Copy()
		{
			return null;
		}
	}
}
