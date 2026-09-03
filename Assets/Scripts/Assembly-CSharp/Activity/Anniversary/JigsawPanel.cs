using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PureMVC.Interfaces;
using UnityEngine;
using XLua;

namespace Activity.Anniversary
{
	public class JigsawPanel : PanelBase
	{
		[CompilerGenerated]
		private sealed class _003CTick_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public JigsawPanel _003C_003E4__this;

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
			public _003CTick_003Ed__33(int _003C_003E1__state)
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
		private ButtonCtrl btnInfoTab;

		[SerializeField]
		private ButtonCtrl[] btnJigsaws;

		[SerializeField]
		private RedNodeCtrl[] redNodes;

		[SerializeField]
		private JigsawChest[] chests;

		[SerializeField]
		private DxxImage imgJigsaw;

		[SerializeField]
		private DxxImage[] imgJigsaws;

		[SerializeField]
		private Sprite spNormal;

		[SerializeField]
		private Sprite spCompleted;

		[SerializeField]
		private CanvasGroup cgJigsaw;

		[SerializeField]
		private RectTransform rtContainer;

		[SerializeField]
		private RectTransform rtBgPlates;

		[SerializeField]
		private RectTransform rtJigsaw;

		[SerializeField]
		private RectTransform rtLight;

		private Material mat;

		private Texture2D texMask;

		private static readonly int idMaskTex;

		private Coroutine ticker;

		private bool isFullyClaimed;

		private static readonly Color deepGray;

		private static DelegateBridge __Hotfix0_Open;

		private static DelegateBridge __Hotfix0_Refresh;

		private static DelegateBridge __Hotfix0_RefreshJigsaw;

		private static DelegateBridge __Hotfix0_RefreshChests;

		private static DelegateBridge __Hotfix0_RefreshTexMask;

		private static DelegateBridge __Hotfix0_RefreshTexts;

		private static DelegateBridge __Hotfix0_Close;

		private static DelegateBridge __Hotfix0_Awake;

		private static DelegateBridge __Hotfix0_OnClickInfoTab;

		private static DelegateBridge __Hotfix0_ShowTaskPop;

		private static DelegateBridge __Hotfix0_CheckJigsaw;

		private static DelegateBridge __Hotfix0_OnHandleNotification;

		private static DelegateBridge __Hotfix0_RefreshCountdown;

		private static DelegateBridge __Hotfix0_Tick;

		private static DelegateBridge _c__Hotfix0_ctor;

		public override void Open()
		{
		}

		public override void Refresh()
		{
		}

		private void RefreshJigsaw()
		{
		}

		private void RefreshChests()
		{
		}

		private void RefreshTexMask()
		{
		}

		private void RefreshTexts()
		{
		}

		public override void Close()
		{
		}

		private void Awake()
		{
		}

		private void OnClickInfoTab()
		{
		}

		public void ShowTaskPop(bool isChest, int index)
		{
		}

		private void CheckJigsaw()
		{
		}

		public override void OnHandleNotification(INotification notification)
		{
		}

		private void RefreshCountdown()
		{
		}

		[IteratorStateMachine(typeof(_003CTick_003Ed__33))]
		private IEnumerator Tick()
		{
			return null;
		}

		private void _003C_003ExLuaBaseProxy_Open()
		{
		}

		private void _003C_003ExLuaBaseProxy_Refresh()
		{
		}

		private void _003C_003ExLuaBaseProxy_Close()
		{
		}

		private void _003C_003ExLuaBaseProxy_OnHandleNotification(INotification P0)
		{
		}
	}
}
