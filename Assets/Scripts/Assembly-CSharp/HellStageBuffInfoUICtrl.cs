using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HellStageBuffInfoUICtrl : MediatorCtrlBase
{
	public DxxText txt_AllAdd;

	public DxxText txt_MoudleAdd;

	public DxxText txt_Title;

	public DxxText txt_StrengthAllAdd;

	public DxxImage img_System;

	public GameObject go_Tabs;

	public ButtonCtrl[] tabs;

	public GameObject[] go_Selected;

	public DxxText[] txt_Tabs;

	public Transform trans_Parent;

	public ScrollRectBase scroll;

	public GridLayoutGroup grid;

	public ButtonCtrl btn_Close;

	public HellStageBuffInfoTips tips;

	public RectTransform rect_Jiao;

	public RectTransform rect_tipsBg;

	public HellSystemItem item;

	public RectTransform rect_Bg;

	public ButtonCtrl btn_Info;

	public GameObject go_InfoPanel;

	public DxxText txt_InfoContent;

	public DxxText txt_InfoTitle;

	public ButtonCtrl btn_InfoClose;

	private HellLevelData crtData;

	private HellSystemData crtModuleData;

	private int crtIndex;

	private bool isShowTab;

	private LocalUnityObjctPool pool;

	private Dictionary<HellSystemBuffType, HellGridShowSize> dicMap;

	private int currentStage;

	private int rowCount;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	public void InitUI()
	{
	}

	public void SelectTab(int tabIndex)
	{
	}

	public void RefreshShow()
	{
	}

	public void OnItemClick(HellSystemItemData itemData, Vector3 pos, int rowPos)
	{
	}

	private void OnClickInfoBtn()
	{
	}

	private void Esc()
	{
	}

	public override void OnLanguageChange()
	{
	}

	protected override void OnClose()
	{
	}
}
