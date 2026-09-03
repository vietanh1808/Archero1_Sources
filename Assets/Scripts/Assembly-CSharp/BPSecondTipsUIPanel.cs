using PureMVC.Interfaces;
using UnityEngine;

public class BPSecondTipsUIPanel : MediatorCtrlBase
{
	public DxxText Text_Title;

	public DxxText Text_SubTitle;

	public ButtonCtrl Button_Close;

	public DxxText Text_Cost;

	public DxxText Text_Star;

	public ButtonCtrl Button_Cancel;

	public ButtonCtrl Button_OK;

	public DxxText Text_OK;

	public DxxText Text_Cancel;

	public RectTransform Container;

	public GameObject cpItem;

	private int needPrice;

	private string sdk_bps;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void initUI()
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

	private void Esc()
	{
	}

	private void onButtonOK()
	{
	}
}
