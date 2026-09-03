using System.Collections.Generic;
using GameProtocol;
using UnityEngine;
using UnityEngine.UI;

public class DiamondBoxActivityUICtrl : MediatorCtrlBase
{
	public ButtonCtrl Button_Close;

	public ButtonCtrl Button_Shadow;

	public DxxText Text_Title;

	public DxxText Activity_NewTitle;

	public DxxText Activity_NewContent;

	public DxxText Activity_Title;

	public DxxText Activity_Content;

	public GameObject ActivityEquip;

	public GameObject NewEquip;

	public RectTransform content;

	public RectTransform newcontent;

	[SerializeField]
	private VerticalLayoutGroup contentRoot;

	[SerializeField]
	private LayoutElement layout;

	private float shrink;

	private float interval;

	private float managercontentheigh;

	private float ActivityEquipNewy;

	private LocalUnityObjctPool mPool;

	private CRespShopBoxActivity uBack;

	private List<CBoxActivityInfo> activityInfoList;

	private List<string> activityNewInfoList;

	private GameObject _harvestitem;

	private GameObject harvestitem => null;

	protected override void OnInit()
	{
	}

	protected override void OnClose()
	{
	}

	private void android_escape()
	{
	}

	protected override void OnOpen()
	{
	}

	private void RefreshHeight()
	{
	}

	public override void OnLanguageChange()
	{
	}
}
