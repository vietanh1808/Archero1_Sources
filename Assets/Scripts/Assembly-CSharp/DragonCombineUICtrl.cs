using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class DragonCombineUICtrl : MediatorCtrlBase
{
	public DragonCombineCtrl combineCtrl;

	public DragonResetCtrl resetCtrl;

	public Button combineButton;

	public Button resetButton;

	public GameObject combineFocus;

	public GameObject resetFocus;

	public DxxText combineText;

	public DxxText resetText;

	public GameObject redNode;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void OpenCombine()
	{
	}

	private void OpenReset()
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
