using Dxx.Util;
using PureMVC.Interfaces;
using UnityEngine;
using XLua;

public class CampTileArrowItem : MonoBehaviour
{
	[SerializeField]
	private new DxxText name;

	[SerializeField]
	private ButtonCtrl addBtn;

	[SerializeField]
	private ButtonCtrl reduceBtn;

	[SerializeField]
	private DxxText showNum;

	[SerializeField]
	private DxxText attackNum;

	[SerializeField]
	private PropOneEquip prop;

	[SerializeField]
	private DxxText attackName;

	private CampTileArrowType type;

	private int curSelectNum;

	private SequencePool seqPool;

	private float curChangeSpeed;

	private float accumulatedTime;

	private bool isAddLongPress;

	private static DelegateBridge __Hotfix0_get_CampTileManager;

	private static DelegateBridge __Hotfix0_get_CurHaveCount;

	private static DelegateBridge __Hotfix0_get_CurCurrencyType;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_RefreshProp;

	private static DelegateBridge __Hotfix0_RefreshShowNum;

	private static DelegateBridge __Hotfix0_RefreshText;

	private static DelegateBridge __Hotfix0_AddClick;

	private static DelegateBridge __Hotfix0_AddOne;

	private static DelegateBridge __Hotfix0_ReduceClick;

	private static DelegateBridge __Hotfix0_ReduceOne;

	private static DelegateBridge __Hotfix0_OnHandleNotification;

	private static DelegateBridge __Hotfix0_AddLongPress;

	private static DelegateBridge __Hotfix0_ReduceLongPress;

	private static DelegateBridge __Hotfix0_LongPress;

	private static DelegateBridge __Hotfix0_CancelLongPress;

	private static DelegateBridge __Hotfix0_Update;

	private static DelegateBridge _c__Hotfix0_ctor;

	private CampTileManager CampTileManager => null;

	private int CurHaveCount => 0;

	private CurrencyType CurCurrencyType => CurrencyType.None;

	public void Refresh(CampTileArrowType type)
	{
	}

	public void RefreshProp()
	{
	}

	public void RefreshShowNum()
	{
	}

	public void RefreshText()
	{
	}

	public void AddClick()
	{
	}

	public void AddOne()
	{
	}

	public void ReduceClick()
	{
	}

	public void ReduceOne()
	{
	}

	public void OnHandleNotification(INotification notification)
	{
	}

	public void AddLongPress()
	{
	}

	public void ReduceLongPress()
	{
	}

	public void LongPress()
	{
	}

	public void CancelLongPress()
	{
	}

	public void Update()
	{
	}
}
