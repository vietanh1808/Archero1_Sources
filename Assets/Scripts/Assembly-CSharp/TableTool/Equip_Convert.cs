using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Equip_Convert : LocalBean
	{
		private ObscuredInt _Id;

		private ObscuredString _Name;

		private ObscuredInt _ActivityRatio;

		public int Id => 0;

		public string Name => null;

		public int ActivityRatio => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Equip_Convert Copy()
		{
			return null;
		}
	}
}
