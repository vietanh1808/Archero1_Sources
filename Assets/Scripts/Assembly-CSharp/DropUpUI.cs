using System.Collections.Generic;
using Dxx.Util;
using UnityEngine;
using UnityEngine.UI;

public class DropUpUI : MonoBehaviour
{
	public UILineCtrl UILine;

	public DxxText TitleText;

	public DxxText TimeText;

	public DxxText DropText;

	public DxxText RateText;

	public DxxText TaskText;

	public GameObject scrollShow;

	public GameObject scrollbarV;

	public RectTransform rectscroll;

	public RectTransform taskscroll;

	public RectTransform task;

	public RectTransform dropUpShow;

	public ButtonCtrl Close_Button;

	public RectTransform show_bg;

	public RectTransform dropcontent;

	public RectTransform child;

	public RectTransform content;

	public RectTransform rDropText;

	public RectTransform rRateText;

	public DropUpTaskItem taskItem;

	public static bool haveChange;

	public Image Image_KV;

	public Sprite KV_Default;

	public Sprite KV_Type10;

	public Sprite KV_Type11_14;

	private List<DropUpTaskItem> dlist;

	private SequencePool mSeqPool;

	private LocalUnityObjctPool mPool;

	private LocalUnityObjctPool taskPool;

	private float taskpositiony;

	private float bgheight;

	private float itemheight;

	private float countdown;

	private bool haveShowEquip;

	private GameObject _harvestitem;

	private DropUpPropType curDropType;

	private float scrollH1;

	private float scrollH2;

	private DropUpPropData CurTypeDropUpData => null;

	private GameObject harvestitem => null;

	public void OnInit()
	{
	}

	public void OnOpen(DropUpPropType curDropType)
	{
	}

	private void RefreshText()
	{
	}

	public void ShowDropEquip()
	{
	}

	private void ShowDropUpTask()
	{
	}

	private void Update()
	{
	}

	private void ScreenAdaptation()
	{
	}

	private void ChangeTask()
	{
	}

	public void OnClose()
	{
	}

	public void OnLanguageChange()
	{
	}
}
