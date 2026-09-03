using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using BestHTTP;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class CooperationCreateUICtrl : MediatorCtrlBase
{
	[CompilerGenerated]
	private sealed class _003CWaitInToGame_003Ed__56 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CooperationCreateUICtrl _003C_003E4__this;

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
		public _003CWaitInToGame_003Ed__56(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CWaitToMatch_003Ed__54 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CooperationCreateUICtrl _003C_003E4__this;

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
		public _003CWaitToMatch_003Ed__54(int _003C_003E1__state)
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

	public RawImage img_clientHero;

	public RawImage img_serverHero;

	private HeroShow clientHeroShow;

	private HeroShow serverHeroShow;

	public DxxText Text_Title;

	public DxxText Text_RoomID;

	public DxxText Text_Content;

	public ButtonCtrl Button_Start;

	public ButtonCtrl Button_Close;

	public Transform ClientSlot;

	public Transform ServerSlot;

	private GameObject serverModel;

	private GameObject clientModel;

	public DxxText Text_ServerId;

	public DxxText Text_ClientId;

	public DxxText textLastTime;

	public GameObject joinInObj;

	public GameObject waitingObj;

	public DxxText Text_JoinIn;

	public DxxText Text_Player1;

	public DxxText Text_Player2;

	public DxxText Text_WaitingLeader;

	public ButtonCtrl Button_CopyRoom;

	public DxxText Text_Copy;

	public Transform topParent;

	public DxxText Text_Begin;

	[Header("非匹配")]
	public RectTransform nomatchParent;

	public RectTransform nomatchTopParent;

	[Header("自动匹配")]
	public RectTransform matchParent;

	public DxxText ingametime;

	public DxxText ingametitle;

	public DxxText matching;

	[SerializeField]
	private GameObject goMatching;

	[SerializeField]
	private GameObject goMatched;

	private bool isMatched;

	private HTTPRequest matchReq;

	private bool isOpen;

	private bool isOtherPlayerEnter;

	public ButtonCtrl Button_Guild;

	public DxxText Text_Guild;

	private bool isGuildCountTime;

	private bool isMatching;

	private IEnumerator waitRetry;

	private IEnumerator waitInto;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void CountGuildTime()
	{
	}

	private void AutoMatchMode()
	{
	}

	private void NoMatchMode()
	{
	}

	private void ShowMatchingUI()
	{
	}

	private void ShowMatchedUI()
	{
	}

	private void GoToMatch()
	{
	}

	private void OnClickClose()
	{
	}

	private void OnClickStartBtn()
	{
	}

	private void ReTryMatch()
	{
	}

	[IteratorStateMachine(typeof(_003CWaitToMatch_003Ed__54))]
	private IEnumerator WaitToMatch()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CWaitInToGame_003Ed__56))]
	private IEnumerator WaitInToGame()
	{
		return null;
	}

	private void StartIntoGame()
	{
	}

	private void StopIntoGame()
	{
	}

	private void android_escape()
	{
	}

	private void RestMatchProcess()
	{
	}

	private void ReleaseMatchRequest()
	{
	}

	private void RestMatchObject()
	{
	}

	protected override void OnClose()
	{
	}

	public override object OnGetEvent(string eventName)
	{
		return null;
	}

	public bool IsMatchMode()
	{
		return false;
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	private void RefreshMySelf()
	{
	}

	private int IsLeftPlayer(bool pisSelf)
	{
		return 0;
	}

	private void CreateModel(bool isSelf)
	{
	}

	private void SetColorSkin(GameObject weapon, bool isSelf)
	{
	}

	private string GetBodyString(string value)
	{
		return null;
	}

	private void OnClickCopyRoom()
	{
	}

	private void RefreshOtherPlayer()
	{
	}

	private void OnOtherPlayerDisconnect()
	{
	}

	public override void OnLanguageChange()
	{
	}

	private void OnApplicationPause(bool pauseStatus)
	{
	}

	private void OnApplicationQuit()
	{
	}
}
