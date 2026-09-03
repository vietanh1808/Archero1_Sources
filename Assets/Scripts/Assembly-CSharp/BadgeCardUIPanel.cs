using PureMVC.Interfaces;
using UnityEngine;

public class BadgeCardUIPanel : MediatorCtrlBase
{
	[SerializeField]
	private DxxText Text_Title;

	[SerializeField]
	private BadgeCardItem cardItem;

	[SerializeField]
	private DxxText Text_Effect;

	[SerializeField]
	private DxxText[] Text_EffectItem;

	[Header("激活")]
	[SerializeField]
	private ButtonCtrl Button_Activate;

	[SerializeField]
	private DxxText Text_Active;

	[Header("许愿")]
	[SerializeField]
	private ButtonCtrl Button_Wish;

	[SerializeField]
	private DxxText Text_Wish;

	[SerializeField]
	private ButtonCtrl Button_Box;

	[SerializeField]
	private GameObject BoxGetObj;

	[SerializeField]
	private DxxText Text_WishRemain;

	[SerializeField]
	private DxxText Text_WishReset;

	[SerializeField]
	private GameObject RedDot;

	private BadgeCardItemData _curCardItemData;

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

	private void onButtonActivate()
	{
	}

	private void onButtonWish()
	{
	}

	private void onButtonBox()
	{
	}

	public void onButtonClosed()
	{
	}
}
