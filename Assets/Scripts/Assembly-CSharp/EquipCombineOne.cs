using System;
using DG.Tweening;
using UnityEngine;
using XLua;

public class EquipCombineOne : MonoBehaviour
{
	public enum TabName
	{
		Unknown = 0,
		Combine = 1,
		Melt = 2,
		Break = 3,
		Wish = 4,
		GemCombine = 5,
		DragonCombine = 6,
		Reset = 7
	}

	public enum State
	{
		Default = 0,
		Main = 1,
		Vice = 2,
		Invalid = 3,
		Locked = 4,
		Suggest = 5
	}

	public DOTweenAnimation child_ani;

	public ButtonCtrl mButton;

	public GameObject equiparent;

	public GameObject mLock;

	public GameObject mChoose_First;

	public GameObject mChoose_Second;

	public GameObject mChoose_Yellow;

	public Action<EquipCombineOne> OnButtonClick;

	private int m_nIndex;

	private EquipOneCtrl mEquip;

	private State currentState;

	private LocalUnityObjctPool mEquipOnePool;

	private TabName tabName;

	private static DelegateBridge __Hotfix0_get_mChoose;

	private static DelegateBridge __Hotfix0_set_mChoose;

	private static DelegateBridge __Hotfix0_get_Index;

	private static DelegateBridge __Hotfix0_set_Index;

	private static DelegateBridge __Hotfix0_get_mData;

	private static DelegateBridge __Hotfix0_set_mData;

	private static DelegateBridge __Hotfix0_get_choosed;

	private static DelegateBridge __Hotfix0_set_choosed;

	private static DelegateBridge __Hotfix0_Awake;

	private static DelegateBridge __Hotfix0_Init;

	private static DelegateBridge __Hotfix1_Init;

	private static DelegateBridge __Hotfix0_SetLock;

	private static DelegateBridge __Hotfix0_PlayAni;

	private static DelegateBridge __Hotfix0_SetChoose;

	private static DelegateBridge __Hotfix0_SetState;

	private static DelegateBridge __Hotfix0_SetButtonEnable;

	private static DelegateBridge __Hotfix0_setChoosed;

	private static DelegateBridge __Hotfix0_hideWishRedPoint;

	private static DelegateBridge __Hotfix0_setRedPointShowORHide;

	private static DelegateBridge __Hotfix0_Close;

	private static DelegateBridge _c__Hotfix0_ctor;

	public EquipCombineChooseOne mChoose { get; private set; }

	public int Index
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public LocalSave.EquipOne mData { get; private set; }

	public bool choosed { get; set; }

	private void Awake()
	{
	}

	public void Init(int index, LocalUnityObjctPool pool, LocalSave.EquipOne one, TabName name = TabName.Unknown)
	{
	}

	public void Init(int index, LocalSave.EquipOne one, TabName name = TabName.Unknown)
	{
	}

	public void SetLock(bool value)
	{
	}

	public void PlayAni(bool value)
	{
	}

	public void SetChoose(EquipCombineChooseOne one)
	{
	}

	public void SetState(State state, bool fromInit = false)
	{
	}

	public void SetButtonEnable(bool value)
	{
	}

	public void setChoosed(bool choose)
	{
	}

	public void hideWishRedPoint()
	{
	}

	public void setRedPointShowORHide(bool show)
	{
	}

	public void Close()
	{
	}
}
