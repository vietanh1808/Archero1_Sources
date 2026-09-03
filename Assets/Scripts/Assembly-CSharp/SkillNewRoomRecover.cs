using System;

public class SkillNewRoomRecover : SkillRefineBase
{
	public int BuffId;

	public Action<RoomGenerateBase.Room> Callback;

	public SkillNewRoomRecover(EntityBase entity)
		: base(null)
	{
	}

	public override void Init()
	{
	}

	public override void DeInit()
	{
	}

	private void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}
}
