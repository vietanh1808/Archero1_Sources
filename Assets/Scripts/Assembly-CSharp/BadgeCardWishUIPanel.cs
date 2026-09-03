using PureMVC.Interfaces;
using UnityEngine;

public class BadgeCardWishUIPanel : MediatorCtrlBase
{
	[SerializeField]
	private DxxText Text_Title;

	[SerializeField]
	private DxxText Text_Desc;

	[SerializeField]
	private ButtonCtrl Button_Closed;

	[SerializeField]
	private BadgeCardItem cardItem;

	[SerializeField]
	private DxxText Text_WishRemain;

	[SerializeField]
	private DxxText Text_WishReset;

	[SerializeField]
	private ButtonCtrl Button_Cancel;

	[SerializeField]
	private DxxText Text_Cancel;

	[Header("许愿")]
	[SerializeField]
	private ButtonCtrl Button_Wish;

	[SerializeField]
	private DxxText Text_Wish;

	private BadgeCardItemData _curCardItemData;

	private int wishLeftCount;

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

	private void RefreshUI()
	{
	}

	private void onButtonWish()
	{
	}

	public void onButtonClosed()
	{
	}
}
