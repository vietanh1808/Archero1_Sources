using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Beat_beat : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _Score;

		private ObscuredFloat _Rate;

		public int ID => 0;

		public int Score => 0;

		public float Rate => 0f;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Beat_beat Copy()
		{
			return null;
		}
	}
}
