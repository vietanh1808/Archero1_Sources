using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Pet_UpStar : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _StarNum;

		private ObscuredInt _Quality;

		private ObscuredInt _Cost_B;

		private ObscuredInt _Cost_A;

		private ObscuredInt _Cost_S;

		private ObscuredInt _Cost_SS;

		private ObscuredString[] _Cost_Extra_B;

		private ObscuredString[] _Cost_Extra_A;

		private ObscuredString[] _Cost_Extra_S;

		private ObscuredString[] _Cost_Extra_SS;

		private ObscuredFloat _Attr_B;

		private ObscuredFloat _Attr_A;

		private ObscuredFloat _Attr_S;

		private ObscuredFloat _Attr_SS;

		public int ID => 0;

		public int StarNum => 0;

		public int Quality => 0;

		public int Cost_B => 0;

		public int Cost_A => 0;

		public int Cost_S => 0;

		public int Cost_SS => 0;

		public string[] Cost_Extra_B => null;

		public string[] Cost_Extra_A => null;

		public string[] Cost_Extra_S => null;

		public string[] Cost_Extra_SS => null;

		public float Attr_B => 0f;

		public float Attr_A => 0f;

		public float Attr_S => 0f;

		public float Attr_SS => 0f;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Pet_UpStar Copy()
		{
			return null;
		}
	}
}
