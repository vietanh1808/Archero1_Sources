using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class MazeBuyUIPanel : MediatorCtrlBase
{
	[SerializeField]
	private DxxText text_Title;

	[SerializeField]
	private DxxText text_Confirm;

	[SerializeField]
	private DxxText text_LeftCount;

	[SerializeField]
	private DxxText text_Diamond;

	[SerializeField]
	private DxxText text_Count;

	[SerializeField]
	private ButtonCtrl btn_Close;

	[SerializeField]
	private ButtonCtrl btn_Add;

	[SerializeField]
	private ButtonCtrl btn_Reduce;

	[SerializeField]
	private ButtonCtrl btn_Buy;

	[SerializeField]
	private Slider slider_Buy;

	[SerializeField]
	private PropOneEquip prop;

	private ActivityMazeMgr mazeMgr => null;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	public override void OnLanguageChange()
	{
	}

	public void RefreshDiamondTextColor()
	{
	}

	public void OnSliderChanged(float count)
	{
	}

	public void Refresh()
	{
	}

	private void Esc()
	{
	}

	public void OnBtnCloseClick()
	{
	}

	public void OnBtnBuyClick()
	{
	}

	protected override void OnClose()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}
}
