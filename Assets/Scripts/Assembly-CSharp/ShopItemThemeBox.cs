using GameProtocol;
using UnityEngine;
using UnityEngine.UI;

public class ShopItemThemeBox : MonoBehaviour, AdsRequestHelper.AdsCallback
{
	public Text Title;

	public Text Description;

	public Text LastTime;

	public Image GiftIcon;

	public ButtonCtrl FreeBtn;

	public Text FreeText;

	public Text OneText;

	public GoldTextCtrl GoldCtrl;

	public GameObject FreeParent;

	public GameObject DiamondParent;

	public ButtonCtrl HintCtrl;

	public Button HintBg;

	public GameObject GroupBtn2;

	public ButtonCtrl FreeBtn2;

	public ButtonCtrl PaidBtn2;

	public Text FreeText2;

	public Text OneText2;

	public GoldTextCtrl GoldCtrl2;

	public CBoxGemActivityInfo Data;

	private bool ifWatchEnd;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void SetData(CBoxGemActivityInfo data)
	{
	}

	public void OnLanguageChange()
	{
	}

	public void OnBtnClick()
	{
	}

	public void OnAltBtnClick()
	{
	}

	public void DoBtnClick(bool preferFree)
	{
	}

	public void OnHintClick()
	{
	}

	private void OnGetReward(bool ifSuccess, CRespOpenBoxGem data)
	{
	}

	public void onRequest(AdsRequestHelper.AdsDriver sender, string networkName)
	{
	}

	public void onLoad(AdsRequestHelper.AdsDriver sender, string networkName)
	{
	}

	public void onFail(AdsRequestHelper.AdsDriver sender, string msg)
	{
	}

	public void onOpen(AdsRequestHelper.AdsDriver sender, string networkName)
	{
	}

	public void onClose(AdsRequestHelper.AdsDriver sender, string networkName)
	{
	}

	public void onClick(AdsRequestHelper.AdsDriver sender, string networkName)
	{
	}

	private void onRewardWrapper()
	{
	}

	private void onRewardInternal()
	{
	}

	public void onReward(AdsRequestHelper.AdsDriver sender, string networkName)
	{
	}
}
