using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class SailingMapPreviewUIPanel : MediatorCtrlBase
{
	public DxxText Text_Title;

	public ButtonCtrl Button_Close;

	public ButtonCtrl Button_Rank;

	public DxxText Text_Rank;

	public RectTransform Indicator;

	public ScrollRect scrollRect;

	public RectTransform mapContent;

	public RectTransform mapItems;

	public GameObject cpItem;

	public GameObject PopRankWindow;

	public GameObject PopRankArrow;

	public SailingMapRankItemCell rankItem;

	public GameObject[] Circles;

	private int[] StepDistance;

	public DxxText Text_PosInfo1;

	public DxxText Text_PosInfo2;

	public DxxText[] Text_Distance;

	public ButtonCtrl[] Button_Treasure;

	public SailingMapCloudUI cloudUI;

	public SailingMapGuideArrow ArrowUI;

	public GameObject Arrow1;

	public GameObject Arrow2;

	public GameObject BG;

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

	private void Esc()
	{
	}

	private void initUI()
	{
	}

	private void onButtonRank()
	{
	}

	private void onButtonClose()
	{
	}

	public void onScroll(Vector2 position)
	{
	}

	private SailingMapItem GetMapItem(ulong userid)
	{
		return null;
	}

	private void showMapItem(ulong userid, bool go)
	{
	}

	private void scrollToMapItem(SailingMapItem item)
	{
	}

	public void onButtonClickPopWindow()
	{
	}

	private void onButtonTreasure(int index)
	{
	}
}
