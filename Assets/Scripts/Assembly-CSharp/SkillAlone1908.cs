public class SkillAlone1908 : SkillAlonePetBase
{
	private float perSecondReduceBodyHitted;

	private int stopMoveWaitMillisecondTime;

	private float originReduceBodyHittedValue;

	private float limitReduceBodyHittedValue;

	private float stopMoveWaitSecondTime;

	private float haveAddReduceBodyHittedValue;

	private float cumulativeOriginTime;

	private float cumulativeStartAddTime;

	private bool haveAddOrigin;

	private ConditionTime conditionTime;

	protected override void OnInstall(params object[] args)
	{
	}

	protected override void OnUninstall()
	{
	}

	protected virtual void AddOriginProperty()
	{
	}

	protected virtual void RemoveOriginProperty()
	{
	}

	protected virtual void AddProperty(float addValue)
	{
	}

	protected virtual void RemoveProperty()
	{
	}

	private void OnUpdate(float delta)
	{
	}

	private void CheckPlayerStatus(float delta)
	{
	}

	protected virtual void ResetSkillData()
	{
	}
}
