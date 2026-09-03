public class SkillAlone2080 : SkillAlonePetBase
{
	private int firstBeHurtReduceDmg;

	private bool haveAddFirstBeHurtProperty;

	private bool isChangeFromSkill2080;

	private bool isAlwaysFlyWater;

	protected override void OnInstall(params object[] args)
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnFlyWaterChange(bool fly)
	{
	}

	private void OnHitted(EntityBase entity, long hit)
	{
	}

	private void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	protected virtual void AddHittedEffect()
	{
	}

	protected virtual void OnNextRoomEffect()
	{
	}
}
