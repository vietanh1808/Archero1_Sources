using System;
using System.Collections.Generic;
using TableTool;
using UnityEngine;

public class BallonPurchaseItem : MonoBehaviour
{
	public DxxText nameTex;

	public Transform itemsParent;

	public ButtonCtrl buyBtn;

	public DxxText valueTex;

	public DxxText btnTex;

	public DxxText limitTex;

	private List<PropOneEquip> items;

	private ASSSDataParser.ADBallonIapReward iapReward;

	private int rewardIndex;

	private int remainCount;

	public Action<string, List<Drop_DropModel.DropData>, int> BuyDo;

	private int[][] rewards;

	public GameObject StarObj;

	public DxxText Text_Star;

	private int buyType;

	private void Awake()
	{
	}

	public void Init(ASSSDataParser.ADBallonIapReward iap_reward, Action<string, List<Drop_DropModel.DropData>, int> callback)
	{
	}

	public void SetRewardIndex(int index)
	{
	}

	public void ShowLimit(int count)
	{
	}

	private void ShowRewards()
	{
	}
}
