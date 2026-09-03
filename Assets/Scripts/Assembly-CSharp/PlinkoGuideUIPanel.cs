using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlinkoGuideUIPanel : MediatorCtrlBase
{
	public DxxText Text_Title;

	public ButtonCtrl Button_Close;

	public ButtonCtrl Button_Pic;

	public DxxText Text_Pic;

	public GameObject Focus_Pic;

	public ButtonCtrl Button_Rule;

	public DxxText Text_Rule;

	public GameObject Focus_Rule;

	public ButtonCtrl Button_Reward;

	public DxxText Text_Reward;

	public GameObject Focus_Reward;

	public GameObject Panel_Pic;

	public GameObject Panel_Rule;

	public GameObject Panel_Reward;

	public GameObject cpRewardItem;

	public DxxText Text_Desc;

	private int currentTab;

	public ScrollRect scrollRect;

	public DxxText contentText;

	private LocalUnityObjctPool pool;

	public PlinkoGuideRewardShowItem cellItem;

	public ScrollRectBase scroll_Panel3;

	private List<PlinkoGuideRewardShowItem> items;

	private List<PlinkoGuideRewardShowData> dataList => null;

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

	private void onButtonPic()
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
