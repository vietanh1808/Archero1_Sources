using System.Collections.Generic;
using TableTool;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMedalCtrl : MonoBehaviour
{
	public MedalItemInfinity mInfinity;

	private MutiCachePool<HeadBoxOne> mCachePool;

	public GameObject copyone;

	public ScrollRectBase mScrollRect;

	public DxxText nameDesc;

	public DxxText contentDesc;

	public DxxText rateDesc;

	public Image qualityBgImage;

	public DxxText preTitleDesc;

	public DxxText AttributeDesc;

	public PVPPlayerUICtrl playerUICtrl;

	public Transform[] ShowSeats;

	public PVPHeadAttItem[] medalAttItems;

	private List<Achieve_Medal> mList;

	private int mCurChooseid;

	private int[] mShowMedalIds;

	private MedalItemScr CurChooseItem;

	private Color cq2;

	private Color cq3;

	private Color cq4;

	private Color cq6;

	public RectTransform InfiniteObj;

	public MedalItemOne[] topItemOne;

	public void OnInit()
	{
	}

	private void UpdateChildCallBack(int arg1, MedalItemScr arg2)
	{
	}

	public void OnOpen()
	{
	}

	public void ClickOne(MedalItemScr one)
	{
	}

	public void RefreshSelectMedal(Achieve_Medal medal)
	{
	}

	private void SetQualityLevel(Achieve_Medal medal)
	{
	}

	private void ShowAttribute(Achieve_Medal medal)
	{
	}

	private void SetButtonState()
	{
	}

	public void OnClickButton()
	{
	}

	private void RefreshShowMedal()
	{
	}

	public void onCloseUI()
	{
	}
}
