using CodeStage.AntiCheat.ObscuredTypes;

namespace TableTool
{
	public class Guild_RedEnvelopeForCash : LocalBean
	{
		private ObscuredInt _CashID;

		private ObscuredInt _Type;

		private ObscuredString _Name;

		private ObscuredInt _RedEnvelopeId;

		private ObscuredString _CashName;

		private ObscuredInt _IfTime;

		private ObscuredInt _TimeStart;

		private ObscuredInt _TimeEnd;

		public int CashID => 0;

		public int Type => 0;

		public string Name => null;

		public int RedEnvelopeId => 0;

		public string CashName => null;

		public int IfTime => 0;

		public int TimeStart => 0;

		public int TimeEnd => 0;

		protected override bool ReadImpl()
		{
			return false;
		}

		public Guild_RedEnvelopeForCash Copy()
		{
			return null;
		}
	}
}
