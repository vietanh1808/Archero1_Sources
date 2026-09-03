using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using GameProtocol;
using PureMVC.Interfaces;
using TableTool;
using UIKit;
using UnityEngine;

public class SailingLogTableView : MonoBehaviour, IUITableViewDataSource, IUITableViewDelegate, IUITableViewMargin
{
	[CompilerGenerated]
	private sealed class _003CDelayReqLog_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

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
		public _003CDelayReqLog_003Ed__33(int _003C_003E1__state)
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

	public static float logInterval;

	private int MaxLogEventCount;

	private int curShowEvents;

	[SerializeField]
	private UITableView tableView;

	[SerializeField]
	private SailingLogTextItem textItem;

	[SerializeField]
	private SailingLogTitleItem titleItem;

	[SerializeField]
	private DxxText _textSizeCalculator;

	private List<SailingManager.SailingLogItemData> itemList;

	private bool isLoopingReqLog;

	private const float defaultTextWidth = 600f;

	private const int defaultFontSize = 28;

	private Coroutine curReqCo;

	public void InitTableView()
	{
	}

	public void ScrollToBottom()
	{
	}

	public void ScrollToBottomWithAnim(Action action = null)
	{
	}

	public void AddActionAdditional(uint eventId, int actionId, ulong time)
	{
	}

	public UITableViewCell CellAtIndexInTableView(UITableView tableView, int index)
	{
		return null;
	}

	public int NumberOfCellsInTableView(UITableView tableView)
	{
		return 0;
	}

	public float ScalarForCellInTableView(UITableView tableView, int index)
	{
		return 0f;
	}

	public void CellAtIndexInTableViewWillAppear(UITableView tableView, int index)
	{
	}

	public void CellAtIndexInTableViewDidDisappear(UITableView tableView, int index)
	{
	}

	public float ScalarForUpperMarginInTableView(UITableView tableView, int index)
	{
		return 0f;
	}

	public float ScalarForLowerMarginInTableView(UITableView tableView, int index)
	{
		return 0f;
	}

	private float CalculateTextHeight(string text, float textWidth = 600f, int fontSize = 28)
	{
		return 0f;
	}

	public void OnHandleNotification(INotification notification)
	{
	}

	private void OnGetPreLog(STRespShipBattleSeasonEvent data)
	{
	}

	private void AddEvent(STRespShipBattleSeasonEvent data, SailingManager.SailingLogItemData preData)
	{
	}

	private void AddEventTitle(uint eventId, ulong time)
	{
	}

	private void AddAction(uint eventId, int actionId, ulong time, uint Ret = 0u, uint bpDis = 0u, uint talentDis = 0u)
	{
	}

	private List<SailingManager.DropData> ReSetData(List<Drop_DropModel.DropData> list)
	{
		return null;
	}

	private void AddEmptyAction()
	{
	}

	private void AddHistoryLogs()
	{
	}

	private void CheckHistoryCount()
	{
	}

	[IteratorStateMachine(typeof(_003CDelayReqLog_003Ed__33))]
	private IEnumerator DelayReqLog()
	{
		return null;
	}

	private void OnDisable()
	{
	}

	private void GetHistotyLogs()
	{
	}
}
