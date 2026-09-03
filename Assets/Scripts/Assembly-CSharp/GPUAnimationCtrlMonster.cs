using System.Collections.Generic;

public class GPUAnimationCtrlMonster : AnimationCtrlMonster
{
	private AnimatedMeshAnimation m_Ani;

	private Dictionary<string, bool> LoopConfig;

	public void SetAnimationCtrl(AnimatedMeshAnimation ani)
	{
	}

	protected override void Event_AttackPrevI(AniClass a)
	{
	}

	protected override void Event_AttackEndI(AniClass a)
	{
	}

	protected override void Event_CallI(AniClass a)
	{
	}

	protected override void Event_SkillI(AniClass a)
	{
	}

	protected override void Event_ContinuousI(AniClass a)
	{
	}

	protected override void Event_IdleI(AniClass a)
	{
	}

	protected override void Event_RunI(AniClass a)
	{
	}

	protected override void Event_HittedZI(AniClass a)
	{
	}

	protected override void Event_DizzyI(AniClass a)
	{
	}

	protected override void Event_DeadI(AniClass a)
	{
	}

	protected override void Event_SkillEndI(AniClass a)
	{
	}

	protected override void AttackInterrupt()
	{
	}

	protected override void ChangeState(AniClass state)
	{
	}

	private bool PlayGpuAnimation(AniClass a)
	{
		return false;
	}

	public override void DizzyEnd()
	{
	}
}
