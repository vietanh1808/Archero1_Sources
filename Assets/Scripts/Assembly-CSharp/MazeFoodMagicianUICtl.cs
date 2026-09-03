using System.Collections.Generic;
using TableTool;
using UnityEngine;
using UnityEngine.UI;

public class MazeFoodMagicianUICtl : MediatorCtrlBase
{
	public DxxText texttitle;

	public DxxText npctalk;

	public DxxText uicontext;

	public DxxText info_Money;

	public DxxText tips;

	public ButtonCtrl buttonBack;

	public Button sceneClick;

	public MazeFoodMagicianItemInfo infoCtl;

	public int itemCount;

	public GameObject itemTemp;

	public Transform itemsParent;

	protected MazeFoodMagicianItemCtl[] skills;

	private MazeFoodMagicianProxy.Transfer transfer;

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

	public void SetMoney(string pToken)
	{
	}

	private void RestUI()
	{
	}

	private void RefUIData()
	{
	}

	private IList<Skill_food_skill> GetRandomList()
	{
		return null;
	}

	private IList<Skill_food_skill> GetNeedSkill()
	{
		return null;
	}

	private int GetWeight(Skill_food_skill sender)
	{
		return 0;
	}

	protected void OnSceneClick()
	{
	}

	private void OnClickBack()
	{
	}

	private void OnBuyEnd(MazeFoodMagicianItemCtl sender)
	{
	}
}
