using System;

public class FirstEnemyCheck
{
	[Flags]
	public enum RoomStatus
	{
		None = 0,
		EntityCreated = 1,
		GotoNextRoom = 2,
		OpenDoor = 4
	}

	private const string UPDATE_NAME = "FirstEnemyCheck-Update";

	public Action OnFirstEnemyCreated;

	private RoomStatus roomStatus;

	public bool isFirstEnemyCreatedNotified;

	public void Init()
	{
	}

	public void Deinit()
	{
	}

	private void onEntityCreated(EntityBase @base)
	{
	}

	private void onGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void onOpenDoor(RoomGenerateBase.Room room)
	{
	}

	private void onUpdate(float delta)
	{
	}

	public bool IsInBattleTime()
	{
		return false;
	}

	public bool IsInStatus(RoomStatus status)
	{
		return false;
	}

	public void SetRoomStatus(RoomStatus status)
	{
	}

	public void ClearRoomStatus(RoomStatus status)
	{
	}

	public void ResetPetStatus()
	{
	}
}
