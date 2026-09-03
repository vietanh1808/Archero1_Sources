public abstract class SingleTouchInteraction : BaseInteraction
{
	private bool forced;

	public SingleTouchInteraction()
	{
	}

	public override void handleTouchBegan(GameTouch touch)
	{
	}

	public override void handleTouchMoved(GameTouch touch)
	{
	}

	public override void handleTouchEnded(GameTouch touch)
	{
	}

	public override void forceTouchEnd()
	{
	}

	public abstract bool onTouchBegan(GameTouch touch);

	public abstract void onTouchMoved(GameTouch touch);

	public abstract void onTouchEnded(GameTouch touch);
}
