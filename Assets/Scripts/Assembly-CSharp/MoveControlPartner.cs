public class MoveControlPartner : MoveControlHero
{
	protected override bool CanRegisterJoyTouch()
	{
		return false;
	}

	public override void OnMoveStart(JoyData data)
	{
	}

	public override void OnMoving(JoyData data)
	{
	}

	protected override void OnMoveEnd(JoyData data)
	{
	}
}
