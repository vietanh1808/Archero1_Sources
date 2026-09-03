public class SkillAlone2018 : SkillAloneBase
{
	private enum MoveState
	{
		Idle = 0,
		Moving = 1
	}

	private const string UPDATE_NAME = "SkillAlone2018-Update";

	private int buffId;

	private float[] timePoints;

	private bool IsMoving;

	private float curIdleTime;

	private int curIndex;

	private MoveState mState;

	private bool addBuff;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void init()
	{
	}

	private void GotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void onUpdate(float delta)
	{
	}

	private void onMove(bool _isMoving)
	{
	}

	private void changeState(MoveState _state)
	{
	}

	private void onReach2TimePoint()
	{
	}

	private void onChange2Idle()
	{
	}

	private void onChange2Moving()
	{
	}

	private void tryRemoveBuff()
	{
	}
}
