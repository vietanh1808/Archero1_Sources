using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Preload_load : LocalBean
	{
		private ObscuredInt _RoomID;

		private ObscuredString _Notes;

		private ObscuredString[] _PlayerBulletsPath;

		private ObscuredString[] _BulletsPath;

		private ObscuredInt[] _EffectsPath;

		private ObscuredString[] _MapEffectsPath;

		private ObscuredString[] _GoodsPath;

		private ObscuredInt[] _SoundPath;

		public int RoomID => 0;

		public string Notes => null;

		public string[] PlayerBulletsPath => null;

		public string[] BulletsPath => null;

		public int[] EffectsPath => null;

		public string[] MapEffectsPath => null;

		public string[] GoodsPath => null;

		public int[] SoundPath => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Preload_load Copy()
		{
			return null;
		}
	}
}
