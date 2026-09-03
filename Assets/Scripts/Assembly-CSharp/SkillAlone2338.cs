public class SkillAlone2338 : SkillAloneBase
{
	private class Skill2338ShieldVO : CustomJsonActionVO
	{
	}

	private float rate;

	private float duration;

	private float interval;

	private int buffId;

	private const int MaxShieldCount = 3;

	private int currentGoldShieldCount;

	private float lastCreateTime;

	private float shieldTimer;

	private bool hasShield;

	private const string SyncSkill2338_CreateShield = "SyncSkill2338_CreateShield";

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void ParseParams()
	{
	}

	private void OnHitted(EntityBase source, long hit)
	{
	}

	private void OnUpdate(float delta)
	{
	}

	private void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void AddGoldShield()
	{
	}

	private void RemoveAllShields()
	{
	}

	private void SyncCreateShield()
	{
	}

	private void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}
}
