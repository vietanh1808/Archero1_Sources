public class AI2024 : AIBabyBase
{
	public const float REAL_SPEED = 4.6f;

	public const float ATTACK_RADIUS = 1f;

	protected override ActionBase GetAILogic()
	{
		return null;
	}

	protected override void OnAddAttack(ActionChooseIf choose)
	{
	}

	private ActionSequence getNormalMovAction()
	{
		return null;
	}

	protected override ActionBase GetAttackOrMove()
	{
		return null;
	}

	protected override void OnGoToNextRoom(RoomGenerateBase.Room room)
	{
	}
}
