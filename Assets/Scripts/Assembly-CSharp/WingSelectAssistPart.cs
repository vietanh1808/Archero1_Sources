using System.Collections.Generic;
using UnityEngine;

public class WingSelectAssistPart : MonoBehaviour
{
	public float top;

	public float pidding;

	public int existCount;

	public float cellHigh;

	public RectTransform itemParent;

	public RectTransform view;

	public WingSelectAssistItem itemCopy;

	private WingSelectAssistItem[] items;

	private List<LocalSave.WingOne> wings;

	private LocalSave.WingOne wingOne;

	public bool isOpen;

	private int firstIndex;

	public void Init()
	{
	}

	public void Open(LocalSave.WingOne wing)
	{
	}

	public void OnValueChange(Vector2 pos)
	{
	}

	public void RefreshList()
	{
	}

	public void Close()
	{
	}
}
