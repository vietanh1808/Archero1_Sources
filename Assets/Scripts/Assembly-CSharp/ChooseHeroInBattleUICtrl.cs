using System.Collections.Generic;
using PureMVC.Interfaces;
using TableTool;
using UnityEngine;

public class ChooseHeroInBattleUICtrl : MediatorCtrlBase
{
	public DxxText mTitleText;

	public DxxText Text_Times;

	public ScrollRectBase mScrollRect;

	public RectTransform mContent;

	public GameObject heroCardCache;

	public HeroCardOneInBattleCtrl mCopyCard;

	private LocalUnityObjctPool heroCardPool;

	private List<HeroCardOneInBattleCtrl> heroCardList;

	private List<PlayerCharacter_Character> m_aryDatas;

	public ButtonCtrl mBtnGameOver;

	public DxxText Text_GameOver;

	private ChooseHeroInBattleProxy.Transfer mTransfer;

	private List<int> mHeroUseList;

	private bool m_bMultiTouchBackup;

	protected override void OnInit()
	{
	}

	private void init_herolist()
	{
	}

	private void InitHeroCardInfo()
	{
	}

	private void InitHeroCard()
	{
	}

	protected override void OnOpen()
	{
	}

	public void UpdateHeroIcon(bool ifSuccess)
	{
	}

	private void OnClickSelect(HeroCardInfo CardData)
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	protected override void OnClose()
	{
	}

	private void DeInitHeroCard()
	{
	}

	public override void OnLanguageChange()
	{
	}
}
