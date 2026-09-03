using PureMVC.Interfaces;
using UnityEngine;

public class ActIslandVSUIPanel : MediatorCtrlBase
{
	public RectTransform Window;

	public DxxText Text_Coin;

	public DxxText Text_Diamond;

	public DxxText Text_PropA;

	public DxxText Text_PropB;

	public ButtonCtrl Button_Info;

	public DxxText Text_Title;

	public DxxText Text_Time;

	public ButtonCtrl Button_Task;

	public DxxText Text_Task;

	public GameObject RedPoint_Task;

	public ButtonCtrl Button_Shop;

	public DxxText Text_Shop;

	public GameObject RedPoint_Shop;

	public ButtonCtrl Button_Gift;

	public DxxText Text_Gift;

	public GameObject RedPoint_Gift;

	public ButtonCtrl Button_Back;

	public ButtonCtrl Button_QuickBuy;

	public ActIslandVSPlay playUI;

	protected override void OnInit()
	{
	}

	private void Esc()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose()
	{
	}

	public override void OnLanguageChange()
	{
	}

	private void initUI()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	private void onButtonInfo()
	{
	}

	private void onButtonBack()
	{
	}

	private void freshTime()
	{
	}

	private void onButtonTask()
	{
	}

	private void onButtonGift()
	{
	}

	private void onButtonShop()
	{
	}

	private void onButtonQuickBuy()
	{
	}

	public void openQuickBuyUI()
	{
	}

	private void freshRedPoint()
	{
	}

	private void freshCurrency()
	{
	}
}
