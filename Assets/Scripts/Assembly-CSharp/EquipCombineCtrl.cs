using System;
using System.Collections.Generic;
using Dxx.Net;
using Dxx.Util;
using GameProtocol;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class EquipCombineCtrl : MonoBehaviour
{
	public ButtonCtrl Button_Close;

	public DxxText Text_Guide;

	public DxxText Text_BatchTitle;

	public GameObject copyitems;

	public GameObject copyone;

	public ScrollRectBase mScrollRect;

	public EquipCombineInfinity mInfinity;

	public EquipCombineParent mCombineParent;

	public ButtonCtrl Button_Combine;

	public DxxText Text_Combine;

	public RectTransform middle;

	private readonly List<CombineMaterialDataGroup> _selectedDataGroups;

	public GameObject mMaskparent;

	private int leftpadding;

	private int width;

	private int height;

	private int LineCount;

	private int BottomHeight;

	private Vector2 scrollsize;

	private bool bLock;

	private EquipCombineOne mPlayOne;

	private LocalUnityObjctPool mPool;

	private LocalUnityObjctPool mEquipOnePool;

	private MutiCachePool<EquipCombineOne> mCachePool;

	private List<LocalSave.EquipOne> mList;

	private List<EquipCombineOne> mItemList;

	private SequencePool mSeqPool;

	private Dictionary<string, CombineMaterialDataGroup> selectedUidsToGroup;

	public ButtonCtrl Button_Cast;

	public DxxText Text_Cast;

	public NewFlagItem equipCastNewItem;

	private List<LocalSave.EquipOne> equipBasicList;

	public ButtonCtrl Button_KeyAll;

	public DxxText Text_KeyAll;

	public EquipCombineKeyAll keyAllWindow;

	private bool isHaveEquipKeyAllUse;

	public ButtonCtrl Button_Choose;

	public DxxText Text_ButtonChoose;

	public GameObject Panel_Choose;

	public Color color_chooseNormal;

	public Color color_chooseFocus;

	public Image[] Image_ChooseBG;

	public DxxText[] Text_ChooseQuality;

	private int ChooseQualityIndex;

	private static DelegateBridge __Hotfix0_isBatchCombining;

	private static DelegateBridge __Hotfix0_get_selectedNothing;

	private static DelegateBridge __Hotfix0_get_selectedOneGroup;

	private static DelegateBridge __Hotfix0_get_selectedDataGroups;

	private static DelegateBridge __Hotfix0_get_batchCombineResult;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_OnOpen;

	private static DelegateBridge __Hotfix0_OnClose;

	private static DelegateBridge __Hotfix0_CloseItems;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_OnGetEvent;

	private static DelegateBridge __Hotfix0_OnHandleNotification;

	private static DelegateBridge __Hotfix0_InitUI;

	private static DelegateBridge __Hotfix0_UpdateChildCallBack;

	private static DelegateBridge __Hotfix0_SetCombineButtonActivity;

	private static DelegateBridge __Hotfix0_OnRemoveMaterialAtIndex;

	private static DelegateBridge __Hotfix0_SetGuideInfo;

	private static DelegateBridge __Hotfix0_UpdateScrollHeight;

	private static DelegateBridge __Hotfix0_PlayAnimCombine;

	private static DelegateBridge __Hotfix0_UpdateAllItems;

	private static DelegateBridge __Hotfix0_UpdateItemOne;

	private static DelegateBridge __Hotfix0_FreshEquipMList;

	private static DelegateBridge __Hotfix0_ClearCachedSelectionData;

	private static DelegateBridge __Hotfix0_OnClickOne;

	private static DelegateBridge __Hotfix0_SelectItem;

	private static DelegateBridge __Hotfix0_DeselectItem;

	private static DelegateBridge __Hotfix0_UpdateAllUI;

	private static DelegateBridge __Hotfix0_UpdateGuideInfo;

	private static DelegateBridge __Hotfix0_ExecuteCombine;

	private static DelegateBridge __Hotfix0_Combine_2thOK;

	private static DelegateBridge __Hotfix0_OnBatchCombineSucceed;

	private static DelegateBridge __Hotfix0_OnCombineSucceed;

	private static DelegateBridge __Hotfix0_OnCombineFail;

	private static DelegateBridge __Hotfix0_android_escape;

	private static DelegateBridge __Hotfix0_OnDestroy;

	private static DelegateBridge __Hotfix0_isGroupEmpty;

	private static DelegateBridge __Hotfix0_isGroupFull;

	private static DelegateBridge __Hotfix0_isGroupStateNormal;

	private static DelegateBridge __Hotfix0_GetLastGroupOne;

	private static DelegateBridge __Hotfix0_createBasicList;

	private static DelegateBridge __Hotfix0_createShowList;

	private static DelegateBridge __Hotfix0_GetItemState;

	private static DelegateBridge __Hotfix0_isSelectedInGroup;

	private static DelegateBridge __Hotfix0_getExtraMatUseCount;

	private static DelegateBridge __Hotfix0_isEnoughExtraMat;

	private static DelegateBridge __Hotfix0_get_isOpenBatch;

	private static DelegateBridge __Hotfix0_onButtonKeyAll;

	private static DelegateBridge __Hotfix0_Combine_KeyAll;

	private static DelegateBridge __Hotfix0_GetGroupOneCanJoin;

	private static DelegateBridge __Hotfix0_isHaveEquipKeyAll;

	private static DelegateBridge __Hotfix0_RemoveDataGroupAtIndex;

	private static DelegateBridge __Hotfix0_openChoosePanel;

	private static DelegateBridge __Hotfix0_onButtonChooseQuality;

	private static DelegateBridge _c__Hotfix0_ctor;

	public bool selectedNothing => false;

	public bool selectedOneGroup => false;

	public List<CombineMaterialDataGroup> selectedDataGroups => null;

	public List<LocalSave.EquipOne> batchCombineResult => null;

	public bool isOpenBatch => false;

	private bool isBatchCombining()
	{
		return false;
	}

	public void OnInit(LocalUnityObjctPool pool)
	{
	}

	public void OnOpen()
	{
	}

	public void OnClose()
	{
	}

	private void CloseItems()
	{
	}

	public void OnLanguageChange()
	{
	}

	public object OnGetEvent(string eventName)
	{
		return null;
	}

	public void OnHandleNotification(INotification notification)
	{
	}

	private void InitUI()
	{
	}

	private void UpdateChildCallBack(int index, EquipCombineOne one)
	{
	}

	private void SetCombineButtonActivity(bool value)
	{
	}

	private void OnRemoveMaterialAtIndex(int index)
	{
	}

	private void SetGuideInfo(int index)
	{
	}

	private void UpdateScrollHeight()
	{
	}

	private void PlayAnimCombine(int index, EquipCombineOne one, Action callback)
	{
	}

	private void UpdateAllItems()
	{
	}

	private void UpdateItemOne(EquipCombineOne one, bool forceLock = false)
	{
	}

	public void FreshEquipMList()
	{
	}

	private void ClearCachedSelectionData()
	{
	}

	private void OnClickOne(EquipCombineOne one)
	{
	}

	private bool SelectItem(LocalSave.EquipOne oneData, out bool needRefreshCombineParent, bool playAnim = true, bool hasLimit = true)
	{
		needRefreshCombineParent = default;
		return false;
	}

	private void DeselectItem(LocalSave.EquipOne oneData, bool removeAllInGroup = true)
	{
	}

	private void UpdateAllUI(bool updateCombineParent)
	{
	}

	private void UpdateGuideInfo()
	{
	}

	private void ExecuteCombine()
	{
	}

	private void Combine_2thOK()
	{
	}

	private void OnBatchCombineSucceed(CRespEquipBatchComposite responseData, CReqEquipBatchComposite data)
	{
	}

	private void OnCombineSucceed(CRespItemPacket responseData, CEquipCompositeTrans data, int nTargetEquipId)
	{
	}

	private static void OnCombineFail(NetResponse response)
	{
	}

	private void android_escape()
	{
	}

	private void OnDestroy()
	{
	}

	private bool isGroupEmpty()
	{
		return false;
	}

	public bool isGroupFull()
	{
		return false;
	}

	private bool isGroupStateNormal()
	{
		return false;
	}

	public CombineMaterialDataGroup GetLastGroupOne()
	{
		return null;
	}

	private void createBasicList()
	{
	}

	private void createShowList()
	{
	}

	private EquipCombineOne.State GetItemState(LocalSave.EquipOne one, bool forceLock = false)
	{
		return EquipCombineOne.State.Default;
	}

	private bool isSelectedInGroup(LocalSave.EquipOne one, ref CombineMaterialDataGroup group, ref int index)
	{
		return false;
	}

	private Dictionary<int, int> getExtraMatUseCount()
	{
		return null;
	}

	public bool isEnoughExtraMat()
	{
		return false;
	}

	public void onButtonKeyAll()
	{
	}

	public void Combine_KeyAll()
	{
	}

	private CombineMaterialDataGroup GetGroupOneCanJoin(LocalSave.EquipOne e)
	{
		return null;
	}

	public bool isHaveEquipKeyAll()
	{
		return false;
	}

	private void RemoveDataGroupAtIndex(int index)
	{
	}

	private void openChoosePanel()
	{
	}

	public void onButtonChooseQuality(int index)
	{
	}
}
