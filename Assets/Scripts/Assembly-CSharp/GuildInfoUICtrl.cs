using System;
using System.Collections.Generic;
using DG.Tweening;
using Habby.Guild.Data;
using UnityEngine;
using UnityEngine.UI;

public class GuildInfoUICtrl : MediatorCtrlBase
{
	[SerializeField]
	private DxxText txtName;

	[SerializeField]
	private DxxText txtTitle;

	[SerializeField]
	private DxxText txtId;

	[SerializeField]
	private DxxText txtTitleLevel;

	[SerializeField]
	private DxxText txtTitleActivity;

	[SerializeField]
	private DxxText txtTitleTagIcons;

	[SerializeField]
	private DxxText txtTitleOpenType;

	[SerializeField]
	private DxxText txtTitleCptRequirement;

	[SerializeField]
	private DxxText txtTitleMember;

	[SerializeField]
	private DxxText txtLevel;

	[SerializeField]
	private DxxText txtMember;

	[SerializeField]
	private DxxText txtMemberCount;

	[SerializeField]
	private DxxText txtOpenType;

	[SerializeField]
	private DxxText txtCptRequirement;

	[SerializeField]
	private DxxText txtBtnJoin;

	[SerializeField]
	private DxxText txtEngagePoints;

	[SerializeField]
	private DxxText txtBtnRemove;

	[SerializeField]
	private DxxText txtBtnHandover;

	[SerializeField]
	private DxxText txtBtnChangePermission;

	[SerializeField]
	private DxxText txtBtnQuit;

	[SerializeField]
	private DxxText txtBtnCancel;

	[SerializeField]
	private DxxText txtEngageDesc1;

	[SerializeField]
	private DxxText txtEngageDesc2;

	[SerializeField]
	private DxxText txtEngageDesc3;

	[SerializeField]
	private DxxText guildSor;

	[SerializeField]
	private GuildBadgeItem badgeItem;

	[SerializeField]
	private GuildTagIconItem tagIconItem;

	[SerializeField]
	private RectTransform tagIconRoot;

	[SerializeField]
	private ButtonCtrl btnJoin;

	[SerializeField]
	private ButtonCtrl btnClose;

	[SerializeField]
	private ButtonCtrl btnSearch;

	[SerializeField]
	private ButtonCtrl btnEdit;

	[SerializeField]
	private ButtonCtrl btnQuit;

	[SerializeField]
	private ButtonCtrl btnRemove;

	[SerializeField]
	private ButtonCtrl btnHandover;

	[SerializeField]
	private ButtonCtrl btnChangePermission;

	[SerializeField]
	private ButtonCtrl btnHuge;

	[SerializeField]
	private ButtonCtrl btnCancel;

	[SerializeField]
	private ButtonCtrl btnEngageInfo;

	[SerializeField]
	private ButtonCtrl btnCloseEngageInfo;

	[SerializeField]
	private ButtonCtrl btnChanl;

	[SerializeField]
	private GuildMemberInfinity infinity;

	[SerializeField]
	private ScrollRectBase scroll;

	[SerializeField]
	private GameObject goControlButtons;

	[SerializeField]
	private GameObject goPlaceHolder;

	[SerializeField]
	private GameObject goMemberControlButtons;

	[SerializeField]
	private GameObject goBtnCancel;

	[SerializeField]
	private GameObject goBtnRequestJoin;

	[SerializeField]
	private GameObject goEngageDesc;

	[SerializeField]
	private RedNodeOneCtrl chanl_redNode;

	[Header("进度条")]
	public Image sorBar;

	public GameObject go_sorBar;

	private Sequence sequenceRemoveItem;

	private GuildInfoData shownGuildData;

	private GuildMemberInfo interactingMemberData;

	private List<GuildMemberInfo> memberList;

	private List<GuildTagIconItem> tagIcons;

	private int myPermissionLevel;

	private long applyListRefreshedTimestamp;

	private Action onClose;

	private int curLevel;

	private int curExp;

	private bool isTweening;

	private float expFillDuration;

	private RectTransform _scrollRect;

	private Comparison<GuildMemberInfo> comparison;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void SetGuildUI(object _)
	{
	}

	private void SetChanlBtn()
	{
	}

	protected override void OnClose()
	{
	}

	public override void OnLanguageChange()
	{
	}

	private void android_escape()
	{
	}

	private void RegisterButtons()
	{
	}

	private void OnBtnChangePermission()
	{
	}

	private void OnBtnHandover()
	{
	}

	private void OnBtnRemove()
	{
	}

	private void OnBtnQuitClick()
	{
	}

	private void OnBtnEditClick()
	{
	}

	private void OnBtnJoinClick()
	{
	}

	private void OnCancel()
	{
	}

	private void OnGuildFakeDataChange(object _)
	{
	}

	private void OnGuildInfoChange(object _)
	{
	}

	private void OnGuildMemberUpdate(object _)
	{
	}

	private void OnJoinGuild(object o)
	{
	}

	private void OnQuitGuild(object o)
	{
	}

	private void SetGuildInfoUI()
	{
	}

	private void UpdateItem(int index, GuildMemberItemCtrl itemCtrl)
	{
	}

	private void OnItemClick(GuildMemberItemCtrl ctrl)
	{
	}

	private void SetMembers()
	{
	}

	private void GetMembers()
	{
	}

	private void GetMemberListFromCache()
	{
	}

	private void SetGuildInfoDynamicUI()
	{
	}

	private void SetExp()
	{
	}

	private void CheckLevel(GuildInfoData data)
	{
	}

	private void SetButtons()
	{
	}

	private void SetBadge(GuildBadgeData badgeData)
	{
	}

	private void SetTagIcons(int[] ids)
	{
	}

	private void SetTagIconInfos(int id, bool wasShown)
	{
	}

	private void OpenMemberControlPanel(RectTransform memberItem)
	{
	}

	private void SetRedPoint()
	{
	}

	private void CloseMemberControlPanel()
	{
	}
}
