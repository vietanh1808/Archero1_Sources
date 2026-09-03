public class EventSweepBlackShopUICtrl : EventBlackShopUICtrl
{
	protected override MysteriesSource GetSource()
	{
		return MysteriesSource.LEVEL;
	}

	protected override int GetShopType()
	{
		return 0;
	}

	protected override WindowID GetWindowID()
	{
		return WindowID.WindowID_Invaild;
	}

	protected override void ShowTips(string tips)
	{
	}
}
