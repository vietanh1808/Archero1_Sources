public class SkillAlone1929 : SkillAloneBase
{
	private int buff1;

	private int originExplodeProb;

	private int perAttackAddExplodeProb;

	private float explodeInterval;

	private float explodeDmgScale;

	private float explodeRadius;

	private int skillBuff;

	private int changeExplodeProb;

	private float lastExplodeDmgTime;

	private int attackAddExplodeProb;

	private int AllPerAttackAddExplodeProb => 0;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnCrit(EntityBase entity, long value)
	{
	}

	private void HitEnemy(EntityBase attackedTarget, HitStruct arg2, HittedData arg3)
	{
	}

	private void CreateSkill(EntityBase target)
	{
	}
}
