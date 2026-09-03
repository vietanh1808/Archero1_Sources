using PureMVC.Interfaces;
using UnityEngine;

public class BattleTryPlayUICtrl : BattleLevelUICtrl
{
	public RectTransform leftGroup;

	public RectTransform damagewindow;

	public ButtonCtrl Button_Quit;

	public ButtonCtrl Button_Rest;

	public DxxText dmgnumber;

	public DxxText dmgtitle;

	private int rebornCount;

	private float dmgTimer;

	private float battleStep;

	private ulong lastdmgNumber;

	private float timer;

	private float timerStep;

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

	protected override void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void OnClickQuit()
	{
	}

	private void OnClickRest()
	{
	}

	private bool CanReborn()
	{
		return false;
	}

	private void QuitClick()
	{
	}

	private void DeadEvent()
	{
	}

	private void GoToMain()
	{
	}

	private void DoReborn()
	{
	}

	public void Update()
	{
	}

	private void RestDamage()
	{
	}

	private void RefDmgText()
	{
	}
}
