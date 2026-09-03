using System;
using System.Collections.Generic;
using TableTool;
using UnityEngine;
using UnityEngine.UI;

public class MazeSkillMagicianItemCtl : MonoBehaviour
{
	public class ItemInfo
	{
		public Skill_skill skillData;

		public Skill_slotin skillSlotin;

		public Sprite spr;

		public string skillName;

		public string money;

		public RectTransform objtrans;

		public Image iconImg;

		public DxxText nameTxt;

		public DxxText moneyTxt;

		public void Show()
		{
		}

		public void OnLanguageChange()
		{
		}
	}

	public DxxText skillname;

	public DxxText buyMoney;

	public ButtonCtrl buttonIcon;

	public ButtonCtrl buttonbuy;

	public MazeSkillMagicianSkillAni skillAni;

	[SerializeField]
	private Image bgImg;

	protected int index;

	protected Action<MazeSkillMagicianItemCtl> buyCallBack;

	protected Action<int> aniEnd;

	public int skillid { get; private set; }

	public Skill_skill skillData { get; private set; }

	public Skill_slotin skillSlotin { get; private set; }

	public bool isOpen { get; private set; }

	public void Init(int pIndex, Action<MazeSkillMagicianItemCtl> call, Action<int> pAniEnd)
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

	public void SetData(Skill_slotin pskillid, IList<Skill_slotin> potherList)
	{
	}

	protected void SkillAniEnd()
	{
	}

	public void StopAni()
	{
	}

	public void ShowBuyBtn(bool pShow)
	{
	}

	private void OnClickBuy()
	{
	}

	private void BuySkill()
	{
	}
}
