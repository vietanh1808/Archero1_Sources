using UnityEngine;

public abstract class BaseInteraction
{
	protected GameTouch currentTouch;

	protected int curTouchCount;

	private bool swallow;

	private bool touchEnabled;

	private Rect touchRect;

	private Rect curTouchRect;

	private TouchTypeEnum touchType;

	public GameTouch CurrentTouch
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int CurTouchCount
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public bool Swallow
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool TouchEnabled
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public Rect TouchRect
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public Rect CurTouchRect
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public TouchTypeEnum TouchType
	{
		get
		{
			return TouchTypeEnum.Single;
		}
		set
		{
		}
	}

	public BaseInteraction()
	{
	}

	public void onEnter()
	{
	}

	public void onExit()
	{
	}

	public abstract void handleTouchBegan(GameTouch touch);

	public abstract void handleTouchMoved(GameTouch touch);

	public abstract void handleTouchEnded(GameTouch touch);

	public abstract void forceTouchEnd();
}
