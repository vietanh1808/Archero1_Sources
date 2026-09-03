using UnityEngine;

public class SkillAlone1273 : SkillAlone1272
{
	private int speedUpBuffId;

	private int speedDownBuffId;

	private long originalSpeed;

	private bool setOriginalSpeedOnce;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	protected override void ParseParams()
	{
	}

	protected override void OnGotoNextRoom(RoomGenerateBase.Room obj)
	{
	}

	protected override void OnOpenDoor(RoomGenerateBase.Room obj)
	{
	}

	private void OnKill(EntityBase arg1, Vector3 arg2, HitStruct hs)
	{
	}

	private void resetMoveSpeed()
	{
	}

	protected override void onTimer()
	{
	}
}
