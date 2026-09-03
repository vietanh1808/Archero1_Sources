public class AI4013 : AI4006
{
	private const int BASE_ATTACK_WAIT = 500;

	protected override void OnInitOnce()
	{
	}

	protected override void OnAIDeInit()
	{
	}

	private void OnPetAttackSpeedChanged(int value)
	{
	}

	protected override ActionBase GetAILogic()
	{
		return null;
	}

	private int GetAttackWaitTime()
	{
		return 0;
	}

	protected override ActionBase GetActionMove()
	{
		return null;
	}

	private bool AttackCond()
	{
		return false;
	}

	private bool CanAIDoBehavior()
	{
		return false;
	}

	private bool IsJumpingNow()
	{
		return false;
	}
}
