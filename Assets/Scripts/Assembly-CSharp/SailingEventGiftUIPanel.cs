using System.Collections.Generic;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class SailingEventGiftUIPanel : MediatorCtrlBase
{
	public DxxText Text_Title;

	public DxxText Text_Desc;

	public ScrollRect scrollRect;

	public RectTransform Content;

	private int miniShow;

	public GameObject cpItem;

	public ButtonCtrl Button_Close;

	public DxxText Text_Close;

	public StarDiamondItem starItem;

	public DxxText Text_Diamond;

	private List<int> giftIdList;

	private List<SailingGiftItemData> dataList;

	protected override void OnInit()
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

	public override void OnHandleNotification(INotification notification)
	{
	}

	private void initUI()
	{
	}

	private void Esc()
	{
	}

	private void onButtonClose()
	{
	}
}
