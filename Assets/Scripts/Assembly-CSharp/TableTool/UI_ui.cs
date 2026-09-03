using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class UI_ui : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredString _WindowID;

		private ObscuredString _Note;

		private ObscuredString _ClassName;

		private ObscuredInt _State;

		private ObscuredInt _IsPop;

		private ObscuredInt _IsPopMain;

		private ObscuredInt _Order;

		private ObscuredString[] _Atlas;

		private ObscuredInt _AniNot;

		public int ID => 0;

		public string WindowID => null;

		public string Note => null;

		public string ClassName => null;

		public int State => 0;

		public int IsPop => 0;

		public int IsPopMain => 0;

		public int Order => 0;

		public string[] Atlas => null;

		public int AniNot => 0;

		public bool IsLockOrder => false;

		protected override bool ReadImpl()
		{
			return false;
		}

		public UI_ui Copy()
		{
			return null;
		}
	}
}
