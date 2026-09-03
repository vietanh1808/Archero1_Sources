using System;
using System.Collections.Generic;
using Dxx.Util;
using PureMVC.Interfaces;
using UnityEngine;

public class ChooseSkillInTowerCtrl : MediatorCtrlBase
{
	public DxxText mTitleText;

	public DxxText mContentText;

	public DxxText mPromptText;

	private List<int> m_listIds;

	public SkillButtonCtrl[] selectedSkills;

	public SkillButtonCtrl[] skills;

	public SkillButtonCtrl aniObj;

	public GameObject mask;

	private SequencePool mSeqPool;

	private List<int> m_listSkills;

	private int m_nSkillNum;

	private bool _bDefaultMultiInput;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void InitData()
	{
	}

	protected override void OnClose()
	{
	}

	private void UpdateUI()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	private void play_combine(int skillid, SkillButtonCtrl one, Action callback)
	{
	}

	public override void OnLanguageChange()
	{
	}

	private void android_escape()
	{
	}
}
