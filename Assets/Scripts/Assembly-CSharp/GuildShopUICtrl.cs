using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Habby.Guild.Data;
using TableTool;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class GuildShopUICtrl : GuildPanelBase
{
	[CompilerGenerated]
	private sealed class _003CTick_003Ed__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GuildShopUICtrl _003C_003E4__this;

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
		public _003CTick_003Ed__26(int _003C_003E1__state)
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

	[SerializeField]
	private DxxText txtInfo;

	[SerializeField]
	private DxxText txtTitle;

	[SerializeField]
	private GameObject goodItem;

	[SerializeField]
	private GameObject backgroudItem;

	[SerializeField]
	private ButtonCtrl closeBtn;

	[SerializeField]
	private ScrollRect scroll;

	[SerializeField]
	[FormerlySerializedAs("itemRoots")]
	[FormerlySerializedAs("goodItemRoots")]
	private RectTransform[] rtItemRoots;

	private List<GuildShopItemCtrl>[] itemsByRefreshType;

	private Dictionary<int, GuildShopItemList.GuildShopItem> salesDataList;

	private int[] counts;

	private List<Guild_Shop> configList;

	[SerializeField]
	private List<DxxText> txtSubTitles;

	[SerializeField]
	private List<DxxText> txtCountdowns;

	private LocalUnityObjctPool pool;

	private Coroutine tickHandle;

	private bool UPDATING;

	private long nextMonthRefreshTime;

	private long nextWeekRefreshTime;

	private long nextDayRefreshTime;

	private void Awake()
	{
	}

	public override void showPanel()
	{
	}

	public override void hidePanel()
	{
	}

	public override void onLanguageChanged()
	{
	}

	private void OnOpen()
	{
	}

	private void SetSubTitles()
	{
	}

	private void OnClose()
	{
	}

	[IteratorStateMachine(typeof(_003CTick_003Ed__26))]
	private IEnumerator Tick()
	{
		return null;
	}

	private void RefreshGoods()
	{
	}

	private void OnResponse(MessageEventData<GuildShopItemList> response)
	{
	}

	private void BuildItemLists(GuildShopItemList goodsData)
	{
	}

	private void InsertItemBackgrounds(int i)
	{
	}

	private void BuildItems(int i)
	{
	}
}
