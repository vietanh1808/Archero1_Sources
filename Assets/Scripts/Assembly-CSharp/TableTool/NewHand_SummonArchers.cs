using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class NewHand_SummonArchers : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _GroupID;

		private ObscuredInt _Order;

		private ObscuredInt[] _GuideTypes;

		private ObscuredInt _Name;

		private ObscuredString _Pic;

		private ObscuredInt _Position;

		private ObscuredString _Content;

		private ObscuredString _PanelName;

		private ObscuredString _BtnPath;

		private ObscuredInt _AorrwPos;

		private ObscuredInt _IsForce;

		private ObscuredInt _ConditionType;

		private ObscuredInt[] _ConditionValue;

		public int ID => 0;

		public int GroupID => 0;

		public int Order => 0;

		public int[] GuideTypes => null;

		public int Name => 0;

		public string Pic => null;

		public int Position => 0;

		public string Content => null;

		public string PanelName => null;

		public string BtnPath => null;

		public int AorrwPos => 0;

		public int IsForce => 0;

		public int ConditionType => 0;

		public int[] ConditionValue => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public NewHand_SummonArchers Copy()
		{
			return null;
		}
	}
}
