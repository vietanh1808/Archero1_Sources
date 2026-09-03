using System;
using System.Collections.Generic;
using Dxx.Util;
using PureMVC.Interfaces;
using UnityEngine;

public class EquipMeltDownCtrl : MonoBehaviour
{
	public GameObject titlecombine;

	public ButtonCtrl Button_Close;

	public DxxText Text_Guide;

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

	private bool bLock;

	private EquipCombineOne mPlayOne;

	private EquipCombineOne mChoose;

	private LocalSave.EquipOne mChooseEquip;

	private LocalUnityObjctPool mPool;

	private MutiCachePool<EquipCombineOne> mCachePool;

	private List<LocalSave.EquipOne> mList;

	private List<EquipCombineOne> mItemList;

	private SequencePool mSeqPool;

	private int[] choose;

	private int[] diamonds;

	public EquipOneCtrl[] topEquip;

	public DxxText diamondText;

	public GameObject topObject;

	public DxxText descText;

	public DxxText countText;

	public DxxText endText;

	public DxxText noCountText;

	public DxxText timeText;

	public DxxText discountText;

	public DxxText discountDescText;

	public GameObject discountObject;

	public DxxText Text_BPA;

	public MeltRightItem rightItem;

	public RectTransform middle;

	private LocalUnityObjctPool mEquipOnePool;

	public void OnInit(LocalUnityObjctPool pool)
	{
	}

	public void OnOpen()
	{
	}

	private void InitUI()
	{
	}

	private void setTopText()
	{
	}

	private void UpdateChildCallBack(int index, EquipCombineOne one)
	{
	}

	private void set_guide_info(int index)
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

	private void checkBottomState()
	{
	}

	private void checkBottomState(EquipCombineOne one)
	{
	}

	public void checkMeltButton()
	{
	}

	private void setDiamondText()
	{
	}

	private void checkEquipSame()
	{
	}

	private void android_escape()
	{
	}

	public void OnClose()
	{
	}

	private void CloseItems()
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

	private EquipCombineOne getCombineOne(int index)
	{
		return null;
	}

	private void PlayMove(int index, EquipCombineOne one, Action callback)
	{
	}

	private void OnDestroy()
	{
	}
}
