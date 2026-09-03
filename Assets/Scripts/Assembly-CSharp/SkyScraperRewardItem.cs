using System;
using UnityEngine;
using UnityEngine.UI;

public class SkyScraperRewardItem : ViewCell
{
	[SerializeField]
	private Image icon;

	[SerializeField]
	private DxxText progress;

	[SerializeField]
	private Animation chestAni;

	[SerializeField]
	private Transform parent;

	[SerializeField]
	private ButtonCtrl rewardTipBtn;

	[SerializeField]
	private ButtonCtrl clickBtn;

	[SerializeField]
	private PropOneEquip prop;

	[SerializeField]
	private GameObject chestObj;

	[SerializeField]
	private GameObject propObj;

	[SerializeField]
	private PropOneEquip propOne;

	[SerializeField]
	private Animation propAni;

	[SerializeField]
	private GameObject getStatus;

	private SkyScraperRewardItemData itemData;

	private LocalUnityObjctPool pool;

	private bool isInit;

	public Action ClickDo;

	private bool IsShowChest => false;

	private void InitObjectPool()
	{
	}

	protected override void OnInit()
	{
	}

	protected override void OnRefresh()
	{
	}

	public void Close()
	{
	}

	private void RefreshItem()
	{
	}

	private void RefreshImg()
	{
	}

	private void RefreshText()
	{
	}

	private void RefreshAni()
	{
	}

	private void RefreshStatus()
	{
	}

	private void ClickProp(PropOneBase item, object param)
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

	private void Request()
	{
	}

	private void RequestReward()
	{
	}
}
