using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Box_challengeBox : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredString[] _Reward;

		public int ID => 0;

		public string[] Reward => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Box_challengeBox Copy()
		{
			return null;
		}
	}
}
