public class SkillAlone2209 : SkillAlone2208
{
	private int addEnemyBuffID;

	protected bool IsSkillBulletHitEnemy(HitStruct hs)
	{
		return false;
	}

	protected override void OnInstall()
	{
	}

	protected override void OnHitAction(EntityBase attackTarget, HitStruct hs, HittedData hd)
	{
	}
}
