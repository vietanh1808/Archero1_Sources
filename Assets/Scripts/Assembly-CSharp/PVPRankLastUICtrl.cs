using System.Collections.Generic;
using PureMVC.Interfaces;
using TableTool;
using UnityEngine;

public class PVPRankLastUICtrl : MediatorCtrlBase
{
	public DxxText Text_Title;

	public DxxText Text_Stage;

	public DxxText Text_Time;

	public ButtonCtrl Button_Close;

	public GameObject Window_Info;

	public GameObject BottomBG;

	public PVPRankInfinity mInfinity;

	public ScrollRectBase mScrollRect;

	public GameObject copyone;

	public GameObject middle;

	public PVPPropBoxRewardCountInformation m_infomation;

	private int height;

	private int LineCount;

	private int BottomHeight;

	private MutiCachePool<RankItemCell> mCachePool;

	private List<PVPRankData> mList;

	private List<RankItemCell> mItemList;

	private int myRank;

	private int season;

	public RectTransform window;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
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

	public override void OnLanguageChange()
	{
	}

	public void initUI()
	{
	}

	private void openUI()
	{
	}

	private void UpdateChildCallBack(int index, RankItemCell one)
	{
	}

	private void update_scroll_height()
	{
	}

	private void android_escape()
	{
	}

	private bool showMe()
	{
		return false;
	}

	private void boxItemClick(Vector3 pos, List<Drop_DropModel.DropData> list)
	{
	}

	protected override void OnDeInit()
	{
	}
}
