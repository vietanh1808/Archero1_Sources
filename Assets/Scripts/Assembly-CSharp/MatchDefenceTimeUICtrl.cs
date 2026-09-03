using PureMVC.Interfaces;
using UnityEngine;

public class MatchDefenceTimeUICtrl : MediatorCtrlBase
{
	public ButtonCtrl Button_Match;

	public DxxText Text_Match;

	public GameObject match_obj;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void InitUI()
	{
	}

	private void StartMatch()
	{
	}

	private void StopMatch()
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
