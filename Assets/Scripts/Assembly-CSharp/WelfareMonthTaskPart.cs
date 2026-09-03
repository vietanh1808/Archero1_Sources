using System.Collections.Generic;
using GameProtocol;
using UnityEngine;

public class WelfareMonthTaskPart : MonoBehaviour
{
	public DxxText timrDownTex;

	public RectTransform taskParent;

	public WelfareMonthTaskItem copyObj;

	public WelfareMonthGiftItem copyGiftObj;

	private List<WelfareMonthTaskItem> taskItems;

	private List<WelfareMonthGiftItem> giftItems;

	private long showTimex;

	private STActivityCrazyMonth mData;

	private int CurTab;

	public void Init(STActivityCrazyMonth month)
	{
	}

	public void ClickTab(int tab)
	{
	}

	public void RefreshTaskList()
	{
	}

	public void RefreshGiftList()
	{
	}

	private void RefreshTime()
	{
	}

	private void UpdateTime()
	{
	}

	public void RefreshTask(uint type, uint taskId)
	{
	}
}
