using System.Collections.Generic;
using TableTool;
using UnityEngine;

public class RefineMaterialItem : MonoBehaviour
{
	public PropOneEquip propOne;

	[SerializeField]
	private ButtonCtrl btn;

	[SerializeField]
	private DxxText txtDesc;

	private RefineUpgradeMaterialSelectUI selectionUI;

	private int limitType;

	private int limitArg;

	public ulong selection;

	private static HashSet<ulong> selected;

	private void Awake()
	{
	}

	public void SetSelectionUI(RefineUpgradeMaterialSelectUI selectionUI)
	{
	}

	public void SetProp(Drop_DropModel.DropData data)
	{
	}

	public void SetSelection(int limitType, int limitArg, int position)
	{
	}

	public static void ClearSelection()
	{
	}
}
