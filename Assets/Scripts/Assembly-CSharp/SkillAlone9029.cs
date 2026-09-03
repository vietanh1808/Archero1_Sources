public class SkillAlone9029 : SkillAloneBase
{
	public int m_buffId;

	public float m_needTime;

	public int m_maxCount;

	public float m_attack;

	private float lastTime;

	private int haveCount;

	private bool isAddAttack;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void parseParams()
	{
	}

	private void OnHitAction(EntityBase entity, HitStruct hs, HittedData ht)
	{
	}

	private void onGotoNextRoom(RoomGenerateBase.Room room)
	{
	}
}
