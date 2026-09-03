using System;
using UnityEngine;
using UnityEngine.UI;

public class TradingAchievementRewardItem : MonoBehaviour
{
	[SerializeField]
	private Image icon;

	[SerializeField]
	private RectTransform parent;

	[SerializeField]
	private ButtonCtrl rewardTipBtn;

	[SerializeField]
	private ButtonCtrl clickBtn;

	[SerializeField]
	private PropOneEquip prop;

	[SerializeField]
	private ScrollRect scroll;

	[SerializeField]
	private GameObject go_Got;

	[SerializeField]
	private DxxText textBtnClick;

	private TradingAchRewardItemData itemData;

	private LocalUnityObjctPool pool;

	private bool isInit;

	public Action ClickDo;

	private void InitObjectPool()
	{
	}

	private void Init()
	{
	}

	public void Refresh(TradingAchRewardItemData itemData)
	{
	}

	private void RefreshScroll()
	{
	}

	public void Close()
	{
	}

	private void RefreshItem()
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
