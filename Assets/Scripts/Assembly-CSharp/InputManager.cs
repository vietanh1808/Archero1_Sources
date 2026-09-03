using System;
using System.Collections.Generic;

public class InputManager : Singleton<InputManager>
{
	private List<Action> onEscape;

	public void AddEscape(Action callback)
	{
	}

	public void RemoveEscape(Action callback)
	{
	}

	private void Update()
	{
	}
}
