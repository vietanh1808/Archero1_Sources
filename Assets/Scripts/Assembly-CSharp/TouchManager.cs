using System.Collections.Generic;
using UnityEngine;

public class TouchManager
{
	private static readonly TouchManager instance;

	private static Dictionary<TouchPhase, string> phaseName;

	private Dictionary<int, GameTouch> touchesDict;

	public static TouchManager Instance => null;

	private TouchManager()
	{
	}

	public void update(float deltaTime, float unscaledDeltaTime)
	{
	}

	private void setTouch(int fingerId, GameTouch touch)
	{
	}

	public Dictionary<int, GameTouch> getTouches()
	{
		return null;
	}

	public void clear()
	{
	}
}
