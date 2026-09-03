using UnityEngine;

public class AI1856_TD : AINormalAttack_TD
{
	private enum Direction
	{
		up = 0,
		left = 1,
		right = 2,
		down = 3
	}

	private float crossWide;

	private Direction curEnemyDir;

	private Vector3 up;

	private Vector3 toface;

	protected override int GetWeaponId()
	{
		return 0;
	}

	protected override ActionBase getTargetNullAction()
	{
		return null;
	}

	public override ActionBase GetActionAttackWrapper()
	{
		return null;
	}
}
