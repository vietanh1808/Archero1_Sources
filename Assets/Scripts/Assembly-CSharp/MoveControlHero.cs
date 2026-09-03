using UnityEngine;

public class MoveControlHero : MoveControl
{
	private GameObject footDirection;

	private EntityHero _EntityHero;

	private EntityHero mEntityHero => null;

	protected override void OnInit()
	{
	}

	protected override bool CanRegisterJoyTouch()
	{
		return false;
	}

	protected override void MoveStartVirtual()
	{
	}

	protected override void MovingVirtual(JoyData data)
	{
	}

	protected override void MoveEndVirtual()
	{
	}
}
