using System.Collections.Generic;
using DG.Tweening;
using Habby.Guild.Data;
using UnityEngine;

public class GuildApplyUICtrl : MediatorCtrlBase
{
	[SerializeField]
	private DxxText txtTitle;

	[SerializeField]
	private DxxText txtTipEmpty;

	[SerializeField]
	private DxxText txtBtnAcceptAll;

	[SerializeField]
	private DxxText txtBtnIgnoreAll;

	[SerializeField]
	private ButtonCtrl btnClose;

	[SerializeField]
	private ButtonCtrl btnAcceptAll;

	[SerializeField]
	private ButtonCtrl btnIgnoreAll;

	[SerializeField]
	private GuildMemberApplyInfinity infinity;

	private List<UserInfoList.UserInfo> userDataList;

	private Sequence sequenceRemoveItem;

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

	public override void OnLanguageChange()
	{
	}

	private void RegisterUICallbacks()
	{
	}

	private void ClearInfinity()
	{
	}

	private void UpdateInfinity()
	{
	}

	private void UpdateItem(int i, GuildMemberApplyItem item)
	{
	}

	public void RemoveItem(UserInfoList.UserInfo dataToRemove)
	{
	}
}
