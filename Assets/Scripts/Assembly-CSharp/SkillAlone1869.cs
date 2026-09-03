public class SkillAlone1869 : SkillAlonePetBase
{
	private const string UPDATE_NAME = "Update-SkillAlone1869";

	private float deltaAtkPercent;

	private float aliveTime;

	private float AtkPercent;

	private float criteRatePercent;

	private long baseCustomCritValue;

	private float critValuePercent;

	private int weaponId;

	private const float atkInterval = 2f;

	private ActionBasic atkAI;

	private ConditionTime aliveTimeCondition;

	private EntityPet4005 pet;

	protected EntityBase PlayerEntity => null;

	protected override void OnInstall(params object[] args)
	{
	}

	protected override void OnUninstall()
	{
	}

	protected virtual void ParseArgs()
	{
	}

	private void onUpdate(float delta)
	{
	}

	private void initAtkAI()
	{
	}

	private AIBase.ActionAttack getAtkAction()
	{
		return null;
	}
}
