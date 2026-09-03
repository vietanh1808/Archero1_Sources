using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using GameProtocol;
using PureMVC.Interfaces;
using TableTool;
using UnityEngine;

public class Act5thHuntingGameUIPanel : MediatorCtrlBase
{
	[CompilerGenerated]
	private sealed class _003CCountDown_003Ed__66 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Act5thHuntingGameUIPanel _003C_003E4__this;

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
		public _003CCountDown_003Ed__66(int _003C_003E1__state)
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
	private sealed class _003CReadyCountDown_003Ed__64 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Act5thHuntingGameUIPanel _003C_003E4__this;

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
		public _003CReadyCountDown_003Ed__64(int _003C_003E1__state)
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
	private Act5thHuntingGameArrowCreator arrowCreator;

	[SerializeField]
	private Act5thHuntingGameAnimalCreator animalCreator;

	[SerializeField]
	private Transform gameSceneParent;

	[SerializeField]
	private Transform entityPool;

	[SerializeField]
	private DxxText countDown;

	[SerializeField]
	private DxxText getScore;

	[SerializeField]
	private DxxText arrowLeftCount;

	[SerializeField]
	private DxxText readyCountDown;

	[SerializeField]
	private DxxText animalLeftCount;

	[SerializeField]
	private FitContentText gameEndTip;

	[SerializeField]
	private GameObject readyCountDownObj;

	[SerializeField]
	private ButtonCtrl pauseBtn;

	[SerializeField]
	private CanvasGroup gameEndCanvasGroup;

	[SerializeField]
	private Act5thHuntingGameGuide gameGuide;

	[SerializeField]
	private ButtonCtrl killPreviewBtn;

	private long gameLeftTime;

	private RectTransform gameSceneRect;

	private Coroutine coroutineCountDown;

	private WaitForSeconds wait;

	private int readyCountDownLeftTime;

	private Tweener fadeTween;

	private Tween delayCall;

	private Act5thHuntingGameEndType curGameEntType;

	private int oldMaxUnlockSceneID;

	private Act5thHuntingManager HuntingManager => null;

	private Act5thHuntingEntityManager HuntingEntityManager => null;

	private Act5thHuntingGameData HuntingGameData => null;

	private Act5thHuntingSceneData HuntingSceneData => null;

	private bool IsGameEnding => false;

	private bool IsGameGuiding => false;

	private bool IsGameEnd => false;

	private bool IsTimeOut => false;

	private bool IsKillAllEnemy => false;

	private bool IsArrowExhaustion => false;

	private Act5thHuntingGameEndType GameEndType => Act5thHuntingGameEndType.None;

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

	private void Esc()
	{
	}

	private (List<int>, List<Drop_DropModel.DropData>) ParseGameResultData()
	{
		return default;
	}

	private void CheckGameStart()
	{
	}

	private void CheckNormalGameEnd()
	{
	}

	private void CheckForceGameEnd()
	{
	}

	private void GameStar()
	{
	}

	private void GameEnd()
	{
	}

	private void GameEndEffect()
	{
	}

	private void Refresh()
	{
	}

	private void RefreshItem()
	{
	}

	private void RefreshText()
	{
	}

	private void RefreshStatus()
	{
	}

	private void RefreshReadyCountDown()
	{
	}

	[IteratorStateMachine(typeof(_003CReadyCountDown_003Ed__64))]
	private IEnumerator ReadyCountDown()
	{
		return null;
	}

	private void RefreshCountDown()
	{
	}

	[IteratorStateMachine(typeof(_003CCountDown_003Ed__66))]
	private IEnumerator CountDown()
	{
		return null;
	}

	private void OnPointerClick(Vector2 clickPos)
	{
	}

	private void ClickPause()
	{
	}

	private void ClickKillPreview()
	{
	}

	private void RequestNormalGameEnd()
	{
	}

	private void RequestForceGameEnd()
	{
	}

	private void RequestGameEnd(Action<STRespActivityHunting> success = null, Action<STRespActivityHunting> failure = null)
	{
	}

	private Act5thHuntingGameEndType GetGameEndType()
	{
		return Act5thHuntingGameEndType.None;
	}

	private void CheckUnlockSceneTip()
	{
	}
}
