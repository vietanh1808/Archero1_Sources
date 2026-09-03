using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArtifactApprasaPreviewRewardItem : MonoBehaviour
{
	[SerializeField]
	private Image icon;

	[SerializeField]
	private Transform parent;

	[SerializeField]
	private ButtonCtrl rewardTipBtn;

	[SerializeField]
	private ButtonCtrl clickBtn;

	[SerializeField]
	private GameObject chestObj;

	[SerializeField]
	private GameObject propObj;

	[SerializeField]
	private PropOneEquip propOne;

	[SerializeField]
	private GameObject mustGetObj;

	[SerializeField]
	private DxxText mustGetText;

	[SerializeField]
	private PropOneEquip_ArtifactApprase propOneEquip;

	[SerializeField]
	private DxxText previewDesc;

	[SerializeField]
	private Image BoxBg;

	private ArtifactAppraisaManager.GearReward itemData;

	private bool isInit;

	public Action ClickDo;

	private List<PropOneEquip_ArtifactApprase> showItems;

	private bool IsShowChest => false;

	private void Init()
	{
	}

	public void Refresh(ArtifactAppraisaManager.GearReward itemData)
	{
	}

	public void Close()
	{
	}

	private void RefreshItem()
	{
	}

	private void Click()
	{
	}

	private void ShowTip()
	{
	}

	private void CloseTip()
	{
	}
}
