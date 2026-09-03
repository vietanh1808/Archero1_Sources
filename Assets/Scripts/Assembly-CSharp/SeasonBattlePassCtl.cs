using System.Collections.Generic;
using GameProtocol;
using PureMVC.Interfaces;
using SeasonBattlePass;
using UnityEngine;
using UnityEngine.UI;

public class SeasonBattlePassCtl : MediatorCtrlBase
{
	[Header("模板")]
	public GameObject itemTemp;

	public GameObject lineTemp;

	public GameObject endTemp;

	[Header("ListView")]
	public RectTransform listView;

	public RectTransform viewPort;

	[Header("主界面")]
	public Text titleText;

	public Text talentContent;

	public Text talentLevel;

	[Header("按钮")]
	public Text buyBtnName;

	public Text buyBtnName2;

	public ButtonCtrl buyBtn;

	public ButtonCtrl closeButton;

	public GameObject IconPay;

	public Text IconPayText;

	public Text freeText;

	[Header("时间")]
	public RectTransform timeTrans;

	public Text timeContent;

	public Image lockArrow;

	public Image lockTime;

	[Header("VIP")]
	private Queue<SeasonBattlePassItemBase> itemCache;

	private List<SeasonBattlePassItemBase> showList;

	private List<SeasonBattlePassItemDataBase> itemDatalist;

	private SeasonBattlePassItemBase lineItem;

	private SeasonBattlePassEndItem endItem;

	private CRespPveBattlepass battlePassInfo;

	private bool isOpen;

	private float uiHeight;

	protected override void OnInit()
	{
	}

	public void AddItem(SeasonBattlePassItemBase pItem)
	{
	}

	public SeasonBattlePassItemBase GetItem()
	{
		return null;
	}

	public void AddCache(SeasonBattlePassItemBase pItem)
	{
	}

	private void ResetUI()
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

	public override void OnHandleNotification(INotification notification)
	{
	}

	private bool GetAllRewardGot()
	{
		return false;
	}

	private void RestEndBox()
	{
	}

	private void RestList()
	{
	}

	private void InitList(CRespPveBattlepass d)
	{
	}

	private void MoveViewToItem(float pos, float start, float end)
	{
	}

	private void OnBuyClick()
	{
	}

	private void Update()
	{
	}

	private void UpdateListItem(Vector2 pos)
	{
	}

	private Vector2 GetMinMax(SeasonBattlePassItemDataBase item, Vector3 parentPos, float H)
	{
		return default;
	}

	private Rect WorldRect(RectTransform rectTrans)
	{
		return default;
	}
}
