using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Activity.Anniversary;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

namespace ActivityConsumeCommon
{
	public class ConsumeLifeUIPanel : ConsumePanelBase
	{
		[CompilerGenerated]
		private sealed class _003CTick_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ConsumeLifeUIPanel _003C_003E4__this;

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
			public _003CTick_003Ed__21(int _003C_003E1__state)
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
		private DxxText txtCountdownTab;

		[SerializeField]
		private DxxText txtTitleTask;

		[SerializeField]
		private GameObject goContents;

		[SerializeField]
		private GlobalRewardItem rewardTemplate;

		[SerializeField]
		private PersonalTaskItem taskTemplate;

		[SerializeField]
		private PropOneEquip propTemplate;

		[SerializeField]
		private RectTransform rtTaskRoot;

		[SerializeField]
		private ScrollRect sr;

		private LocalUnityObjctPool pool;

		private Coroutine ticker;

		private int stage;

		public DxxText Text_Tittle;

		public RectTransform activityInfo;

		private ConsumeTab crtTab;

		private string atlasName;

		private List<ConsumeTaskItemData> taskData => null;

		public override void Init(ActConsumeCommonUICtrl crtl, ConsumeTab tab)
		{
		}

		public override void Open()
		{
		}

		public override void Close()
		{
		}

		public override void OnLanguageChange()
		{
		}

		[IteratorStateMachine(typeof(_003CTick_003Ed__21))]
		private IEnumerator Tick()
		{
			return null;
		}

		private void RefreshCountDownTab()
		{
		}

		private void RefreshCountDownOpen()
		{
		}

		private void SetContents()
		{
		}

		public override void OnHandleNotification(INotification notification)
		{
		}
	}
}
