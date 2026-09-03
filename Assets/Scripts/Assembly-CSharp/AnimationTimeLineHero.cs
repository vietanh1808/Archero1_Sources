using System;

public class AnimationTimeLineHero : AnimationTimeLineCtrlBase
{
	protected override void OnStartAttack(AniClass pAni, Action pOnComplete = null)
	{
	}

	protected override void OnEndtAttack(AniClass pAni, Action pOnComplete = null)
	{
	}

	public override void OnHitState(AniClass pAni, Action pOnComplete = null)
	{
	}

	public override float OnDeadState(AniClass pAni, Action pOnComplete = null)
	{
		return 0f;
	}
}
