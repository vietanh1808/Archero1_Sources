using System;
using System.Collections.Generic;

public sealed class BoxSelectManager
{
	private static BoxSelectManager instance;

	private static object Locker;

	public static BoxSelectManager Instance => null;

	public void requestBoxSelect(int boxid, List<int> list1, List<int> list2, Action<bool> action = null, ushort type = 0, ushort count = 0)
	{
	}
}
