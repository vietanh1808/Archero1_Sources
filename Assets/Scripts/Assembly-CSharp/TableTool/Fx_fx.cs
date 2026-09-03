using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Fx_fx : LocalBean
	{
		private ObscuredInt _FxID;

		private ObscuredString _Path;

		private ObscuredString[] _Paths;

		private ObscuredInt _Node;

		public int FxID => 0;

		public string Path => null;

		public string[] Paths => null;

		public int Node => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Fx_fx Copy()
		{
			return null;
		}
	}
}
