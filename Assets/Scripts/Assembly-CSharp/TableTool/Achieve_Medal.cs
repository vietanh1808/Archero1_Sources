using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Achieve_Medal : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _IsEnable;

		private ObscuredString _Icon;

		private ObscuredInt _Quality;

		private ObscuredInt _SystemID;

		private ObscuredInt _Type;

		private ObscuredInt[] _Parameter;

		private ObscuredString[] _Attributes;

		private ObscuredInt[] _Display;

		private ObscuredInt _Sort;

		private ObscuredString _Effect;

		public int ID => 0;

		public int IsEnable => 0;

		public string Icon => null;

		public int Quality => 0;

		public int SystemID => 0;

		public int Type => 0;

		public int[] Parameter => null;

		public string[] Attributes => null;

		public int[] Display => null;

		public int Sort => 0;

		public string Effect => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Achieve_Medal Copy()
		{
			return null;
		}
	}
}
