using System.Collections.Generic;
using PureMVC.Interfaces;
using UnityEngine;

public class PlayerHeadBoxCtrl : MonoBehaviour
{
	public GameObject copyone;

	public ScrollRectBase mScrollRect;

	public HeadBoxInfinity mInfinity;

	public PVPPlayerUICtrl playerUICtrl;

	private int leftpadding;

	private int width;

	private int height;

	private int LineCount;

	private int BottomHeight;

	private Vector2 scrollsize;

	private MutiCachePool<HeadBoxOne> mCachePool;

	private List<int> mList;

	private List<HeadBoxOne> mItemList;

	private int chooseIndex;

	public void OnInit()
	{
	}

	public void OnOpen()
	{
	}

	private void UpdateChildCallBack(int index, HeadBoxOne one)
	{
	}

	private void update_scroll_height()
	{
	}

	public object OnGetEvent(string eventName)
	{
		return null;
	}

	public void OnHandleNotification(INotification notification)
	{
	}

	public void OnLanguageChange()
	{
	}

	private void OnClickOne(HeadBoxOne one)
	{
	}

	private HeadBoxOne getHeadBoxOne(int index)
	{
		return null;
	}

	public int ChooseIndex()
	{
		return 0;
	}

	private void OnDestroy()
	{
	}
}
