using PureMVC.Interfaces;
using UnityEngine;

public class BattleChristmasUICtrl : BattleLevelUICtrl
{
	[SerializeField]
	private GameObject cdContainer;

	[SerializeField]
	private DxxText Text_Cd;

	private float m_fCdTime;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose()
	{
	}

	private void OnOpenDoor(RoomGenerateBase.Room room)
	{
	}

	protected override void OnUpdate(float delta)
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}
}
