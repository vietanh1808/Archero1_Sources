using System;
using Dxx.Util;
using PureMVC.Interfaces;
using UnityEngine;

public class DSMShootItem : MonoBehaviour
{
	[SerializeField]
	private new DxxText name;

	[SerializeField]
	private ButtonCtrl addBtn;

	[SerializeField]
	private ButtonCtrl reduceBtn;

	[SerializeField]
	private ButtonCtrl buyBtn;

	[SerializeField]
	private DxxText showNum;

	[SerializeField]
	private DxxText attackNum;

	[SerializeField]
	private PropOneEquip prop;

	[SerializeField]
	private DxxText attackName;

	private SailingMCannonType type;

	private int curSelectNum;

	private SequencePool seqPool;

	private float curChangeSpeed;

	private float accumulatedTime;

	private bool isAddLongPress;

	private Action<SailingMCannonType, int> OnMCannonChanged;

	private SailingMonsterCommingMgr SMMgr => null;

	private int CurHaveCount => 0;

	private CurrencyType CurCurrencyType => CurrencyType.None;

	public void Refresh(SailingMCannonType mType, Action<SailingMCannonType, int> changedCallback = null, Action onClickBuyBtn = null)
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
