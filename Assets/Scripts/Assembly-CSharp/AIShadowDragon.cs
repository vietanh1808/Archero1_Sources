public class AIShadowDragon : AIDragonBase
{
	public const int BULLET_ID = 1211;

	public const int BUFFID = 1058;

	public const float TOTAL_TIME = 5f;

	private const float DELTA_SPEED = 0.5f;

	private const float INIT_TIME = 1f;

	private ActionShadowDragon shadowAction;

	protected override void OnInit1()
	{
	}

	protected override AIBase.ActionSequence getAnimSequenceAction()
	{
		return null;
	}

	protected override void AfterSkillAttackPre()
	{
	}

	private float GetTimeInterval()
	{
		return 0f;
	}
}
