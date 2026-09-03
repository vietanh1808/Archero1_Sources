using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Activity;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;
using XLua;

public class ChainGiftUIPanel : PanelBase
{
	[CompilerGenerated]
	private sealed class _003CCountDown_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ChainGiftUIPanel _003C_003E4__this;

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
		public _003CCountDown_003Ed__25(int _003C_003E1__state)
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
	private sealed class _003CGetObjectPositionNextFrame_003Ed__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ChainGiftUIPanel _003C_003E4__this;

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
		public _003CGetObjectPositionNextFrame_003Ed__26(int _003C_003E1__state)
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
	private RectTransform bg;

	[SerializeField]
	private DxxText title;

	[SerializeField]
	private DxxText subTitle;

	[SerializeField]
	private DxxText countDownText;

	[SerializeField]
	private ChainGiftRewardItem rewardItem;

	[SerializeField]
	private Transform rewardContent;

	[SerializeField]
	private BattlePassChestInformation chestInfo;

	[SerializeField]
	private GridLayoutGroup gridLayoutGroup;

	[SerializeField]
	private ScrollRect scrollRect;

	private List<ChainGiftRewardItem> rewardItems;

	private List<ChainGiftRewardItem> rewardItemsPosTemp;

	private Coroutine coroutineCountDown;

	private WaitForSeconds wait;

	private List<Vector3> points;

	private static DelegateBridge __Hotfix0_get_ChainGiftManager;

	private static DelegateBridge __Hotfix0_get_ChainGiftData;

	private static DelegateBridge __Hotfix0_get_ChainGiftRewardData;

	private static DelegateBridge __Hotfix0_Init;

	private static DelegateBridge __Hotfix0_Open;

	private static DelegateBridge __Hotfix0_Close;

	private static DelegateBridge __Hotfix0_OnLanguageChange;

	private static DelegateBridge __Hotfix0_Refresh;

	private static DelegateBridge __Hotfix0_CountDown;

	private static DelegateBridge __Hotfix0_GetObjectPositionNextFrame;

	private static DelegateBridge __Hotfix0_RefreshLeftTime;

	private static DelegateBridge __Hotfix0_PlayAni;

	private static DelegateBridge __Hotfix0_OnHandleNotification;

	private static DelegateBridge __Hotfix0_StopAni;

	private static DelegateBridge _c__Hotfix0_ctor;

	private ChainGiftManager ChainGiftManager => null;

	private ChainGiftData ChainGiftData => null;

	private ChainGiftRewardData ChainGiftRewardData => null;

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

	private void Refresh(bool isFromOpen)
	{
	}

	[IteratorStateMachine(typeof(_003CCountDown_003Ed__25))]
	private IEnumerator CountDown()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CGetObjectPositionNextFrame_003Ed__26))]
	private IEnumerator GetObjectPositionNextFrame()
	{
		return null;
	}

	private void RefreshLeftTime()
	{
	}

	private void PlayAni(Action callBack)
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	private void StopAni()
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

	private void _003C_003ExLuaBaseProxy_OnHandleNotification(INotification P0)
	{
	}
}
