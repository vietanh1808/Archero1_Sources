using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Drop_FakeDrop : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _DropID;

		private ObscuredInt _RandNum;

		private ObscuredInt _JumpDrop;

		public int ID => 0;

		public int DropID => 0;

		public int RandNum => 0;

		public int JumpDrop => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Drop_FakeDrop Copy()
		{
			return null;
		}
	}
}
