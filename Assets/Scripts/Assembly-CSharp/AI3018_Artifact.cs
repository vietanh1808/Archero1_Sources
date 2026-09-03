public class AI3018_Artifact : AIBase_Artifact_Monster
{
	public override float TwistFactor => 0f;

	protected override ActionBase GetAttackHeroAction()
	{
		return null;
	}

	public override ActionBase GetMonsterAtkAction()
	{
		return null;
	}
}
