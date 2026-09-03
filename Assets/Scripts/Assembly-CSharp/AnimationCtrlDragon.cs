using System;

public class AnimationCtrlDragon : AnimationCtrlBase
{
	public const string SKILL_APPEAR = "Skill_Appear";

	public const string SKILL_ATTACK_PRE = "Skill_AttackPre";

	public const string SKILL_CONTINUOUS_ATTACK = "Skill_Attacking";

	public const string SKILL_ATTACK_END = "Skill_AttackEnd";

	public const string SKILL_DISAPPEAR = "Skill_Disappear";

	public void PlayAnim(string animName)
	{
	}

	public void StopAnim()
	{
	}

	public override void OnStart()
	{
	}

	protected void Event_Appear()
	{
	}

	private void Event_Disappear()
	{
	}

	private void Event_AttackEnd()
	{
	}

	private void Event_ContinuousAttack()
	{
	}

	private void Event_AttackPre()
	{
	}

	public override void SetAnimatorBase(AnimatorBase b)
	{
	}

	public override void SendEvent(string eventName, bool force = false)
	{
	}

	private void bindEvent(string animName, Action callback)
	{
	}

	private AniClass createAniClass(string animName)
	{
		return null;
	}

	private AniClass getAniClass(string animName)
	{
		return null;
	}
}
