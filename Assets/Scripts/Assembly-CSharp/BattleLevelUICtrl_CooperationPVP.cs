using PureMVC.Interfaces;
using UnityEngine;

public class BattleLevelUICtrl_CooperationPVP : BattleLevelUICtrl
{
	public ButtonCtrl Button_EndWatch;

	public DxxText Text_Watching;

	public DxxText Text_EndWatching;

	[SerializeField]
	private GameObject _goTopShowdownTips;

	[SerializeField]
	private Animator _animator;

	[SerializeField]
	private DxxText _textTopShowdown;

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

	private void CheckTopShowdown()
	{
	}

	public override void OnLanguageChange()
	{
	}

	protected override void OnApplicationQuit()
	{
	}

	protected override bool GetBtnShow()
	{
		return false;
	}

	private void OnCloseWindowAction(WindowID id)
	{
	}
}
