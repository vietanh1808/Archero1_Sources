using TableTool;

public abstract class RelicsSkillModelBase
{
	protected Relics_ActiveSkill m_Data;

	public bool Enable => false;

	public void Init(Relics_ActiveSkill data)
	{
	}

	public void DeInit()
	{
	}

	public void Update(float delta)
	{
	}

	protected abstract bool OnEnable();

	protected abstract void OnUpdate(float delta);

	protected abstract void OnInit();

	protected abstract void OnDeInit();

	protected abstract void OnGotoNextRoom(RoomGenerateBase.Room room);

	protected abstract void OnOpenDoor(RoomGenerateBase.Room room);

	public abstract void OnClickBtn();
}
