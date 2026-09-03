using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BraveCampSeatPart : MonoBehaviour
{
	public PropOneEquip[] showEquips;

	public PropOneEquip moveEquips;

	private int curShowDataIndex;

	private TimeLineContainer timeLine;

	private List<BraveCampMgr.BraveCampRewardConfig> configs;

	public Button leftBtn;

	public Button rightBtn;

	public GameObject effect;

	public GameObject effect1;

	public Action<int> OnClickCallBack;

	public void Init()
	{
	}

	public void Open()
	{
	}

	private void Refresh(int rewardId)
	{
	}

	private void ClickItem(int id)
	{
	}

	public void ClickLeft()
	{
	}

	public void ClickRight()
	{
	}

	public void Close()
	{
	}
}
