using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Achieve_DailyTask : LocalBean
	{
		private ObscuredInt _ID;

		private ObscuredInt _Position;

		private ObscuredInt _Type;

		private ObscuredInt _TypeValue;

		private ObscuredInt _NeedLayer;

		private ObscuredString _NeedTalentLevel;

		private ObscuredInt _Weights;

		private ObscuredInt _Reward;

		private ObscuredInt _MinVersion;

		private ObscuredInt _MaxVersion;

		public int ID => 0;

		public int Position => 0;

		public int Type => 0;

		public int TypeValue => 0;

		public int NeedLayer => 0;

		public string NeedTalentLevel => null;

		public int Weights => 0;

		public int Reward => 0;

		public int MinVersion => 0;

		public int MaxVersion => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Achieve_DailyTask Copy()
		{
			return null;
		}
	}
}
