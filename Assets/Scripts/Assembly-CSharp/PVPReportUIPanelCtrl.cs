public class PVPReportUIPanelCtrl : MediatorCtrlBase
{
	public class PVPReportData
	{
		public int source;

		public int end_type;

		public int score;
	}

	public ButtonCtrl Button_Close;

	public ButtonCtrl Button_Shadow;

	public DxxText Text_Title;

	public ButtonCtrl[] Button_Reports;

	public DxxText[] Text_Btns;

	protected override void OnInit()
	{
	}

	private void android_escape()
	{
	}

	protected override void OnClose()
	{
	}

	protected override void OnOpen()
	{
	}

	public override void OnLanguageChange()
	{
	}

	private void sendEventReport(string step, int count = 0)
	{
	}
}
