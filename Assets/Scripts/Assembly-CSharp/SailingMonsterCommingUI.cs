using System;
using System.Collections.Generic;
using GameProtocol;
using PureMVC.Interfaces;
using UnityEngine;

public class SailingMonsterCommingUI : MediatorCtrlBase
{
	[SerializeField]
	private DxxText title;

	[SerializeField]
	private DxxText getArrowBtnName;

	[SerializeField]
	private DxxText launchArrowBtnName;

	[SerializeField]
	private Transform arrowItemParent;

	[SerializeField]
	private SailingMonsterCommingMCannonItem arrowItem;

	[SerializeField]
	private ButtonCtrl getArrowBtn;

	[SerializeField]
	private ButtonCtrl launchMCannonBtn;

	[SerializeField]
	private ButtonCtrl infoBtn;

	[SerializeField]
	private ButtonCtrl close;

	[SerializeField]
	private SailingMonsterMCannonBuyUIPanel buyUIPanel;

	[SerializeField]
	private ButtonCtrl closeMask;

	[SerializeField]
	private SailingRankShowItem rankShowItem;

	[SerializeField]
	private SailingMonsterCommingDamageBox damageBox;

	[SerializeField]
	private DxxText AllDamage;

	[SerializeField]
	private DxxFitContentText AllDamageName;

	private List<SailingMonsterCommingMCannonItem> createSailingMCannonItem;

	private SailingMonsterMCannonTransData data;

	private LocalUnityObjctPool outputItemBtnPool;

	private int selectNormalMCannonCount;

	private int selectPremiumMCannonCount;

	private SailingMonsterCommingMgr SmMgr => null;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose()
	{
	}

	public override void OnLanguageChange()
	{
	}

	public void RefreshPanel()
	{
	}

	public void InitObjectPool()
	{
	}

	public void RefreshItem()
	{
	}

	public void OnMCannonChanged(SailingMCannonType type, int count)
	{
	}

	private void CheckData(Action success)
	{
	}

	private void GetArrowClick()
	{
	}

	public void LaunchMCannonClick()
	{
	}

	private void SendPlayAni(CRespShipBattleSeasonFire response, int oldLevel, List<SailingMonsterMCannonDamageData> damageData)
	{
	}

	private void InfoClick()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	private void Esc()
	{
	}
}
