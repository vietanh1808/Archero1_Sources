using PureMVC.Interfaces;

public class DSMShootPanel : MediatorCtrlBase
{
	public DxxText titleTex;

	public DxxText exchangeBtnTex;

	public DxxText shootBtnTex;

	public ButtonCtrl closeBtn;

	public ButtonCtrl exchangeBtn;

	public ButtonCtrl shootBtn;

	public DSMShootItem normalItem;

	public DSMShootItem premiumItem;

	public DSMShootBuyPanel shootBuyPanel;

	public DSMShootExchangePanel shootExchangePanel;

	private int selectNormalMCannonCount;

	private int selectPremiumMCannonCount;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void OnExchangeBomCallBack()
	{
	}

	protected override void OnClose()
	{
	}

	private void OnMCannonChanged(SailingMCannonType type, int count)
	{
	}

	private void ClickClose()
	{
	}

	private void ClickExchange()
	{
	}

	private void ClickShoot()
	{
	}

	public void OpenBuyPanel()
	{
	}

	public override void OnLanguageChange()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}
}
