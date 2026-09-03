public class SkillAlone2195 : SkillAloneBase
{
	private int CONFIG_ATTACK_SPEED_ADD;

	private int CONFIG_ATTACK_SPEED_MAX;

	private int CONFIG_DAMAGE_ADD;

	private int CONFIG_DAMAGE_MAX;

	private int m_nTotalAttakSpeedAdded;

	private int m_nTotalDamageAdded;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnHitted(EntityBase entity, long value)
	{
	}

	private void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}
}
