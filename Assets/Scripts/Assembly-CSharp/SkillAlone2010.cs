public class SkillAlone2010 : SkillAloneBase
{
	protected HeroCapybaraSkillVO m_SkillVO;

	protected HeroCapybaraSkillArgs m_SkillArgs;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	protected virtual void onGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	public virtual float GetDeltaMeteorAtkPercent(float curHPPercent)
	{
		return 0f;
	}

	protected override void OnRecvCustomJsonActionInternal(CustomJsonDataCommand cmd, CustomJsonActionVO vo)
	{
	}
}
