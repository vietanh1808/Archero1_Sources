using UnityEngine;
using UnityEngine.UI;

public class ActIslandVSGuideUIPanel : MediatorCtrlBase
{
	public DxxText Text_Title;

	public ButtonCtrl Button_Close;

	public ButtonCtrl Button_Rule;

	public DxxText Text_Rule;

	public GameObject Focus_Rule;

	public ButtonCtrl Button_Reward;

	public DxxText Text_Reward;

	public GameObject Focus_Reward;

	public GameObject Panel_Rule;

	public GameObject Panel_Reward;

	public ScrollRect scrollRect;

	public DxxText contentText;

	public RectTransform Content2;

	private LocalUnityObjctPool pool;

	public ActIslandVSGuideItem cellItem;

	public ScrollRectBase scroll_Panel3;

	private int currentTab;

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

	private void Esc()
	{
	}

	public void onButtonClose()
	{
	}

	private void onButtonRule()
	{
	}

	private void onButtonReward()
	{
	}

	private void showTab(int tab)
	{
	}
}
