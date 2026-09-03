public class SkillAlone1905 : SkillAlonePetBase
{
	private const float ButterAnimTime = 1f;

	private const string UPDATE_NAME = "SkillAlone1905-Update";

	private float recoverHPPercent;

	private float recoverTime;

	private float recoverInterval;

	private float doubleRecoverRate;

	private int hitReduceBuffId;

	private float lowHPPercent;

	private int lowHPBuffID;

	private ActionBasic recoverHpAction;

	private bool addHitReduce;

	private ActionAroundObj actionAroundObj;

	private EntityBase PlayerEntity => null;

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

	protected virtual void OnRecoverOver()
	{
	}

	private void initAnim()
	{
	}

	private void removeAnim()
	{
	}

	private void initMove()
	{
	}

	private void deinitMove()
	{
	}

	private void initAction()
	{
	}

	private void deinitAction()
	{
	}

	private void tryResetAttr()
	{
	}
}
