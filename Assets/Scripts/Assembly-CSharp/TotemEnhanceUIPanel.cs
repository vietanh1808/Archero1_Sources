using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class TotemEnhanceUIPanel : MediatorCtrlBase
{
	[CompilerGenerated]
	private sealed class _003CCountDown_003Ed__38 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TotemEnhanceUIPanel _003C_003E4__this;

		private float _003ConeDayTime_003E5__2;

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
		public _003CCountDown_003Ed__38(int _003C_003E1__state)
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
	private DxxText titleTxt;

	[SerializeField]
	private DxxText attrTitleTxt;

	[SerializeField]
	private DxxText btnEnhanceTxt;

	[SerializeField]
	private DxxText maxLevelTipsTxt;

	[SerializeField]
	private DxxText countDownTxt;

	[SerializeField]
	private DxxText freeEnhanceTxt;

	[SerializeField]
	private ButtonCtrl closeBtn;

	[SerializeField]
	private ButtonCtrl tipsBtn;

	[SerializeField]
	private ButtonCtrl enhanceBtn;

	[SerializeField]
	private ButtonCtrl enhanceFreeBtn;

	[SerializeField]
	private TotemItem totemItemShow;

	[SerializeField]
	private RectTransform attContent;

	[SerializeField]
	private RectTransform materialParent;

	[SerializeField]
	private TotemEnhanceAttItem enhanceAttItemTemplate;

	[SerializeField]
	private TotemEnhanceMaterialItem enhanceMaterialTemplate;

	[SerializeField]
	private GameObject goMaterial;

	[SerializeField]
	private ScrollRect scrollAtt;

	private TotemItemData _totemItemData;

	private LocalUnityObjctPool _pool;

	private bool _isBtnEnhanceClicked;

	private TotemType _fromTotemSlotType;

	private Coroutine coroutineCountDown;

	private WaitForSeconds wait;

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

	public void RefreshUI()
	{
	}

	private void RefreshBtnStatus()
	{
	}

	private void RefreshEnhanceTotem()
	{
	}

	private void RefreshEnhanceAttList()
	{
	}

	private void RefreshUpgradeMaterial()
	{
	}

	public void OnBtnCloseClicked()
	{
	}

	private void OnBtnTipsClicked()
	{
	}

	private void OnBtnEnhanceClicked()
	{
	}

	private void RefreshCountDown()
	{
	}

	[IteratorStateMachine(typeof(_003CCountDown_003Ed__38))]
	private IEnumerator CountDown()
	{
		return null;
	}
}
