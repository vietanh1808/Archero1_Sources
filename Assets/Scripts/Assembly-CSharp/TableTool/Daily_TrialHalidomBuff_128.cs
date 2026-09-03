using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Daily_TrialHalidomBuff_128 : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _CharacterID;

		private ObscuredInt[] _NpcBuff;

		private ObscuredInt[] _NpcDebuff;

		private ObscuredInt _FxID;

		private ObscuredFloat _NpcBuffRadius;

		public int ID => 0;

		public int CharacterID => 0;

		public int[] NpcBuff => null;

		public int[] NpcDebuff => null;

		public int FxID => 0;

		public float NpcBuffRadius => 0f;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Daily_TrialHalidomBuff_128 Copy()
		{
			return null;
		}
	}
}
