using System.Collections.Generic;
using Dxx.Util;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class BattlePassOtherNewUICtrl : MonoBehaviour
{
	public Slider m_slider;

	public RectTransform Image_TimeBG;

	public ButtonCtrl buttonOpenBuy;

	public ButtonCtrl buttonOpenBuyPremium;

	public DxxText textBuy;

	public DxxText textBuyPremium;

	public DxxText lastTime;

	public DxxText battlePassLevel;

	public DxxText textTokenRewardTitle;

	public DxxText textTokenRewardPremiumTitle;

	public DxxText textNormalRewardTile;

	public RectTransform countDownPanel;

	public CountDownCtrl countDown;

	public ButtonCtrl buttonClose;

	public RectTransform transContent;

	public BattlePassNewReward copyItem;

	public BattlePassNewReward copyItemRetro;

	public RectTransform topInfoParent;

	public DxxText textSeason;

	public DxxText normalCanGetText;

	public DxxText tokenCanGetText;

	public DxxText textExpProgress;

	public RectTransform battlePassEmblem;

	public RectTransform battlePassEmblemPremium;

	public DxxText textSeasonName;

	public BattlePassChestInformation chestInfo;

	public RectTransform progressBar;

	public GameObject nextLevelIcon;

	public DxxText textFullLevel;

	public RectTransform buyLevel;

	public ButtonCtrl buttonBuyLevel;

	public DxxText textBuyLevel;

	public RectTransform buyLevelMask;

	public RectTransform buyLevelMask2;

	public GameObject[] effectList;

	public RectTransform extraRewardSection;

	public GameObject goExtraNormal;

	public GameObject goExtraPremium;

	public DxxText textExtraRewardCnt;

	public BattlePass_PropOne propExtraReward;

	public DxxText textExtraReward;

	public DxxText textGetExtraReward;

	public DxxText textExtraRewardDesc;

	public Image iconKv;

	public Image iconTopBg;

	public Image iconBottomBg;

	public Image roleImage;

	public Image boxImage;

	public Image iconNormal;

	public Image iconPremium;

	public Image iconMiddleBg;

	private const float period = 1123200f;

	private List<BattlePassNewReward> rewardList;

	private LocalSave.BattlePassNewItemData nextReward;

	private LocalSave.BattlePassNewItemData prevReward;

	private bool isRetro;

	private int nextRewardIndex;

	private LocalSave.BattlePassNewData battlePassData;

	private SequencePool mSeqPool;

	private LocalSave.NewBpType _bpType;

	private const float buyLevelYOffset = 136f;

	private const float itemHeight = 180f;

	public ScrollRect scorllRect;

	public void OnInit()
	{
	}

	public void SetBPType(LocalSave.NewBpType bpType)
	{
	}

	public void RefreshSprite()
	{
	}

	public void ResetBattlePass()
	{
	}

	public void RefreshData()
	{
	}

	public void OnOpen()
	{
	}

	public void OnClose()
	{
	}

	protected void android_escape()
	{
	}

	private void SetBuyLevelPos(BattlePassNewReward reward)
	{
	}

	private void RefreshList()
	{
	}

	private bool IsExtraRewardAvailable()
	{
		return false;
	}

	private void InitText()
	{
	}

	public void OnLanguageChange()
	{
	}

	private void OnClickClose()
	{
	}

	private void OpenBuyLevel()
	{
	}

	private bool CheckOpenStatus()
	{
		return false;
	}

	private void OpenBuy(bool premium)
	{
	}

	private void OnClickExtraReward(PropOneBase prop, object obj)
	{
	}

	private void ToggleEffect(bool isOn)
	{
	}

	public void OnHandleNotification(INotification notification)
	{
	}

	public void OnDeInit()
	{
	}

	public void checkScorllTo()
	{
	}
}
