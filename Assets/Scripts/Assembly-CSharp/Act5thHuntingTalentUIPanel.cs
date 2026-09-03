using System.Collections.Generic;
using PureMVC.Interfaces;
using UnityEngine;

public class Act5thHuntingTalentUIPanel : MediatorCtrlBase
{
	[SerializeField]
	private DxxText title;

	[SerializeField]
	private DxxText upgradeBtnName;

	[SerializeField]
	private DxxText curUpgradeCost;

	[SerializeField]
	private DxxText maxLevelName;

	[SerializeField]
	private DxxText geneFragmentCount;

	[SerializeField]
	private ButtonCtrl closeBtn;

	[SerializeField]
	private ButtonCtrl upgradeBtn;

	[SerializeField]
	private Act5thHuntingTalentItem talentItemItem;

	[SerializeField]
	private GameObject unMaxLevelStatus;

	[SerializeField]
	private GameObject maxLevelStatus;

	[SerializeField]
	private Transform talentItemParent;

	[SerializeField]
	private Act5thHuntingTalentRandomAni randomAni;

	private LocalUnityObjctPool pool;

	private List<Act5thHuntingTalentItem> createItem;

	private bool isRequesting;

	private Act5thHuntingManager HuntingManager => null;

	private Act5thHuntingBaseData HuntingBaseData => null;

	private Act5thHuntingTalentData HuntingTalentData => null;

	private void InitPool()
	{
	}

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	public override void OnLanguageChange()
	{
	}

	private void Refresh()
	{
	}

	private void RefreshItem()
	{
	}

	private void RefreshText()
	{
	}

	private void RefreshStatus()
	{
	}

	private void ClickCloseBtn()
	{
	}

	private void ClickUpgradeBtn()
	{
	}

	private void RequestUpgrade(int cost)
	{
	}

	private void Esc()
	{
	}
}
