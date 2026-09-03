using System;
using TableTool;
using UnityEngine;

public class MazeSkillMagicianSkillAni : MonoBehaviour
{
	public RectTransform skillPfb;

	public DxxText skillname;

	public DxxText buyMoney;

	public const int count = 4;

	protected MazeSkillMagicianItemCtl.ItemInfo selectSkill;

	protected MazeSkillMagicianItemCtl.ItemInfo lastSkill;

	protected float iconheight;

	protected Vector2 itemStep;

	protected MazeSkillMagicianItemCtl.ItemInfo[] skillList;

	protected Action callEnd;

	private bool waitStop;

	private bool startAni;

	public void Init(Action pCallEnd)
	{
	}

	public void Open()
	{
	}

	public void Close()
	{
	}

	public void SetSkills(Skill_slotin[] plist)
	{
	}

	public void StartAni()
	{
	}

	public void StopAni()
	{
	}

	public void OnLanguageChange()
	{
	}

	private void LateUpdate()
	{
	}

	private void UpdateAni()
	{
	}

	private void AniEnd()
	{
	}
}
