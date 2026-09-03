using System.Collections.Generic;
using GameInteraction;

internal class ControllerManager
{
	private Dictionary<int, Controller> list;

	private int count;

	private List<SortedControllerProxy> sortedIdList;

	public void Clear()
	{
	}

	private void setControllerTouchEnabled(bool enable)
	{
	}

	private Controller getControllerById(int id)
	{
		return null;
	}

	public void addController(Controller controller, int _priority = 0)
	{
	}

	private void removeControllerById(int id)
	{
	}

	private void removeControllersByTag(string tag)
	{
	}

	private void removeFromSortedList(int id)
	{
	}

	private Controller getControllerByTag(string tag)
	{
		return null;
	}

	public bool handleInteraction(GameTouch touch)
	{
		return false;
	}

	private void forceTouchEnd()
	{
	}
}
