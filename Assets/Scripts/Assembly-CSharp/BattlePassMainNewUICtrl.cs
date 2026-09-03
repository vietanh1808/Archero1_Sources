using System.Collections.Generic;
using Dxx.Util;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class BattlePassMainNewUICtrl : MonoBehaviour
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

	public BattlePassReward copyItem;

	public BattlePassReward copyItemRetro;

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

	public DxxText textExtraRewardCnt;

	public BattlePass_PropOne propExtraReward;

	public DxxText textExtraReward;

	public DxxText textGetExtraReward;

	public DxxText textExtraRewardDesc;

	public Image Icon_Normal;

	public Image Icon_Premium;

	public Image iconTopBg;

	public Image iconBottomBg;

	public Image iconMiddleBg;

	private const float period = 1123200f;

	private List<BattlePassReward> rewardList;

	private LocalSave.BattlePassConfigData_Unit nextReward;

	private LocalSave.BattlePassConfigData_Unit prevReward;

	private bool isRetro;

	private int nextRewardIndex;

	private LocalSave.BattlePassConfigData battlePassData;

	private SequencePool mSeqPool;

	private const float buyLevelYOffset = 136f;

	private const float itemHeight = 180f;

	public ScrollRect scorllRect;

	public void OnInit()
	{
	}

	private void ResetBattlePass()
	{
	}

	public void OnOpen()
	{
	}

	public void RefreshSprite()
	{
	}

	public void OnClose()
	{
	}

	private void android_escape()
	{
	}

	private void SetBuyLevelPos(BattlePassReward reward)
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

	private void OpenBuy(bool premium)
	{
	}

	private void OnClickExtraReward(PropOneBase prop, object obj)
	{
	}

	private void UpdateBattlepassBought()
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
