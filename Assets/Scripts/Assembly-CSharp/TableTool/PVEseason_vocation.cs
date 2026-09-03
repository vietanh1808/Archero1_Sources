using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class PVEseason_vocation : LocalBean
	{
		private ObscuredInt _VocationID;

		private ObscuredString _Name;

		private ObscuredString[] _Characteristic;

		private ObscuredString _Icon;

		public int VocationID => 0;

		public string Name => null;

		public string[] Characteristic => null;

		public string Icon => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public PVEseason_vocation Copy()
		{
			return null;
		}
	}
}
