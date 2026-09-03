public class ActionPauseAnim : ActionSeqWrapper
{
	private const float slowDeltaPercent = 0.99999f;

	public float pauseAnimTime;

	public string AnimName;

	private bool changeAnimSpeed;

	protected override void OnEnd()
	{
	}

	protected override void OnInit()
	{
	}

	private void resetAnimSpeed()
	{
	}
}
