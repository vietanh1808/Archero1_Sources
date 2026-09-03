using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Sound_sound : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredString _Notes;

		private ObscuredString _Path;

		private ObscuredFloat _Volumn;

		public int ID => 0;

		public string Notes => null;

		public string Path => null;

		public float Volumn => 0f;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Sound_sound Copy()
		{
			return null;
		}
	}
}
