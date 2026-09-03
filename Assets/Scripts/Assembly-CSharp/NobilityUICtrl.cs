using System.Collections.Generic;
using GameProtocol;
using PureMVC.Interfaces;
using TableTool;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class NobilityUICtrl : MediatorCtrlBase
{
	[Header("我的排名信息")]
	[SerializeField]
	private GameObject mSelfInfoContainer;

	[SerializeField]
	private DxxText mTextRank;

	[SerializeField]
	private Image mImgCup;

	[SerializeField]
	private DxxText mTextCupRank;

	[SerializeField]
	private Image mImgHead;

	[SerializeField]
	private Image mImgFrame;

	[SerializeField]
	private DxxText mTextName;

	[SerializeField]
	private DxxText mTextNobility;

	[SerializeField]
	private DxxText mTextHonor;

	[Header("排行榜列表")]
	[SerializeField]
	private NobilityInfinity mNobilityInfinity;

	[SerializeField]
	private ScrollRectBase mScrollbase;

	[SerializeField]
	private DxxText mTextNoRankData;

	[Header("爵位信息")]
	[SerializeField]
	private Image mImgNobilityIcon;

	[SerializeField]
	private DxxText mTextNobility2;

	[SerializeField]
	private Image mImgProgressBg;

	[SerializeField]
	private Image mImgProgress;

	[SerializeField]
	private DxxText mTextProgress;

	[SerializeField]
	private ButtonCtrl mBtnUpgrade;

	[SerializeField]
	private DxxText mTextUpgrade;

	[SerializeField]
	private Button mBtnBox;

	[SerializeField]
	private Image mImgBox;

	[SerializeField]
	private DxxText mTextMaxLevel;

	[SerializeField]
	private Image mImgOver;

	[Header("宝箱Tips")]
	[SerializeField]
	private GameObject mGoTips;

	[SerializeField]
	private DxxText mTextTipsTitle;

	[SerializeField]
	private RectTransform mRtContent;

	[SerializeField]
	private ButtonCtrl mBtnClose;

	[SerializeField]
	private ButtonCtrl mBtnTips;

	[SerializeField]
	private DxxText mTextTitle;

	[SerializeField]
	private GameObject mGoRuleUIParent;

	private GameObject mNobilityRuleUI;

	private LocalUnityObjctPool mPool;

	private List<CCampRank> m_arrayRanks;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_OnOpen;

	private static DelegateBridge __Hotfix0_UpdateNobilityUI;

	private static DelegateBridge __Hotfix0_UpdateExp;

	private static DelegateBridge __Hotfix0_get_Datas;

	private static DelegateBridge __Hotfix0_get_CanReward;

	private static DelegateBridge __Hotfix0_OnClose;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_OnHandleNotification;

	private static DelegateBridge __Hotfix0_UpdateNobilityText;

	private static DelegateBridge __Hotfix0_UpdateChildCallBack;

	private static DelegateBridge __Hotfix0_OnClickBox;

	private static DelegateBridge __Hotfix0_UpdateBoxReward;

	private static DelegateBridge __Hotfix0_OnClickClose;

	private static DelegateBridge __Hotfix0_OnClickUpgrade;

	private static DelegateBridge __Hotfix0_HandleErrorCode;

	private static DelegateBridge __Hotfix0_OnClickTips;

	private static DelegateBridge _c__Hotfix0_ctor;

	private SLG_NobilityLevel[] Datas => null;

	private bool CanReward => false;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void UpdateNobilityUI()
	{
	}

	private void UpdateExp()
	{
	}

	protected override void OnClose()
	{
	}

	public override void OnLanguageChange()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	private void UpdateNobilityText(LanguageManager language)
	{
	}

	private void UpdateChildCallBack(int index, NobilityItemCtrl one)
	{
	}

	public void OnClickBox()
	{
	}

	private void UpdateBoxReward(SLG_NobilityLevel data)
	{
	}

	private void OnClickClose()
	{
	}

	private void OnClickUpgrade()
	{
	}

	private void HandleErrorCode(int code)
	{
	}

	private void OnClickTips()
	{
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
