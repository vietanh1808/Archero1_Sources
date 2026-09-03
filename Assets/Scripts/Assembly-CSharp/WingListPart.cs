using System;
using System.Collections.Generic;
using PureMVC.Interfaces;
using UnityEngine;

public class WingListPart : MonoBehaviour
{
	public GameObject itemPrefab;

	public Transform content;

	private List<WingItem> items;

	public Action<LocalSave.WingOne> onSelect;

	private int showIndex;

	public void Init()
	{
	}

	public void Open()
	{
	}

	private void InitList()
	{
	}

	private WingItem CreateItem(int index)
	{
		return null;
	}

	private void OnSelectWing(LocalSave.WingOne wing)
	{
	}

	private void OnBackTrySelectWing(LocalSave.WingOne wing)
	{
	}

	public void Close()
	{
	}

	public void OnHandleNotification(INotification notification)
	{
	}
}
