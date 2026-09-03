using System.Collections.Generic;

public class SkillAlone2225 : SkillAlone2224
{
	private int minRandomValue;

	private bool haveAutoCastSkill;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	protected override void SkillStartStart()
	{
	}

	protected override int GetRandomMinValue()
	{
		return 0;
	}

	private void OnWaveCreated(List<MapCreator.GoodsInfo> infos)
	{
	}

	protected void OnGotoNextRoomAfter(RoomGenerateBase.Room room)
	{
	}

	private void OnGameType5WaveCreated()
	{
	}

	private void OnEntityCreated(EntityBase enemy)
	{
	}

	protected override void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void TryAutoCastSkill()
	{
	}
}
