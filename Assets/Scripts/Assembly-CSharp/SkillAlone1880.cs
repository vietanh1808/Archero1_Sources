public class SkillAlone1880 : SkillAlonePetBase
{
	protected const int PART_ID = 1852;

	private float deltaAtkPercent;

	private float partAliveTime;

	private int partCount;

	private float atkPercent;

	private int partExtraBulletCount;

	private float partExtraAtkPercent;

	private int minRadius;

	private int maxRadius;

	protected override void OnInstall(params object[] args)
	{
	}

	protected override void OnUninstall()
	{
	}

	protected virtual void ParseArgs()
	{
	}

	private void onCreatePart(EntityPartBodyBase part)
	{
	}

	private void OnPetAppear(BattlePetVO vO)
	{
	}

	protected virtual void OnAfterCreateParts()
	{
	}

	protected virtual int GetExtraPartCount()
	{
		return 0;
	}
}
