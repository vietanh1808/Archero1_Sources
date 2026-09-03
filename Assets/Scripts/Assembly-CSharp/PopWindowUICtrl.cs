using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class PopWindowUICtrl : MediatorCtrlBase
{
	public DxxText Text_Title;

	public DxxText Text_Content;

	public DxxText Text_Sure;

	public DxxText Text_Refuse;

	public ButtonCtrl Button_Sure;

	public ButtonCtrl Button_Refuse;

	public Button Button_Close;

	[SerializeField]
	private RectTransform sureRoot;

	[SerializeField]
	private RectTransform refuseRoot;

	private PopWindowProxy.Transfer mTransfer;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void InitUI()
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
}
