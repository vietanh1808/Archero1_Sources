using System;
using UnityEngine;

public class AutoDespawn : MonoBehaviour
{
	public float DespawnTime;

	private float pDespawnTime;

	private bool bStart;

	private bool needDoEvent;

	private Action despawnEvent;

	private bool m_bClearFlag;

	private void OnEnable()
	{
	}

	public void SetDespawnTime(float value)
	{
	}

	public void SetDespawnEvent(Action despawnEvent)
	{
	}

	private void Update()
	{
	}

	public void SetGoToNextRoomClearFlag()
	{
	}

	private void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}
}
