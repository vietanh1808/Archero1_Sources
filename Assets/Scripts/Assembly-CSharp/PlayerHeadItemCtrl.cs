using System.Collections.Generic;
using PureMVC.Interfaces;
using UnityEngine;

public class PlayerHeadItemCtrl : MonoBehaviour
{
	public GameObject copyone;

	public ScrollRectBase mScrollRect;

	public HeadItemInfinity mInfinity;

	public PVPPlayerUICtrl playerUICtrl;

	private int leftpadding;

	private int width;

	private int height;

	private int LineCount;

	private int BottomHeight;

	private Vector2 scrollsize;

	private MutiCachePool<HeadItemOne> mCachePool;

	private List<int> mList;

	private List<HeadItemOne> mItemList;

	private int chooseIndex;

	public void OnInit()
	{
	}

	public void OnOpen()
	{
	}

	private void UpdateChildCallBack(int index, HeadItemOne one)
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

	private void OnClickOne(HeadItemOne one)
	{
	}

	private HeadItemOne getHeadItemOne(int index)
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
