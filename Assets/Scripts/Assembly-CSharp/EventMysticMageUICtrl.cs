using System.Collections.Generic;
using Dxx.Util;
using PureMVC.Interfaces;
using UnityEngine;

public class EventMysticMageUICtrl : MediatorCtrlBase
{
	public DxxText Text_Title;

	public DxxText Text_Attribute;

	public DxxText Text_Content;

	public DxxText Text_RemainTimes;

	public DxxImage Image_Icon;

	public GameObject mBtnContainer;

	public ButtonAdControl mButtonAd;

	public ButtonCtrl mButtonFree;

	public DxxText mBtnFreeText;

	public ButtonCtrl mButtonDiamond;

	public DxxText mBtnDiamondText;

	public ButtonCtrl mButtonBPFree;

	public DxxText mBtnBPFreeText;

	public ButtonCtrl mBuffButton;

	public ChooseBuffButtonCtrl mChooseBuffButton;

	public ChooseBuffColumnCtrl mBuffColumn;

	public List<ChooseBuffOneCtrl> chooseones;

	public DxxText mBuffNameText;

	public ButtonCtrl mAcceptButton;

	public DxxText Text_Accept;

	private SequencePool mSeqPool;

	private ADSource source;

	private int m_nRefreshBuffCount;

	private int m_nTotalRefreshBuffCount;

	private int m_nTotalFreeRefreshBuffCount;

	private int m_nTotalAdRefreshBuffCount;

	private int m_nTotalDiamondRefreshBuffCount;

	private List<int> m_listRefreshPrices;

	private int m_nAdUseCount;

	private bool bFirstRefresh;

	private List<int> mAllIcons;

	private int RandomSkillCount;

	private bool isDiamondRefresh;

	private List<int> m_listAbandonSkills;

	protected override void OnInit()
	{
	}

	private void init_allicons()
	{
	}

	private bool check_icon(int icon)
	{
		return false;
	}

	private int get_index_in_icons(int skillid)
	{
		return 0;
	}

	private List<int> get_icons_result(int skillid)
	{
		return null;
	}

	private void refreshBuffUI()
	{
	}

	private int get_current_need_diamond()
	{
		return 0;
	}

	private void refreshBuffList()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose()
	{
	}

	public override object OnGetEvent(string eventName)
	{
		return null;
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	public override void OnLanguageChange()
	{
	}
}
