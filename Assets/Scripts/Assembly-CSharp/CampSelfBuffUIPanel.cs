using System.Collections.Generic;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class CampSelfBuffUIPanel : MediatorCtrlBase
{
	[SerializeField]
	private RectTransform _scrollRect;

	public RectTransform buffParent;

	public RectTransform rankParent;

	public DxxText Title;

	public DxxText Text_Status;

	public ButtonCtrl BtnClose;

	public ButtonCtrl Button_Info;

	public DxxFitContentText Text_Desc;

	public DxxText Text_RankTips;

	public DxxText Text_RankTitle;

	public CampBuffItem buffItem;

	public CampRankItemCell rankItem;

	public CampRankItemCell myRankItem;

	public RectTransform rect_Content;

	public RectTransform rect_Buff;

	public LayoutElement rank_Layout;

	public ScrollRect scroll;

	public GameObject PopReward;

	public RectTransform PopContainer;

	public GameObject cpProp;

	private LocalUnityObjctPool _pool;

	private List<CampRankItemData> _rankData;

	private CampRankItemData _myRankData;

	private int _buildID;

	private bool _isTileOccupied;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void initUI()
	{
	}

	private void RefreshRankTips()
	{
	}

	private void RefreshRankList()
	{
	}

	private void RefreshBuffList()
	{
	}

	protected override void OnClose()
	{
	}

	public override object OnGetEvent(string eventName)
	{
		return null;
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	public void showPopReward(CampRankRewardPos crrp)
	{
	}

	public override void OnLanguageChange()
	{
	}

	private void Esc()
	{
	}

	private void onButtonClose()
	{
	}

	private void onButtonInfo()
	{
	}

	public void onButtonClickPopReward()
	{
	}
}
