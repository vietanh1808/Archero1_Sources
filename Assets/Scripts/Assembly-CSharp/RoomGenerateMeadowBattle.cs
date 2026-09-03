public class RoomGenerateMeadowBattle : RoomGenerateBase
{
	public static int TOTAL_POINTS;

	public static int MEADOW_BATTLE_LAYER_MASK;

	public override void StartGame()
	{
	}

	private void initConfig()
	{
	}

	protected override void GotoNextDoor()
	{
	}

	protected override string OnGetTmxID(int roomid)
	{
		return null;
	}

	protected override void OnDeinitBefor()
	{
	}

	private void initEmptyRoom()
	{
	}

	private bool hasBattleCache()
	{
		return false;
	}
}
