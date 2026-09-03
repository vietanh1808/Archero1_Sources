using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Habby.Guild.Data;
using PureMVC.Interfaces;
using UnityEngine;

public class GuildSuggestionUICtrl : MediatorCtrlBase
{
	private enum State
	{
		Suggestion = 0,
		Search = 1
	}

	[CompilerGenerated]
	private sealed class _003CDisableRefresh_003Ed__45 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GuildSuggestionUICtrl _003C_003E4__this;

		private float _003Ctime_003E5__2;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CDisableRefresh_003Ed__45(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	private State state;

	[SerializeField]
	private ButtonCtrl btnCreate;

	[SerializeField]
	private ButtonCtrl btnReturn;

	[SerializeField]
	private ButtonCtrl btnRefresh;

	[SerializeField]
	private ButtonCtrl btnSearch;

	[SerializeField]
	private ButtonCtrl btnQuitSearch;

	[SerializeField]
	private DxxText txtBtnCreate;

	[SerializeField]
	private DxxText txtBtnRefresh;

	[SerializeField]
	private DxxText txtHeader;

	[SerializeField]
	private DxxText txtEmptyResult;

	[SerializeField]
	private DxxText txtTitle;

	[SerializeField]
	private DxxInput inputGuildName;

	[SerializeField]
	private GuildItemInfinity infinity;

	[SerializeField]
	private PointerDownHandler pointerDownHandler;

	[SerializeField]
	private RectTransform rcBtnRefreshMask;

	private GuildListData.GuildListItem[] suggestionArr;

	private GuildListData.GuildListItem[] searchResultArr;

	private int searchPage;

	private string keyword;

	private int pageItemCount;

	private GuildInfoData fromGuildData;

	private int refreshCount;

	private int searchCount;

	private bool closeAfterJoin;

	public static HashSet<string> viewedGuildIds;

	public static HashSet<string> appliedGuildIds;

	private const short MAX_SEARCH_GUILD_COUNT = 100;

	protected override void OnInit()
	{
	}

	private void ChangePage(int delta)
	{
	}

	private void StartSearch()
	{
	}

	private void OnQuitSearch()
	{
	}

	private void OnSearch()
	{
	}

	private void OnUpdateChild(int index, GuildItem item)
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

	public override void OnHandleNotification(INotification notification)
	{
	}

	private void CreateGuild()
	{
	}

	private void SetDefault()
	{
	}

	private void SetTGADefault()
	{
	}

	private void GetProxy()
	{
	}

	private void SetUI()
	{
	}

	private void OnJoinGuild(object o)
	{
	}

	[IteratorStateMachine(typeof(_003CDisableRefresh_003Ed__45))]
	private IEnumerator DisableRefresh()
	{
		return null;
	}

	private void UpdateList()
	{
	}
}
