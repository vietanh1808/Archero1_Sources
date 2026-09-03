using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Badge_CardHolder : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _Deck;

		private ObscuredInt _CardHolderNum;

		private ObscuredInt _BaseWeight;

		private ObscuredInt _UPWeight1;

		private ObscuredInt _UPWeight2;

		private ObscuredInt _UPWeight3;

		private ObscuredInt _UPWeight4;

		private ObscuredInt _GetNum;

		public int ID => 0;

		public int Deck => 0;

		public int CardHolderNum => 0;

		public int BaseWeight => 0;

		public int UPWeight1 => 0;

		public int UPWeight2 => 0;

		public int UPWeight3 => 0;

		public int UPWeight4 => 0;

		public int GetNum => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Badge_CardHolder Copy()
		{
			return null;
		}
	}
}
