using UnityEngine;

internal class ActionWuKongOneTwirl : ActionSeqWrapper
{
	public int CurTwirlCount;

	public SkillAloneWuKongTwirl SkillAloneInstance;

	public Vector3 CurTwirlEndScale;

	private bool isAnimSpeedChanged;

	private float deltaTwirlAnimSpeed;

	private float TwirlRotatingAnimTime;

	private float realDeltaSpeedPercent;

	public ActionWuKongOneTwirl(int curTwirlCount, SkillAloneWuKongTwirl skillAloneInstance)
	{
	}

	protected override void OnInit()
	{
	}

	protected override void OnEnd()
	{
	}

	protected override void OnUpdate()
	{
	}

	private void updateTwirlSpeed(int twirlIndex)
	{
	}

	private void resetTwirlSpeed()
	{
	}
}
