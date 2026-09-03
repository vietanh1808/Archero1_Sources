using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Skill_slotout : LocalBean
	{
		private ObscuredInt _GroupID;

		private ObscuredInt _Type;

		private ObscuredInt _Quality;

		private ObscuredInt _Priority;

		private ObscuredString[] _BaseAttributes;

		private ObscuredFloat[] _AddAttributes;

		private ObscuredInt _LevelLimit;

		private ObscuredString _InitialPower;

		private ObscuredString _AddPower;

		public int GroupID => 0;

		public int Type => 0;

		public int Quality => 0;

		public int Priority => 0;

		public string[] BaseAttributes => null;

		public float[] AddAttributes => null;

		public int LevelLimit => 0;

		public string InitialPower => null;

		public string AddPower => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Skill_slotout Copy()
		{
			return null;
		}
	}
}
