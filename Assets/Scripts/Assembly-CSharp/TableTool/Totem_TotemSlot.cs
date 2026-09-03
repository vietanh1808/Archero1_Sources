using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Totem_TotemSlot : LocalBean
	{
		private ObscuredInt _Id;

		private ObscuredString _Name;

		private ObscuredInt _Type;

		private ObscuredInt _SubType;

		private ObscuredInt _UnlockChapter;

		private ObscuredInt _Angle;

		private ObscuredString _Icon;

		public int Id => 0;

		public string Name => null;

		public int Type => 0;

		public int SubType => 0;

		public int UnlockChapter => 0;

		public int Angle => 0;

		public string Icon => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Totem_TotemSlot Copy()
		{
			return null;
		}
	}
}
