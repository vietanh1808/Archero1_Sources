using System;
using System.Collections.Generic;
using Dxx.Util;
using PureMVC.Interfaces;
using UnityEngine;

public class ChooseSkillsOfBossChallenge : MediatorCtrlBase
{
	public DxxText txt_title;

	public DxxText txt_context;

	public DxxText txt_prompt;

	public SkillButtonCtrl aniObj;

	public GameObject mask;

	public SkillButtonCtrl[] selectedSkillSlots;

	public InGameSkillTableViewWrapper tableViewWrapper;

	public List<int> selectedSkillIds;

	private int maxSelectedSkillCount;

	private List<int> alternativeSkillIds;

	private SequencePool mSeqPool;

	private int SelectedSkillSlotCount => 0;

	public bool isPlayingAnim { get; set; }

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	public override void OnLanguageChange()
	{
	}

	private void updateTxtPrompt()
	{
	}

	private void android_escape()
	{
	}

	private void onChooseSkill(int alternativeSkillSlotIndex)
	{
	}

	private void onReachMaxSkillIds(Action callback)
	{
	}

	private void try2ShapeAlternativeSkillIds()
	{
	}

	private List<int> getAlternativeSkillIds()
	{
		return null;
	}

	private void playAddSkillAnim(int skillid, SkillButtonCtrl skillButtonCtrl, Action callback)
	{
	}
}
