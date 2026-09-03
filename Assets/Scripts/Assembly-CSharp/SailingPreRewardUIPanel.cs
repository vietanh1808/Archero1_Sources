using PureMVC.Interfaces;
using UnityEngine;

public class SailingPreRewardUIPanel : MediatorCtrlBase
{
	public DxxText Text_Title;

	public DxxText Text_SubTitle;

	public RectTransform RT_Content;

	public GameObject cpItem;

	public ButtonCtrl Button_Close;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
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

	private void initUI()
	{
	}

	private void onButtonClose()
	{
	}

	public void onButtonCloseWindow()
	{
	}
}
