public class SkillAlone1718 : SkillAloneWuKongTwirl
{
	protected float totalCDTime;

	protected int buffId;

	protected int skillBuffId;

	protected int minPartCount;

	protected int maxPartCount;

	protected int minRadius;

	protected int maxRadius;

	protected float partAliveTime;

	protected string partAttr;

	protected override int BULLET_ID => 0;

	protected override void OnInstall()
	{
	}

	protected override void ParseArgs()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void onWillDead()
	{
	}

	private void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void onHit(EntityBase attackTarget, HitStruct hit, HittedData hitteddata)
	{
	}

	private void onCreatePlayer()
	{
	}

	private void parseArgs5(string[] args)
	{
	}

	protected override void OnBeforeTwirlSkill()
	{
	}

	protected override void OnAfterTwirlSkill()
	{
	}

	protected void EndTwirlSkill()
	{
	}

	protected void ForceEndTwirlSkill()
	{
	}
}
