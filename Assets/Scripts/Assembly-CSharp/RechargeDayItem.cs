using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RechargeDayItem : MonoBehaviour
{
	public Image bg_img;

	public Image title_img;

	public DxxText title_text;

	public DxxText progress_text;

	public ButtonCtrl get_Button;

	public DxxText button_text;

	public Transform rewardParent;

	public PropOneEquip rewardObj;

	public GameObject maskObj;

	public Color reciviceColor;

	public Color noReceviceColor;

	public DxxText descTex;

	private ActNewReChargeManager.ActivityChargeItem item;

	private List<PropOneEquip> RewardList;

	private long showTime;

	public void Init(ActNewReChargeManager.ActivityChargeItem item)
	{
	}

	public void ClickGet()
	{
	}

	public void InitReward()
	{
	}

	public void RefreshState()
	{
	}

	private void UpdateTime()
	{
	}

	private void GoToShop()
	{
	}
}
