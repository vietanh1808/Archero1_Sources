using System.Collections.Generic;
using UnityEngine;

public class NewSingleChargeItem : MonoBehaviour
{
	public Transform rewardParent;

	public PropOneEquip rewardObj;

	public GameObject maskObj;

	public ButtonCtrl get_Button;

	public DxxText limitTex;

	public DxxText valueTex;

	public DxxText button_text;

	public DxxText valueDesTex;

	private List<PropOneEquip> RewardList;

	private ActNewReChargeManager.ActivitySingleChargeItem item;

	private NewSingleChargeUIPanel ctrl;

	public void Init(ActNewReChargeManager.ActivitySingleChargeItem item, NewSingleChargeUIPanel parent)
	{
	}

	public void ClickGet()
	{
	}

	public void Refresh()
	{
	}

	public void RefreshState()
	{
	}

	public void InitReward()
	{
	}
}
