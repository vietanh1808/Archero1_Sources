using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class Act6thBpBuyUIPanel : MediatorCtrlBase
{
	public DxxText Text_Title;

	public DxxFitContentText Text_PrivilegeDesc;

	public DxxFitContentText Text_PrivilegeInfo;

	public DxxFitContentText Text_RewardDesc;

	public DxxText Text_Crit;

	public DxxText Text_CritDesc;

	public ButtonCtrl Button_Buy;

	public DxxText Text_Price;

	public ButtonCtrl Button_Close;

	public RectTransform RTF_Content;

	public ScrollRect scrollRect;

	public PropOneEquip equipOne;

	public StarDiamondItem starItem;

	public ButtonCtrl Button_Star;

	public DxxText Text_Star;

	public DxxText Text_Time;

	private long showTimex;

	private LocalUnityObjctPool _pool;

	private Act6thManager AMgr => null;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
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

	private void InitUI()
	{
	}

	private void RefreshReward()
	{
	}

	private void freshTime()
	{
	}

	public void onButtonClose()
	{
	}

	private void onButtonBuy()
	{
	}

	private void onButtonStar()
	{
	}

	private void PurchaseSuccess()
	{
	}
}
