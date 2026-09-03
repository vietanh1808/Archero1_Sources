using System.Collections.Generic;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class ArtifactUIPanel : MediatorCtrlBase
{
	public ButtonCtrl Button_Back;

	public ButtonCtrl Button_Get;

	public DxxText Text_Get;

	public Image Icon_Get;

	public GameObject RedPoint_Get;

	public ButtonCtrl Button_Preview;

	public DxxText Text_Preview;

	public ButtonCtrl Button_Wear;

	public DxxText Text_Wear;

	public ButtonCtrl Button_Down;

	public DxxText Text_Down;

	public ButtonCtrl Button_Star;

	public DxxText Text_Star;

	public GameObject RedPoint_Star;

	public ButtonCtrl Button_View;

	public GameObject ViewIcon1;

	public GameObject ViewIcon2;

	public RectTransform RectTop;

	public GameObject[] RatityObj;

	public DxxText Text_Title;

	public ArtifactStarShowItem starItems;

	public ArtifactModelShow modelShow;

	public ArtifactSkillShowItem skillShow;

	public ScrollRect scrollRect;

	public RectTransform Content;

	public GameObject cpItem;

	private int currentIndex;

	private List<LocalSave.ArtifactOne> dataList;

	public DxxText Text_SelectTitle;

	public ArtifactSelectItem[] selectItems;

	public ArtifactSelectPopUI selectPopUI;

	public ArtifactChoosePopUI chooseUI;

	public ButtonCtrl Button_TryPlay;

	public DxxText Text_TryPlay;

	private LocalSave.ArtifactOne currentArtiOne;

	protected override void OnInit()
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

	private void initUI()
	{
	}

	private void initUIWithId(int artid)
	{
	}

	private void freshTopInfo()
	{
	}

	private void freshLeftButton()
	{
	}

	private void freshArtiItemList(int goid = 0)
	{
	}

	private void freshBottom()
	{
	}

	private void freshSelectItems()
	{
	}

	private void Esc()
	{
	}

	private void onButtonClose()
	{
	}

	private void onButtonGet()
	{
	}

	private void onButtonPreview()
	{
	}

	private void onButtonWear()
	{
	}

	private void onButtonDown()
	{
	}

	private void onButtonStar()
	{
	}

	private void onButtonView()
	{
	}

	private void onButtonShow()
	{
	}

	private void wearOrDownOne(int pos, int artid)
	{
	}
}
