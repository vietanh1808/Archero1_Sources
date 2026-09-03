using PureMVC.Interfaces;
using UnityEngine;

public class GodWishExtendUIPanel : MediatorCtrlBase
{
	public GodWishGiftUIPanel giftUI;

	public GodWishShopUIPanel shopUI;

	public GameObject[] Tab_Obj;

	public GameObject[] Tab_Focus;

	public DxxText[] Tab_Title;

	public GameObject[] RedPoint;

	public GameObject TabContent;

	private int currentTab;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	public override void OnLanguageChange()
	{
	}

	private void Esc()
	{
	}

	public void onButtonTab(int tab)
	{
	}

	private void freshTabState()
	{
	}

	private void freshRedPoint()
	{
	}
}
