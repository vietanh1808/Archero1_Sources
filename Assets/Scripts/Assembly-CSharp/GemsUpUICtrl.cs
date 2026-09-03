using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class GemsUpUICtrl : MediatorCtrlBase
{
	public GemCombineCtrl combineCtrl;

	public Button combineButton;

	public GameObject combineFocus;

	public DxxText combineText;

	private GemCombineData ccbData;

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

	public void OnButtonTab(int tab)
	{
	}
}
