using System;
using System.Collections.Generic;
using Dxx.Util;
using PureMVC.Interfaces;
using UnityEngine;

public class GemCombineCtrl : MonoBehaviour
{
	private GemCombineData ccbd;

	public ButtonCtrl Button_Close;

	public GameObject copyitems;

	public GameObject copyone;

	public ScrollRectBase mScrollRect;

	public EquipCombineInfinity mInfinity;

	public ButtonCtrl Button_Combine;

	public DxxText Text_Combine;

	public GameObject mMaskparent;

	private int leftpadding;

	private int width;

	private int height;

	private int LineCount;

	private int BottomHeight;

	private Vector2 scrollsize;

	private EquipCombineOne mPlayOne;

	private EquipCombineOne mChoose;

	private LocalSave.EquipOne mChooseEquip;

	private LocalUnityObjctPool mPool;

	private MutiCachePool<EquipCombineOne> mCachePool;

	private List<LocalSave.EquipOne> mList;

	private List<EquipCombineOne> mItemList;

	private SequencePool mSeqPool;

	public EquipOneCtrl leftGem;

	public EquipOneCtrl[] rightGems;

	public DxxText diamondText;

	public DxxText descText;

	public GameObject Effect_Fire;

	private bool bGoldBuy;

	public GameObject singleMode;

	public GameObject batchMode;

	[HideInInspector]
	public int batchMaxLevel;

	private LocalUnityObjctPool mEquipOnePool;

	public RectTransform batchContainer;

	public GameObject batchItem;

	public HashSet<int> chooseList;

	private int currentNeedCoin;

	public ButtonCtrl Button_KeyAll;

	public DxxText Text_KeyAll;

	public GemCombineKeyAll keyAllWindow;

	private bool isHaveKeyAllUse;

	private bool IsCombineModeSingle => false;

	public void OnInit()
	{
	}

	public void initUI(GemCombineData data)
	{
	}

	private void checkAutoPut()
	{
	}

	private void UpdateChildCallBack(int index, EquipCombineOne one)
	{
	}

	private void show_combine_button(bool value)
	{
	}

	private void update_scroll_height()
	{
	}

	public void OnButtonTopIcon(int index)
	{
	}

	private void OnClickOne(EquipCombineOne one)
	{
	}

	public void chooseCancel(int gemid)
	{
	}

	private void checkBottomState()
	{
	}

	private void checkBottomState(EquipCombineOne one)
	{
	}

	private void checkButtonCombine()
	{
	}

	private void setDiamondText(int coin)
	{
	}

	private bool canCombine(int mainid)
	{
		return false;
	}

	private int getCombineNeedCount(int mainid)
	{
		return 0;
	}

	private void android_escape()
	{
	}

	public void OnClose()
	{
	}

	public object OnGetEvent(string eventName)
	{
		return null;
	}

	public void OnHandleNotification(INotification notification)
	{
	}

	public void OnLanguageChange()
	{
	}

	private void PlayMove(int index, EquipCombineOne one, Action callback)
	{
	}

	private void sendRequest()
	{
	}

	public void resetCombineMode()
	{
	}

	public void onButtonCombine()
	{
	}

	private bool haveMaxBatchLevel()
	{
		return false;
	}

	private void OnDestroy()
	{
	}

	public void setKeyAllChooseList()
	{
	}

	public int GetChoosedCoinCost()
	{
		return 0;
	}

	public void onButtonKeyAll()
	{
	}

	public void onButtonKeyAllClose()
	{
	}

	public void Combine_KeyAll()
	{
	}

	public bool isHaveKeyAll()
	{
		return false;
	}
}
