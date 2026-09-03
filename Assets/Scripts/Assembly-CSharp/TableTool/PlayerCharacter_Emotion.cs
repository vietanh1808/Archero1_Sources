using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class PlayerCharacter_Emotion : LocalBean
	{
		private ObscuredInt _Id;

		private ObscuredString _Resource;

		private ObscuredString _Icon;

		private ObscuredInt _Condition;

		private ObscuredString _Animation;

		public int Id => 0;

		public string Resource => null;

		public string Icon => null;

		public int Condition => 0;

		public string Animation => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public PlayerCharacter_Emotion Copy()
		{
			return null;
		}
	}
}
