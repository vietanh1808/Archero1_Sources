using System;
using TableTool;
using UnityEngine;
using UnityEngine.UI;

public class MazeFoodMagicianItemCtl : MonoBehaviour
{
	public Image icon;

	public DxxText itemname;

	public DxxText buyMoney;

	public ButtonCtrl buttonIcon;

	public ButtonCtrl buttonbuy;

	protected Action<MazeFoodMagicianItemCtl> buyCallBack;

	protected MazeFoodMagicianItemInfo infoui;

	public int itemId { get; private set; }

	public Skill_food_skill foodData { get; private set; }

	public Skill_skill skillData { get; private set; }

	public void Init(Action<MazeFoodMagicianItemCtl> call, MazeFoodMagicianItemInfo pUI)
	{
	}

	public void Open()
	{
	}

	public void Close()
	{
	}

	public void OnLanguageChange()
	{
	}

	private void RefText()
	{
	}

	public void SetData(Skill_food_skill pid)
	{
	}

	private void OnClickIcon()
	{
	}

	private void OnClickBuy()
	{
	}

	private void BuySkill()
	{
	}
}
