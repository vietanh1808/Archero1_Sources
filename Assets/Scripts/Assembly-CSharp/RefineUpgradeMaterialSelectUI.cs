using System;
using System.Collections.Generic;
using UnityEngine;

public class RefineUpgradeMaterialSelectUI : MonoBehaviour
{
	[SerializeField]
	private DxxText txtTitle;

	[SerializeField]
	private ButtonCtrl btnClose;

	[SerializeField]
	private PropOneEquipInfinity infinity;

	[SerializeField]
	private RectTransform mScrollRect;

	private List<LocalSave.EquipOne> filteredOptions;

	private ulong curSelection;

	private int curPos;

	public Action<ulong> onSelection;

	private HashSet<ulong> selected;

	private void Awake()
	{
	}

	private void UpdateCallback(int index, PropOneEquip item)
	{
	}

	public void Open(int type, int arg, ulong curSelection, HashSet<ulong> selected)
	{
	}

	public void Close()
	{
	}

	public void SetPos(int currentPos)
	{
	}
}
