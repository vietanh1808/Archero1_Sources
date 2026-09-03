using System;

public class BattleTimeCD
{
	private const string UPDATE_NAME = "BattleTimeCD-UDPATE";

	public string ExternalTag;

	public Func<bool> customCondition;

	public float CD;

	private bool canCalCDTime;

	private float curTime;

	public void Init()
	{
	}

	public void DeInit()
	{
	}

	private void onMonsterCreated(EntityBase entity)
	{
	}

	private void onOpenDoor(RoomGenerateBase.Room room)
	{
	}

	private void onUpdate(float delta)
	{
	}

	public bool IsEnd()
	{
		return false;
	}

	public void Reset()
	{
	}

	public void SetCurTime(float value)
	{
	}

	public float GetCurTime()
	{
		return 0f;
	}
}
