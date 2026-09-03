using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Equip_Casting : LocalBean
	{
		private ObscuredInt _Id;

		private ObscuredString[] _CastingNeed;

		public int Id => 0;

		public string[] CastingNeed => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Equip_Casting Copy()
		{
			return null;
		}
	}
}
