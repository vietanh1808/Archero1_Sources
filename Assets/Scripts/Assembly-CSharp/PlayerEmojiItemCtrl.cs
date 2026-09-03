using System.Collections.Generic;
using UnityEngine;

public class PlayerEmojiItemCtrl : MonoBehaviour
{
	public GameObject copyone;

	public ScrollRectBase mScrollRect;

	public EmojiOneInfinity mInfinity;

	public PVPPlayerUICtrl playerUICtrl;

	private int leftpadding;

	private int width;

	private int height;

	private int LineCount;

	private int BottomHeight;

	private Vector2 scrollsize;

	private MutiCachePool<EmojiOneCtrl> mCachePool;

	private List<int> mList;

	private List<EmojiOneCtrl> mItemList;

	private int chooseIndex;

	public void OnInit()
	{
	}

	public void OnOpen()
	{
	}

	private void UpdateChildCallBack(int index, EmojiOneCtrl one)
	{
	}

	private void update_scroll_height()
	{
	}

	private void OnDestroy()
	{
	}
}
