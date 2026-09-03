using System;
using Dxx.UI;
using UnityEngine;

public class InfinityBase<T> : MonoBehaviour where T : Component
{
	public InfinityScrollGroup infinity;

	public GameObject copyItem;

	public int initDisplayCount;

	public Action<int, T> updatecallback;

	public void Init(int itemcount)
	{
	}

	public void SetItemCount(int itemcount)
	{
	}

	public void Refresh()
	{
	}

	private void UpdateChildCallbak(int index, T data)
	{
	}

	public void ScrollToIndex(int index)
	{
	}
}
