public class SkillAlone1868 : SkillAlonePetBase
{
	private const string CurRecoverCountPerGameKey = "SkillAlone1868-maxRecoverCountPerGameKey";

	private const string CurRecoverCountPerRoomKey = "SkillAlone1868-maxRecoverCountPerRoomKey";

	private const int AVERAGE_RECOVER_COUNT = 5;

	private float triggerHPPercent;

	private float recoverRate;

	private float recoverHPPercent;

	protected int maxRecoverCountPerGame;

	private int maxRecoverCountPerRoom;

	private float recoverHPInterval;

	private int curRecoverCountPerGame;

	private int curRecoverCountPerRoom;

	private ActionBasic dropHPAction;

	private bool isBossRoom;

	protected override void OnInstall(params object[] args)
	{
	}

	protected override void OnUninstall()
	{
	}

	protected virtual void ParseArgs()
	{
	}

	private void onGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void onChangeHP(long curHP, long maxHp, float curPercent, long deltaHp)
	{
	}

	private void resetCurRecoverCountPerRoom()
	{
	}

	private void increaseCurRecoverCountPerRoom()
	{
	}

	private void increaseCurRecoverCountPerGame()
	{
	}
}
