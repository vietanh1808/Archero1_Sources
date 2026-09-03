public class AI3128_Artifact : AIBase_Artifact_Monster
{
	protected override ActionBase GetAttackHeroAction()
	{
		return null;
	}

	public override ActionBase GetMonsterAtkAction()
	{
		return null;
	}

	protected override void OnDeadBefore()
	{
	}
}
