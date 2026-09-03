using System;
using System.Collections.Generic;
using DG.Tweening;
using PureMVC.Interfaces;
using UnityEngine;

public class CardLevelUpUICtrl : MediatorCtrlBase
{
	public DxxText Text_CardName;

	public TapToCloseCtrl mCloseCtrl;

	public Transform CardParent;

	public Transform AttributeParent;

	private CardOneCtrl _cardctrl;

	private List<CardLevelUpAttCtrl> mAttList;

	private List<CardLevelUpAtt2Ctrl> mAtt2List;

	private new LocalSave.CardOne mData;

	private Action onEventClose;

	private CardOneCtrl mCardCtrl => null;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void UpdateUI()
	{
	}

	private Sequence UpdateAttribute()
	{
		return null;
	}

	private CardLevelUpAttCtrl GetAttOne(int index)
	{
		return null;
	}

	private CardLevelUpAtt2Ctrl GetAtt2One(int index)
	{
		return null;
	}

	private void OnClickClose()
	{
	}

	protected override void OnClose()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	public override object OnGetEvent(string eventName)
	{
		return null;
	}

	public override void OnLanguageChange()
	{
	}
}
