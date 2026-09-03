using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Manor_RecordText : LocalBean
	{
		private ObscuredInt _Id;

		public int Id => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Manor_RecordText Copy()
		{
			return null;
		}
	}
}
