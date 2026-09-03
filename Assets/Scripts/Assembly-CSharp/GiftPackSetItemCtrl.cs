using System.Collections.Generic;
using GameProtocol;
using UnityEngine;

public class GiftPackSetItemCtrl : MonoBehaviour
{
	[SerializeField]
	private DxxText txtTitle;

	[SerializeField]
	private DxxText txtCritValue;

	[SerializeField]
	private DxxText txtCrit;

	[SerializeField]
	private DxxText txtBtnCurPrice;

	[SerializeField]
	private DxxText txtBtnOldPrice;

	[SerializeField]
	private DxxText txtBottom;

	[SerializeField]
	private ButtonCtrl btn;

	[SerializeField]
	private ButtonIAP btnStarDiamond;

	[SerializeField]
	private Transform contentRoot;

	private string productId;

	private int index;

	private CUserBackIapRewardsData data;

	private List<PropOneEquip> list;

	private bool isShowStarDiamond;

	public LocalUnityObjctPool pool { get; set; }

	private string sourceName => null;

	private string rewardId => null;

	private void Awake()
	{
	}

	private bool OnButBtnClickPre()
	{
		return false;
	}

	private void OnFailure(CRespInAppPurchase purchase)
	{
	}

	private void OnSuccess(CRespInAppPurchase purchase)
	{
	}

	public void UpdateUI(int itemIndex, bool hide = false)
	{
	}

	private void RefreshStarDiamond()
	{
	}

	private void OnStarBtnCLick(CRespInAppPurchase pData, bool isSuccess)
	{
	}

	public void OnLanguageChange()
	{
	}

	private int[][] GetReward(string rewardString)
	{
		return null;
	}
}
