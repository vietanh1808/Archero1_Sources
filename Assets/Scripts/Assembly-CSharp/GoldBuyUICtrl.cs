using PureMVC.Interfaces;
using UnityEngine;

public class GoldBuyUICtrl : MediatorCtrlBase
{
	private static CoinExchangeSource mSource;

	public DxxText Text_Title;

	public DxxText Text_Content;

	public GoldTextCtrl mDiamondCtrl;

	public ButtonCtrl Button_Buy;

	public ButtonCtrl Button_Close;

	public ButtonCtrl Button_Shadow;

	[SerializeField]
	private DxxText Text_ExtraGold;

	private GoldBuyModuleProxy.Transfer mTransfer;

	private bool bought;

	public static void SetSource(CoinExchangeSource source)
	{
	}

	public static CoinExchangeSource GetSource()
	{
		return CoinExchangeSource.EKEY;
	}

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void InitUI()
	{
	}

	private void android_escape()
	{
	}

	protected override void OnClose()
	{
	}

	public override object OnGetEvent(string eventName)
	{
		return null;
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	public override void OnLanguageChange()
	{
	}
}
