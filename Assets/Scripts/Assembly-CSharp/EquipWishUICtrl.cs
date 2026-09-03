using System;
using System.Collections.Generic;
using Dxx.Util;
using PureMVC.Interfaces;
using UnityEngine;

public class EquipWishUICtrl : MediatorCtrlBase
{
	public GameObject copyone;

	public ScrollRectBase mScrollRect;

	public EquipCombineInfinity mInfinity;

	public GameObject mMaskparent;

	private int height;

	private int LineCount;

	private int BottomHeight;

	private EquipCombineOne mPlayOne;

	private LocalUnityObjctPool mPool;

	private MutiCachePool<EquipCombineOne> mCachePool;

	private List<LocalSave.EquipOne> mList;

	private List<EquipCombineOne> mItemList;

	private SequencePool mSeqPool;

	public ButtonCtrl buttonClose;

	public ButtonCtrl buttonWish;

	public ButtonCtrl buttonTabWish;

	public ButtonCtrl buttonTabReduce;

	public ButtonCtrl buttonPop;

	public ButtonCtrl buttonPopClose;

	public EquipOneCtrl[] topEquip;

	public DxxText Text_Rate;

	public DxxText Text_Title;

	public DxxText Text_Info;

	public DxxText Text_ButtonOK;

	public DxxText Text_ButtonTabWish;

	public DxxText Text_ButtonTabReduce;

	public DxxText Text_PopContent;

	[SerializeField]
	private DxxText Text_BonusTip;

	[SerializeField]
	private DxxText Text_BonusNum;

	[SerializeField]
	private DxxImage imgBgTitle;

	[SerializeField]
	private DxxImage imgTabWish;

	[SerializeField]
	private DxxImage imgTabDream;

	[SerializeField]
	private Sprite spBgWish;

	[SerializeField]
	private Sprite spBgDream;

	[SerializeField]
	private Sprite spTabSelected;

	[SerializeField]
	private Sprite spTabUnselected;

	public GameObject goPopInfo;

	private Dictionary<int, int> chooseIndexDict;

	private Dictionary<int, int> choosePosDict;

	private int maxDisplayRate;

	private int maxDisplayReduce;

	private bool TempClickFlag;

	private bool isReduce;

	private List<int> wishedList;

	private List<int> reducedList;

	private HashSet<int> equipIdsCache;

	private int TotalBox;

	private LocalUnityObjctPool mEquipOnePool;

	protected override void OnInit()
	{
	}

	private void SetTabReduce()
	{
	}

	private void SetTabWish()
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

	public void initUI()
	{
	}

	private void openUI()
	{
	}

	private void ResetUI()
	{
	}

	private void UpdateChildCallBack(int index, EquipCombineOne one)
	{
	}

	private void update_scroll_height()
	{
	}

	public void OnButtonTopIcon(int pos)
	{
	}

	private void OnClickOne(EquipCombineOne one)
	{
	}

	private int getTopEmptyPos()
	{
		return 0;
	}

	private void checkStateBox()
	{
	}

	private void checkStateBoxOne(EquipCombineOne one)
	{
	}

	private void android_escape()
	{
	}

	private EquipCombineOne getCombineOne(int index)
	{
		return null;
	}

	private void PlayMove(int index, EquipCombineOne one, Action callback)
	{
	}

	private string configToJson(ref int empty)
	{
		return null;
	}

	private int getMListIndex(int eid)
	{
		return 0;
	}

	protected override void OnDeInit()
	{
	}
}
