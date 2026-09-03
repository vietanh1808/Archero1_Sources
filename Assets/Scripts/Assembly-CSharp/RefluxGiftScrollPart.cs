using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class RefluxGiftScrollPart : ScrollRect
{
	public GameObject normalCopyObj;

	public GameObject advanceCopyObj;

	public RectTransform view;

	public RectTransform itemParent;

	public float startPos;

	public float interVal;

	private List<RefluxGiftItem> items;

	private ActivityRefluxRewardItemJsonData[] rewards;

	public Action ClickDayGet;

	public Action<ActivityRefluxRewardItemJsonData> DragChageShowBigRewardCallBack;

	private int lastIndex;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_OnOpen;

	private static DelegateBridge __Hotfix0_RefreshList;

	private static DelegateBridge __Hotfix0_OnValueChange;

	private static DelegateBridge __Hotfix0_CalCurShowBigReward;

	private static DelegateBridge __Hotfix0_GetMaxBigGift;

	private static DelegateBridge _c__Hotfix0_ctor;

	public void OnInit()
	{
	}

	public void OnOpen()
	{
	}

	public void RefreshList()
	{
	}

	public void OnValueChange(Vector2 pos)
	{
	}

	private void CalCurShowBigReward()
	{
	}

	private ActivityRefluxRewardItemJsonData GetMaxBigGift()
	{
		return null;
	}
}
