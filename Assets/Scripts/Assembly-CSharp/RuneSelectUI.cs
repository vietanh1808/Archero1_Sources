using System;
using System.Collections.Generic;
using GameProtocol;
using TableTool;
using UnityEngine;
using UnityEngine.UI;

public class RuneSelectUI : MonoBehaviour
{
	[SerializeField]
	private DxxText txtTitle;

	[SerializeField]
	private DxxText txtName;

	[SerializeField]
	private DxxText txtBtnInlay;

	[SerializeField]
	private DxxText txtRunePropertyTitle;

	[SerializeField]
	private DxxText txtUnlockTip;

	[SerializeField]
	private DxxText txtEquippedTip;

	[SerializeField]
	private Image imgLeft;

	[SerializeField]
	private Image imgRight;

	[SerializeField]
	private DxxText[] txtRuneProperties;

	[SerializeField]
	private ButtonCtrl btnInlay;

	[SerializeField]
	private ButtonCtrl btnClose;

	[SerializeField]
	private PropOneEquipInfinity infinity;

	[SerializeField]
	private ScrollRectBase scrollRect;

	[SerializeField]
	private RectTransform rtTip;

	[SerializeField]
	private float[] tipPos;

	private int selectedId;

	private int equippedId;

	private int index;

	private int pos;

	private int configPos;

	private List<Drop_DropModel.DropData> candidates;

	private bool unlocked;

	public Action onClose;

	private void Awake()
	{
	}

	private void UpdateCallback(int index, PropOneEquip item)
	{
	}

	private void OnBtnInlayClick()
	{
	}

	public void Open(int pos, int index, int equippedId)
	{
	}

	private void RefreshAll()
	{
	}

	private void RefreshInlayButton()
	{
	}

	private int GetRealStar(int star)
	{
		return 0;
	}

	private void RefreshCandidates()
	{
	}

	public void Close()
	{
	}

	private void RefreshProps()
	{
	}

	private string GetPropString(string effect)
	{
		return null;
	}

	private int Comparison(STCarvingItem a, STCarvingItem b)
	{
		return 0;
	}
}
