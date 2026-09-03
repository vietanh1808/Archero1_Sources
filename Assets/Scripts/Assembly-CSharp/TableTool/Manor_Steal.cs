using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Manor_Steal : LocalBean
	{
		private ObscuredInt _Id;

		private ObscuredInt _Ratio;

		public int Id => 0;

		public int Ratio => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Manor_Steal Copy()
		{
			return null;
		}
	}
}
