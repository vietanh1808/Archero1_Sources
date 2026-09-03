using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class MonthlyCard_Power : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _Type;

		private ObscuredInt _Value;

		private ObscuredInt _ValueType;

		private ObscuredInt _Ver;

		public int ID => 0;

		public int Type => 0;

		public int Value => 0;

		public int ValueType => 0;

		public int Ver => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public MonthlyCard_Power Copy()
		{
			return null;
		}
	}
}
