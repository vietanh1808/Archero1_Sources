using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Achieve_EmployTask : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredString _Language;

		private ObscuredInt _Item1;

		private ObscuredInt _Item2;

		private ObscuredInt _Time;

		private ObscuredString _Icon;

		private ObscuredInt _Weight;

		private ObscuredInt _NeedLayer;

		private ObscuredInt _Reward;

		private ObscuredString[] _RewardPreview;

		public int ID => 0;

		public string Language => null;

		public int Item1 => 0;

		public int Item2 => 0;

		public int Time => 0;

		public string Icon => null;

		public int Weight => 0;

		public int NeedLayer => 0;

		public int Reward => 0;

		public string[] RewardPreview => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Achieve_EmployTask Copy()
		{
			return null;
		}
	}
}
