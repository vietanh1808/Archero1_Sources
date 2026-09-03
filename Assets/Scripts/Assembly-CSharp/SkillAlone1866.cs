public class SkillAlone1866 : SkillAlonePetBase
{
	protected float energyUpPercent;

	protected float maxEnergyUpPercent;

	private float deltaValue;

	protected override void OnInstall(params object[] args)
	{
	}

	protected override void OnUninstall()
	{
	}

	protected virtual void ParseArgs()
	{
	}

	private void onOpenDoor(RoomGenerateBase.Room room)
	{
	}

	private void onGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	protected virtual float GetDeltaValue(int waterCount)
	{
		return 0f;
	}

	private void updateAttr(float delta, string symbol)
	{
	}
}
