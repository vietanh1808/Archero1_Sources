using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Box_ChapterBox : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _Chapter;

		private ObscuredString[] _Reward;

		public int ID => 0;

		public int Chapter => 0;

		public string[] Reward => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Box_ChapterBox Copy()
		{
			return null;
		}
	}
}
