using System;
using System.Collections.Generic;
using TableTool;
using UnityEngine;

public class BallonPurchasePart : MonoBehaviour
{
	public BallonPurchaseItem itemObj;

	public Transform itemParent;

	private List<BallonPurchaseItem> items;

	public void Init(List<ASSSDataParser.ADBallonIapReward> iapRewards, ushort[] rewardsindex, ushort[] rewardscount, Action<string, int, List<Drop_DropModel.DropData>, int> callBack)
	{
	}

	public void SetLimitByIndex(int index, int count)
	{
	}
}
