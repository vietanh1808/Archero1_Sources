using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Activity.Anniversary
{
	public class TaskPanel : PanelBase
	{
		[CompilerGenerated]
		private sealed class _003CTick_003Ed__45 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TaskPanel _003C_003E4__this;

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
			public _003CTick_003Ed__45(int _003C_003E1__state)
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
		private DxxText txtCountdownUnlock;

		[SerializeField]
		private DxxText txtTab1;

		[SerializeField]
		private DxxText txtTab1_2;

		[SerializeField]
		private DxxText txtTab2;

		[SerializeField]
		private DxxText txtTab2_2;

		[SerializeField]
		private DxxText txtTab3;

		[SerializeField]
		private DxxText txtTab3_2;

		[SerializeField]
		private ButtonCtrl btnTabInfo;

		[SerializeField]
		private ButtonCtrl btnTab1;

		[SerializeField]
		private ButtonCtrl btnTab2;

		[SerializeField]
		private ButtonCtrl btnTab3;

		[SerializeField]
		private DxxImage imgTab1Selected;

		[SerializeField]
		private DxxImage imgTab1Unselected;

		[SerializeField]
		private DxxImage imgTab2Selected;

		[SerializeField]
		private DxxImage imgTab2Unselected;

		[SerializeField]
		private DxxImage imgTab3Selected;

		[SerializeField]
		private DxxImage imgTab3Unselected;

		[SerializeField]
		private DxxText txtTitleReward;

		[SerializeField]
		private DxxText txtTitleTask;

		[SerializeField]
		private DxxText txtProgress;

		[SerializeField]
		private GameObject goLocked;

		[SerializeField]
		private GameObject goStage2;

		[SerializeField]
		private GameObject goStage3;

		[SerializeField]
		private GameObject goContents;

		[SerializeField]
		private GameObject goImgProgress1;

		[SerializeField]
		private GameObject goImgProgress2;

		[SerializeField]
		private GameObject goImgProgress3;

		[SerializeField]
		private GlobalRewardItem rewardTemplate;

		[SerializeField]
		private PersonalTaskItem taskTemplate;

		[SerializeField]
		private PropOneEquip propTemplate;

		[SerializeField]
		private RectTransform rtTaskRoot;

		[SerializeField]
		private RectTransform rtRewardRoot;

		[SerializeField]
		private ScrollRect sr;

		[SerializeField]
		private Slider slider;

		[SerializeField]
		private RedNodeCtrl[] redNodes;

		private LocalUnityObjctPool pool;

		private Coroutine ticker;

		private int stage;

		private static DelegateBridge __Hotfix0_Awake;

		private static DelegateBridge __Hotfix0_OnInfoTabClick;

		private static DelegateBridge __Hotfix0_Init;

		private static DelegateBridge __Hotfix0_Open;

		private static DelegateBridge __Hotfix0_Close;

		private static DelegateBridge __Hotfix0_OnLanguageChange;

		private static DelegateBridge __Hotfix0_Tick;

		private static DelegateBridge __Hotfix0_RefreshCountDownTab;

		private static DelegateBridge __Hotfix0_RefreshCountDownOpen;

		private static DelegateBridge __Hotfix0_SetTab;

		private static DelegateBridge __Hotfix0_SetContents;

		private static DelegateBridge __Hotfix0_SetLocked;

		private static DelegateBridge __Hotfix0_SetTabs;

		private static DelegateBridge __Hotfix0_Refresh;

		private static DelegateBridge __Hotfix0_OnHandleNotification;

		private static DelegateBridge _c__Hotfix0_ctor;

		private void Awake()
		{
		}

		private void OnInfoTabClick()
		{
		}

		public override void Init(IActivityUI ctrl)
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

		[IteratorStateMachine(typeof(_003CTick_003Ed__45))]
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

		private void SetTab(int stage)
		{
		}

		private void SetContents(int stage)
		{
		}

		private void SetLocked(int stage, bool showContents)
		{
		}

		private void SetTabs(int stage)
		{
		}

		public override void Refresh()
		{
		}

		public override void OnHandleNotification(INotification notification)
		{
		}

		private void _003C_003ExLuaBaseProxy_Init(IActivityUI P0)
		{
		}

		private void _003C_003ExLuaBaseProxy_Open()
		{
		}

		private void _003C_003ExLuaBaseProxy_Close()
		{
		}

		private void _003C_003ExLuaBaseProxy_OnLanguageChange()
		{
		}

		private void _003C_003ExLuaBaseProxy_Refresh()
		{
		}

		private void _003C_003ExLuaBaseProxy_OnHandleNotification(INotification P0)
		{
		}
	}
}
