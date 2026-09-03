using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class SLG_SLGBuff : LocalBean
	{
		private ObscuredInt _Id;

		private ObscuredString _Attribute;

		private ObscuredInt _AddAttribute;

		private ObscuredInt _Time;

		private ObscuredString _BuffLanguage;

		public int Id => 0;

		public string Attribute => null;

		public int AddAttribute => 0;

		public int Time => 0;

		public string BuffLanguage => null;

		protected override bool ReadImpl()
		{
			return false;
		}

		public SLG_SLGBuff Copy()
		{
			return null;
		}
	}
}
