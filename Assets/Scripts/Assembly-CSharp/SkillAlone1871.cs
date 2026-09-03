public class SkillAlone1871 : SkillAlonePetBase
{
	private int buffID;

	private float improveAttackValue;

	private float skillLastTime;

	private ConditionTime conditionTime;

	private int addAttackValue;

	private bool haveAddProperty;

	protected override void OnInstall(params object[] args)
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnPetAppear(BattlePetVO battlePetData)
	{
	}

	private void OnPetDisAppear(BattlePetVO battlePetData)
	{
	}

	protected virtual void CastSkill()
	{
	}

	private void AddEffect()
	{
	}

	private void RemoveEffect()
	{
	}

	private void OnUpdate(float delta)
	{
	}

	private void CheckProperty()
	{
	}

	private void ResetSkillData()
	{
	}
}
