using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Tower_Defense_Wave111 : LocalBean
	{
		private ObscuredInt _WaveID;

		private ObscuredInt _Time;

		private ObscuredInt[] _Path;

		private ObscuredString[] _GroupID;

		private ObscuredString[] _Attributes;

		private ObscuredString[] _MapAttributes;

		public int WaveID => 0;

		public int Time => 0;

		public int[] Path => null;

		public string[] GroupID => null;

		public string[] Attributes => null;

		public string[] MapAttributes => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Tower_Defense_Wave111 Copy()
		{
			return null;
		}
	}
}
