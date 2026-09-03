using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Manor_Upgrade : LocalBean
	{
		private ObscuredInt _Id;

		private ObscuredInt _BuildID;

		private ObscuredInt _Level;

		private ObscuredString[] _Material;

		private ObscuredString[] _Drawing;

		private ObscuredInt _FountainLV;

		private ObscuredInt _StarLV;

		private ObscuredFloat _Capacity;

		private ObscuredInt[] _Buildability;

		private ObscuredString[] _Ability;

		private ObscuredInt[] _DropID;

		private ObscuredInt _Exp;

		private ObscuredString[] _Preview;

		private ObscuredInt[] _Orders;

		private ObscuredString[] _AbilityPreview;

		public int Id => 0;

		public int BuildID => 0;

		public int Level => 0;

		public string[] Material => null;

		public string[] Drawing => null;

		public int FountainLV => 0;

		public int StarLV => 0;

		public float Capacity => 0f;

		public int[] Buildability => null;

		public string[] Ability => null;

		public int[] DropID => null;

		public int Exp => 0;

		public string[] Preview => null;

		public int[] Orders => null;

		public string[] AbilityPreview => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Manor_Upgrade Copy()
		{
			return null;
		}
	}
}
