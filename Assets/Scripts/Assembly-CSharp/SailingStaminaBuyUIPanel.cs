using PureMVC.Interfaces;
using UnityEngine;

public class SailingStaminaBuyUIPanel : MediatorCtrlBase
{
	public DxxText Text_Title;

	public DxxText Text_Give;

	public DxxText Text_Diamond;

	public DxxText Text_Time_Ad;

	public DxxText Text_Time_Diamond;

	public DxxText Text_AdLeft;

	public DxxText Text_AdCount;

	public AdsController ads;

	public ButtonCtrl Button_Ad;

	public ButtonCtrl Button_Free;

	public ButtonCtrl Button_Close;

	public ButtonCtrl Button_Buy;

	public ButtonCtrl Button_Bg;

	public DxxText Text_BtnAd;

	public DxxText Text_BtnFree;

	public GameObject countDownObjAd;

	public GameObject countDownObjDiamond;

	public DxxText Text_BuyTimes;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose()
	{
	}

	private void initUI()
	{
	}

	private void _RefreshTimeCountDown()
	{
	}

	private void android_escape()
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

	private void _OnButtonClose()
	{
	}

	private void _OnBuyBtnClicked()
	{
	}

	private void _OnAdBtnClicked()
	{
	}

	private void _OnAdWatched(bool isWatched)
	{
	}
}
