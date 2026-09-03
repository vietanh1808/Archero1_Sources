using PureMVC.Interfaces;
using UnityEngine;

public class BadgeAbilityGetUIPanel : MediatorCtrlBase
{
	[SerializeField]
	private DxxText Text_Title;

	[SerializeField]
	private DxxText Text_Info1;

	[SerializeField]
	private DxxText Text_Info2;

	[SerializeField]
	private ButtonCtrl Button_OK;

	[SerializeField]
	private DxxText Text_OK;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void initUI()
	{
	}

	private void Esc()
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

	public void OnButtonTouchScrren()
	{
	}

	private void onButtonOK()
	{
	}
}
