using System.Collections.Generic;
using TableTool;
using UnityEngine;

public class DiamondChoiceItem : MonoBehaviour
{
	[SerializeField]
	private RewardItem[] items;

	[SerializeField]
	private ButtonCtrl btn_AdFree;

	[SerializeField]
	private ButtonCtrl btn_Exc;

	[SerializeField]
	private DxxText txt_Discount;

	[SerializeField]
	private DxxText txt_Price;

	[SerializeField]
	private DxxText txt_Ad;

	[SerializeField]
	private DxxText txt_Quota;

	[SerializeField]
	private DxxText txt_ADCountDown;

	[SerializeField]
	private DxxText txt_CountDown;

	[SerializeField]
	private DxxText txt_AdFree;

	[SerializeField]
	private DxxText text_DiscountDes;

	[SerializeField]
	private GameObject go_adContent;

	[SerializeField]
	private GameObject go_Content;

	[SerializeField]
	private GameObject disCount;

	[SerializeField]
	private RedNodeCtrl redNode;

	[SerializeField]
	private GameObject go_Plus;

	[SerializeField]
	private GameObject go_Discount;

	[SerializeField]
	private GameObject go_Normal;

	[SerializeField]
	private GoldTextCtrl gt_NowPrice;

	[SerializeField]
	private GoldTextCtrl gt_PrePrice;

	private List<Drop_DropModel.DropData> rewards;

	private DiamondChoiceItemData crtData;

	private List<ushort> rewardIndex;

	public AdsController ads;

	private void Awake()
	{
	}

	public void SetData(DiamondChoiceItemData data)
	{
	}

	public void RequsetReward()
	{
	}

	private void showPopWindow2()
	{
	}

	public void OnClick(bool isAd)
	{
	}

	public void Refresh()
	{
	}

	private void UpdateTime()
	{
	}
}
