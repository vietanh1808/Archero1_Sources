using System.Collections.Generic;
using PureMVC.Interfaces;
using TableTool;
using UnityEngine;
using UnityEngine.UI;

public class SailingMilitaryRankUICtrl : MediatorCtrlBase
{
	private class AttributeModel
	{
		public ShipBattle_Military _data;

		public Goods_goods.GoodData _goodData;
	}

	[SerializeField]
	private ButtonCtrl _closeBtn;

	[SerializeField]
	private ButtonCtrl _btnInfo;

	[SerializeField]
	private ButtonCtrl _upgradeBtn;

	[SerializeField]
	private DxxText _textTitle;

	[SerializeField]
	private HeadItem _head;

	[SerializeField]
	private Image _imgMilitaryRank;

	[SerializeField]
	private DxxText _textMilitaryRank;

	[SerializeField]
	private DxxText _textUpgrade;

	[SerializeField]
	private Image _imgProgress;

	[SerializeField]
	private DxxText _textProgress;

	[SerializeField]
	private DxxText _textShipAttrTitle;

	[SerializeField]
	private DxxText _textPrivilege;

	[SerializeField]
	private SailingMilitaryRankTip _sailingMilitaryRankTip;

	[SerializeField]
	private SailingMilitaryRankInfinity _infinity;

	[SerializeField]
	private ScrollRectBase _scrollbase;

	[SerializeField]
	private RectTransform _shipAttrParent;

	[SerializeField]
	private SailingMilitaryRankShipAttr _copyone;

	[SerializeField]
	private SailingMilitaryRankUpgradeUICtrl _sailingMilitaryRankUpgradeUICtrl;

	private LocalUnityObjctPool _pool;

	private IList<ShipBattle_Military> _datas;

	public bool IsMaxLevel => false;

	protected override void OnInit()
	{
	}

	private void CloseUI()
	{
	}

	protected override void OnOpen()
	{
	}

	private void UpdateUI()
	{
	}

	private void UpdateExpSlider(int level, int exp)
	{
	}

	protected override void OnClose()
	{
	}

	public override void OnLanguageChange()
	{
	}

	private void OnClickUpgradeBtn()
	{
	}

	private void UpdateChildCallBack(int index, SailingMilitaryRankPrivilege one)
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}
}
