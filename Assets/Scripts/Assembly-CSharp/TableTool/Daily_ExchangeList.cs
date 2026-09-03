using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Daily_ExchangeList : LocalBean
	{
		private ObscuredInt _Id;

		private ObscuredInt _Tag;

		private ObscuredInt _Count;

		private ObscuredString[] _Need;

		private ObscuredString[] _Target;

		public int Id => 0;

		public int Tag => 0;

		public int Count => 0;

		public string[] Need => null;

		public string[] Target => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Daily_ExchangeList Copy()
		{
			return null;
		}
	}
}
