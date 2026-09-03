using System;
using System.Collections.Generic;
using Dxx.Util;
using PureMVC.Interfaces;
using UnityEngine;

public class ChooseSkillPVPCtrl : MediatorCtrlBase
{
	public DxxText mTitleText;

	public DxxText mContentText;

	public DxxText mPromptText;

	public DxxText mTimeText;

	public List<int> m_listIds;

	public SkillButtonCtrl[] selectedSkills;

	public SkillButtonCtrl[] skills;

	public SkillButtonCtrl aniObj;

	public GameObject mask;

	private SequencePool mSeqPool;

	private List<int> m_listSkills;

	private const int m_nSkillNum = 3;

	private const float TotalCountdown = 10f;

	private float countdown;

	private bool isStart;

	private bool isAuto;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void UpdateUI()
	{
	}

	private void Update()
	{
	}

	protected override void OnClose()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	private void select_skill(int skillid, int index)
	{
	}

	private void play_combine(int skillid, SkillButtonCtrl one, Action callback)
	{
	}

	public void StartCountdown()
	{
	}

	public void EndCountdown()
	{
	}

	private void autoClose()
	{
	}

	private int get_index_bySkillid(int skillid)
	{
		return 0;
	}

	private int GetAutoSkillID()
	{
		return 0;
	}

	public override void OnLanguageChange()
	{
	}
}
