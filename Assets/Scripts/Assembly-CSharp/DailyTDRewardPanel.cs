using System;
using System.Collections.Generic;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;
using XLua;
using newplay122;

public class DailyTDRewardPanel : MediatorCtrlBase
{
	public DailyTDRewardPop rewardPop;

	public RewardPointItem RewardPointItemPrefab;

	public NewPlay122RewardBoxItem NewPlay122RewardBoxItemPrefab;

	private LocalUnityObjctPool mPool;

	private List<RewardPointItem> rewardPointItems;

	private List<NewPlay122RewardBoxItem> rewardBoxItems;

	public RectTransform RewardPointParent;

	public RectTransform RewardBoxParent;

	public ButtonCtrl btn_extraReward;

	public ButtonCtrl btn_close;

	public ButtonCtrl btn_info;

	public DxxText txt_title;

	public DxxText txt_resetTime;

	public DxxFitContentText txt_extraDesc;

	public DxxText txt_extraProgress;

	public ButtonCtrl btn_get_reward;

	public DxxText txt_get_reward;

	public Slider slider_extra;

	public DxxText txt_getProgress;

	public Slider[] sliders;

	public DxxText txt_rewardPoints;

	public DxxText txt_pointDesc;

	protected long _lEndTime;

	private TDWeekRewardVO extraRewardVO;

	private List<TDWeekRewardVO> normalRewardVOList;

	private List<TDWeekRewardVO> allRewardVOList;

	private const string TIME_NAME = "DailyTDRewardPanel-TIMER";

	private int timerId;

	private const int SAFE_COUNT = 20;

	private int curSafeCount;

	private static DelegateBridge __Hotfix0_get_WindowID;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_OnOpen;

	private static DelegateBridge __Hotfix0_refreshDataWrapper;

	private static DelegateBridge __Hotfix0_RefreshRewardDataAndUI;

	private static DelegateBridge __Hotfix0_refreshAll;

	private static DelegateBridge __Hotfix0_onUpdateTime;

	private static DelegateBridge __Hotfix0_refreshTxtResetTime;

	private static DelegateBridge __Hotfix0_refreshTxtRewardPoints;

	private static DelegateBridge __Hotfix0_refreshData;

	private static DelegateBridge __Hotfix0_get_ExtraRewardVO;

	private static DelegateBridge __Hotfix0_get_NormalRewardVOList;

	private static DelegateBridge __Hotfix0_get_CurRewardPoints;

	private static DelegateBridge __Hotfix0_get_CurExtraRewardPoints;

	private static DelegateBridge __Hotfix0_get_ExtraRewardDesc;

	private static DelegateBridge __Hotfix0_get_ResetTimeKey;

	private static DelegateBridge __Hotfix0_GetRemainTime;

	private static DelegateBridge __Hotfix0_RequestRewardInfo;

	private static DelegateBridge __Hotfix0_OnClose;

	private static DelegateBridge __Hotfix0_OnHandleNotification;

	private static DelegateBridge __Hotfix0_onGetNormalRewardSuccess;

	private static DelegateBridge __Hotfix0_onGetExtraRewardSuccess;

	private static DelegateBridge __Hotfix0_onGetReward;

	private static DelegateBridge __Hotfix0_onCheckRewardTip;

	private static DelegateBridge __Hotfix0_closeWindow;

	private static DelegateBridge __Hotfix0_android_escape;

	private static DelegateBridge __Hotfix0_onGetExtraReward;

	private static DelegateBridge __Hotfix0_onClickInfo;

	private static DelegateBridge __Hotfix0_get_InfoTitle;

	private static DelegateBridge __Hotfix0_get_Infocontent;

	private static DelegateBridge __Hotfix0_onClickExtraRewardBox;

	private static DelegateBridge __Hotfix0_refreshExtraReward;

	private static DelegateBridge __Hotfix0_IsExtraRewardButtonEnabled;

	private static DelegateBridge __Hotfix0_initNormalReward;

	private static DelegateBridge __Hotfix0_refreshNormalReward;

	private static DelegateBridge __Hotfix0_refreshSliders;

	private static DelegateBridge __Hotfix0_GetRewardPercent;

	private static DelegateBridge __Hotfix0_GetAvailableRewardIds;

	private static DelegateBridge __Hotfix0_IsAllNormalRewardsGot;

	private static DelegateBridge _c__Hotfix0_ctor;

	protected virtual WindowID WindowID => WindowID.WindowID_Invaild;

	protected virtual TDWeekRewardVO ExtraRewardVO => null;

	protected virtual List<TDWeekRewardVO> NormalRewardVOList => null;

	protected virtual int CurRewardPoints => 0;

	protected virtual int CurExtraRewardPoints => 0;

	protected virtual string ExtraRewardDesc => null;

	protected virtual string ResetTimeKey => null;

	protected virtual string InfoTitle => null;

	protected virtual string Infocontent => null;

	public override void OnLanguageChange()
	{
	}

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void refreshDataWrapper()
	{
	}

	protected void RefreshRewardDataAndUI()
	{
	}

	private void refreshAll()
	{
	}

	private void onUpdateTime()
	{
	}

	private void refreshTxtResetTime()
	{
	}

	private void refreshTxtRewardPoints()
	{
	}

	private void refreshData()
	{
	}

	protected virtual long GetRemainTime(long endTime)
	{
		return 0L;
	}

	protected virtual void RequestRewardInfo(Action successCallback = null, Action failCallback = null)
	{
	}

	protected override void OnClose()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	private void onGetNormalRewardSuccess()
	{
	}

	private void onGetExtraRewardSuccess()
	{
	}

	protected virtual void onGetReward(TDWeekRewardVO rewardVO)
	{
	}

	private void onCheckRewardTip(object vo)
	{
	}

	private void closeWindow()
	{
	}

	private void android_escape()
	{
	}

	protected virtual void onGetExtraReward()
	{
	}

	private void onClickInfo()
	{
	}

	private void onClickExtraRewardBox()
	{
	}

	protected void refreshExtraReward()
	{
	}

	protected virtual bool IsExtraRewardButtonEnabled(TDWeekRewardVO rewardVO)
	{
		return false;
	}

	private void initNormalReward()
	{
	}

	protected void refreshNormalReward()
	{
	}

	private void refreshSliders()
	{
	}

	private float GetRewardPercent(int rewardId)
	{
		return 0f;
	}

	private List<int> GetAvailableRewardIds()
	{
		return null;
	}

	protected virtual bool IsAllNormalRewardsGot()
	{
		return false;
	}

	private void _003C_003ExLuaBaseProxy_OnInit()
	{
	}

	private void _003C_003ExLuaBaseProxy_OnOpen()
	{
	}

	private void _003C_003ExLuaBaseProxy_OnClose()
	{
	}

	private void _003C_003ExLuaBaseProxy_OnHandleNotification(INotification P0)
	{
	}
}
