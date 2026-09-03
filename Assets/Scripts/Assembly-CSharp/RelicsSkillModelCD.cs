internal class RelicsSkillModelCD : RelicsSkillModelBase
{
	private int CONFIG_CD_TIME;

	private int m_nCDTime;

	private bool m_bPause;

	public int CDTime => 0;

	public float CDPercent => 0f;

	protected override void OnInit()
	{
	}

	protected override void OnDeInit()
	{
	}

	protected override bool OnEnable()
	{
		return false;
	}

	protected override void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	protected override void OnOpenDoor(RoomGenerateBase.Room room)
	{
	}

	protected override void OnUpdate(float delta)
	{
	}

	public override void OnClickBtn()
	{
	}
}
