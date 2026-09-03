using System.Collections.Generic;
using GameProtocol;
using UnityEngine;

public class CarvingInventoryPanel : MonoBehaviour, IEquipRefinePanel
{
	[SerializeField]
	private ButtonCtrl btnSwitch;

	[SerializeField]
	private ButtonCtrl btnClose;

	[SerializeField]
	private DxxText txtTitle;

	[SerializeField]
	private DxxText txtBtnSwitch;

	[SerializeField]
	private PropOneEquipInfinity infinity;

	[SerializeField]
	private ScrollRectBase mScrollRect;

	[SerializeField]
	private GameObject template;

	private int curIndex;

	[SerializeField]
	private ButtonCtrl[] btnPoses;

	[SerializeField]
	private DxxImage[] btnBgs;

	[SerializeField]
	private Sprite[] btnBgSprites;

	private int curSortType;

	private List<STCarvingItem> cachedData;

	private int configPos => 0;

	private void Awake()
	{
	}

	private void UpdateCallback(int index, PropOneEquip item)
	{
	}

	public void Init()
	{
	}

	public void Open(int pos)
	{
	}

	private void RefreshAll()
	{
	}

	public void Close()
	{
	}

	private void RefreshData()
	{
	}

	private void RefreshPosFilter()
	{
	}

	private int SortByPos(STCarvingItem a, STCarvingItem b)
	{
		return 0;
	}

	private int SortByQuality(STCarvingItem a, STCarvingItem b)
	{
		return 0;
	}

	private int SortByRarity(STCarvingItem a, STCarvingItem b)
	{
		return 0;
	}

	public void OnLanguageChange()
	{
	}

	public int CurPos()
	{
		return 0;
	}

	private int GetConfigPos(int index)
	{
		return 0;
	}

	private int SlotPosToUIPos(int index)
	{
		return 0;
	}
}
