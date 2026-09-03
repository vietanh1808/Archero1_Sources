using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Shop_Wish : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _LockLevel;

		private ObscuredInt _Order;

		private ObscuredInt _BoxRate;

		private ObscuredInt _DropRate;

		private ObscuredInt _DisplayRate;

		private ObscuredInt _IfNew;

		private ObscuredInt _IsReduce;

		private ObscuredInt _BoxReduceRate;

		private ObscuredInt _DropReduceRate;

		private ObscuredInt _ReduceDisplayRate;

		public int ID => 0;

		public int LockLevel => 0;

		public int Order => 0;

		public int BoxRate => 0;

		public int DropRate => 0;

		public int DisplayRate => 0;

		public int IfNew => 0;

		public int IsReduce => 0;

		public int BoxReduceRate => 0;

		public int DropReduceRate => 0;

		public int ReduceDisplayRate => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Shop_Wish Copy()
		{
			return null;
		}
	}
}
