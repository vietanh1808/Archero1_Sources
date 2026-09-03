using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class TotemRefineUIPanel : MediatorCtrlBase
{
	private enum RefineRequestType
	{
		Refine = 0,
		Save = 1,
		Discard = 2
	}

	private sealed class TweenTimeLineItem : TimeLineItem
	{
		[CompilerGenerated]
		private sealed class _003CWaitForTween_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TweenTimeLineItem _003C_003E4__this;

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
			public _003CWaitForTween_003Ed__4(int _003C_003E1__state)
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

		private readonly Func<Tween> _createTween;

		private readonly Action _applyEndState;

		private Tween _tween;

		public TweenTimeLineItem(Func<Tween> createTween, Action applyEndState)
		{
		}

		[IteratorStateMachine(typeof(_003CWaitForTween_003Ed__4))]
		private IEnumerator WaitForTween()
		{
			return null;
		}
	}

	private sealed class ResultRevealTarget
	{
		public readonly RectTransform Rect;

		public readonly Graphic[] Graphics;

		public readonly float[] OriginalAlphas;

		public Vector2 OriginalPosition;

		public ResultRevealTarget(RectTransform rect)
		{
		}

		public void SetAlpha(float alpha)
		{
		}

		public void Restore(bool visible)
		{
		}
	}

	[SerializeField]
	private DxxText titleTxt;

	[SerializeField]
	private DxxText currentTitleTxt;

	[SerializeField]
	private DxxText resultTitleTxt;

	[SerializeField]
	private DxxText totemNameTxt;

	[SerializeField]
	private DxxText mainAttrTxt;

	[SerializeField]
	private DxxText refineBtnTxt;

	[SerializeField]
	private DxxText saveBtnTxt;

	[SerializeField]
	private DxxText discardBtnTxt;

	[SerializeField]
	private DxxText maxLevelTipTxt;

	[SerializeField]
	private ButtonCtrl closeBtn;

	[SerializeField]
	private ButtonCtrl tipsBtn;

	[SerializeField]
	private ButtonCtrl refineBtn;

	[SerializeField]
	private ButtonCtrl saveBtn;

	[SerializeField]
	private ButtonCtrl discardBtn;

	[SerializeField]
	private TotemItem totemItemShow;

	[SerializeField]
	private RectTransform currentAttrContent;

	[SerializeField]
	private RectTransform resultAttrContent;

	[SerializeField]
	private RectTransform materialContent;

	[SerializeField]
	private TotemRefineAttrItem attrItemTemplate;

	[SerializeField]
	private TotemEnhanceMaterialItem materialItemTemplate;

	[SerializeField]
	private GameObject resultRoot;

	[SerializeField]
	private GameObject materialRoot;

	[SerializeField]
	private GameObject maxLevelTipRoot;

	[SerializeField]
	private GameObject arrowObj;

	[SerializeField]
	private GameObject refineLevelRoot;

	[SerializeField]
	private RectTransform currentPart;

	[SerializeField]
	private GameObject refineNormalFrame;

	[SerializeField]
	private GameObject refineMaxFrame;

	[SerializeField]
	private DxxText refineLevelText;

	private TotemRefineOpenData _openData;

	private TotemItemData _totem;

	private LocalUnityObjctPool _pool;

	private TotemRefineUIState _state;

	private uint _lockedMask;

	private TimeLineContainer _timeLine;

	private bool _requestInProgress;

	private bool _isAnimating;

	private bool _isOpen;

	private LayoutGroup _resultAttrLayoutGroup;

	private bool _resultAttrLayoutWasEnabled;

	private bool _resultAttrLayoutSuspended;

	private readonly List<RectTransform> _resultAttrItems;

	private readonly List<ResultRevealTarget> _resultRevealTargets;

	private Vector2 noResultPos;

	private Vector2 haveResultPos;

	private Vector2 noResultSize;

	private Vector2 haveResultSize;

	private Vector2 resultPos;

	private const float LayoutDuration = 0.3f;

	private const float RevealDuration = 0.2f;

	private const float RevealOffset = 50f;

	private TotemManager Mgr => null;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose()
	{
	}

	public override void OnLanguageChange()
	{
	}

	private bool ReloadTotem()
	{
		return false;
	}

	private void RefreshState(bool playResultAnimation, bool preserveLocks = false)
	{
	}

	private void UpdateState(bool preserveLocks = false)
	{
	}

	private void RefreshUI(bool playResultAnimation)
	{
	}

	private void RefreshTotemInfo()
	{
	}

	private void RefreshResultLayout(bool showResult)
	{
	}

	private void PrepareResultRevealTargets()
	{
	}

	private void AddResultRevealTarget(RectTransform rect)
	{
	}

	private void SetResultRevealTargetsVisible(bool visible)
	{
	}

	private void PlayShowResultAnimation()
	{
	}

	private void ShowResultRootForReveal()
	{
	}

	private TimeLineItem CreateCurrentPartTimeLineItem(Vector2 targetPosition, Vector2 targetSize)
	{
		return null;
	}

	private TimeLineItem CreateRevealTimeLineItem(ResultRevealTarget target, float offsetX)
	{
		return null;
	}

	private void ApplyShowResultStopState()
	{
	}

	private void PlayHideResultAnimation(bool applyResult)
	{
	}

	private void ApplyHideResultStopState()
	{
	}

	private void SetInteractionEnabled(bool enabled)
	{
	}

	private void StopResultAnimation()
	{
	}

	private void RestoreResultRevealTargets(bool visible)
	{
	}

	private void RestoreResultAttrLayout()
	{
	}

	private void RefreshAttributes()
	{
	}

	private static string FormatAttribute(TotemAtt attr)
	{
		return null;
	}

	private TotemRefineAttrItem AddAttrItem(Transform parent, TotemAtt attr, bool isMain, int subAttrIndex, bool isResult = false)
	{
		return null;
	}

	private void RefreshMaterials()
	{
	}

	private void OnLockClicked(int subAttrIndex)
	{
	}

	private int GetLockCount()
	{
		return 0;
	}

	private void OnRefineClicked()
	{
	}

	private void OnSaveClicked()
	{
	}

	private void OnDiscardClicked()
	{
	}

	private void OnRequestCompleted(bool success, RefineRequestType requestType)
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	private void OnTipsClicked()
	{
	}

	private void OnCloseClicked()
	{
	}
}
