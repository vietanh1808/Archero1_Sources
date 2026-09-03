using System;
using System.Collections.Generic;
using Habby.Guild.Data;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.Serialization;

public class GuildCreationUICtrl : MediatorCtrlBase
{
	public enum GuildOpenType
	{
		Open = 0,
		NeedPermission = 1
	}

	private enum State
	{
		Creating = 0,
		Editing = 1,
		Viewing = 2
	}

	[SerializeField]
	private DxxInput inputGuildName;

	[SerializeField]
	private DxxText txtTitle;

	[SerializeField]
	private DxxText txtTitleInputName;

	[SerializeField]
	private DxxText txtTitleBadge;

	[SerializeField]
	private DxxText txtTitleTags;

	[SerializeField]
	private DxxText txtTitleOpenType;

	[SerializeField]
	private DxxText txtTitleLimit;

	[FormerlySerializedAs("txtGuildType")]
	[SerializeField]
	private DxxText txtOpenType;

	[SerializeField]
	private DxxText txtCptLimit;

	[SerializeField]
	private DxxText txtCancel;

	[SerializeField]
	private DxxText txtConfirm;

	[SerializeField]
	private DxxText txtCreate;

	[SerializeField]
	private DxxText txtCreationCost;

	[SerializeField]
	private ButtonCtrl btnChangeBadge;

	[SerializeField]
	private ButtonCtrl btnChangeLabels;

	[SerializeField]
	private ButtonCtrl btnGuildOpenTypeLeft;

	[SerializeField]
	private ButtonCtrl btnGuildOpenTypeRight;

	[SerializeField]
	private ButtonCtrl btnMinCptLeft;

	[SerializeField]
	private ButtonCtrl btnMinCptRight;

	[SerializeField]
	private ButtonCtrl btnCreate;

	[SerializeField]
	private ButtonCtrl btnConfirm;

	[SerializeField]
	private ButtonCtrl btnCancel;

	[SerializeField]
	private GuildBadgeCreationUICtrl creationCtrl;

	[SerializeField]
	private GuildBadgeItem badgeItem;

	[SerializeField]
	private GuildTagItem tagItem;

	[SerializeField]
	private RectTransform tagRoot;

	private List<GuildTagItem> tags;

	private GuildOpenType openType;

	private State state;

	private int minCptToJoin;

	private List<int> selectedTagIds;

	private GuildBadgeData badgeData;

	private GuildInfoData data;

	private string inputValue;

	private int badgeChangeTimes;

	private int tagChangeTimes;

	private Action onClose;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose()
	{
	}

	private void android_escape()
	{
	}

	private void RetrieveData()
	{
	}

	private void SwitchState(State target)
	{
	}

	private void SetUI()
	{
	}

	private void SetTags(List<int> ids)
	{
	}

	private void SetBadge(GuildBadgeData data)
	{
	}

	private void SetDefault()
	{
	}

	private void RegisterUICallbacks()
	{
	}

	private void ConfirmChanges()
	{
	}

	private void ReportCreationResult(bool success, string code, string clanId)
	{
	}

	private void CreateGuild()
	{
	}

	public override void OnLanguageChange()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	private void SetDynamicUI()
	{
	}

	private void SetTypeAndCptControls(bool canEdit)
	{
	}

	private void SetUIActivity()
	{
	}

	private void OnJoinGuild(object _)
	{
	}
}
