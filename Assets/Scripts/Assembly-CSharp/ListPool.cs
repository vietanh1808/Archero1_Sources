using System.Collections.Generic;

internal static class ListPool<T>
{
	private static readonly ObjectPool<List<T>> s_ListPool;

	public static List<T> Get()
	{
		return null;
	}

	public static void Release(List<T> toRelease)
	{
	}
}
