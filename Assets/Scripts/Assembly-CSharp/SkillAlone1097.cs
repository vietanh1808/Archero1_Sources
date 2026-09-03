using Dxx.Util;

public class SkillAlone1097 : SkillAloneBase
{
	private const string String_HarmRate = "HarmRate%";

	private const string String_WeightIni = "WeightIni";

	private const string String_WeightArgs = "WeightArgs";

	private const string String_WeightLimit = "WeightLimit";

	private const string String_BulletId = "BulletId";

	private const string String_CatNumAdd = "CatNumAdd";

	private int WeightIni;

	private int WeightArgs;

	private int WeightLimit;

	protected int BulletId;

	private int catNumAdd;

	private float attackRatio;

	private SequencePool mSeqPool;

	protected override void OnInstall()
	{
	}

	private void Excute(string str)
	{
	}

	protected override void OnUninstall()
	{
	}

	protected void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void OnAttack()
	{
	}

	protected virtual bool CanShoot()
	{
		return false;
	}

	protected virtual BulletBase CreateCatBullet(EntityBase entityBase)
	{
		return null;
	}

	protected virtual float GetBulletAngle(EntityBase entityBase)
	{
		return 0f;
	}
}
