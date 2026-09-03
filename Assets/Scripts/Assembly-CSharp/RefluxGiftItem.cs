using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using XLua;

public class RefluxGiftItem : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CCountdown_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RefluxGiftItem _003C_003E4__this;

		public long time;

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
		public _003CCountdown_003Ed__22(int _003C_003E1__state)
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

	public DxxText nameTex;

	public Transform itemsParent;

	public GameObject progressObj;

	public RectTransform sliderbg;

	public RectTransform slider;

	public DxxText progressTex;

	public ButtonCtrl getBtn;

	public DxxText getBtnTex;

	public DxxText timeTex;

	public List<DxxImage> Imgs;

	public GameObject maskObj;

	public GameObject getMaskObj;

	private ActivityRefluxRewardItemJsonData dayReward;

	private List<PropOneEquip> items;

	private Action ClickCallBack;

	public Coroutine m_Coroutine;

	private WaitForSeconds wait;

	private static DelegateBridge __Hotfix0_get_Day;

	private static DelegateBridge __Hotfix0_Awake;

	private static DelegateBridge __Hotfix0_Init;

	private static DelegateBridge __Hotfix0_RefreshState;

	private static DelegateBridge __Hotfix0_Countdown;

	private static DelegateBridge __Hotfix0_ShowRewards;

	private static DelegateBridge __Hotfix0_GetData;

	private static DelegateBridge _c__Hotfix0_ctor;

	public int Day => 0;

	private void Awake()
	{
	}

	public void Init(ActivityRefluxRewardItemJsonData jsonData, Action ClickDo)
	{
	}

	public bool RefreshState()
	{
		return false;
	}

	[IteratorStateMachine(typeof(_003CCountdown_003Ed__22))]
	private IEnumerator Countdown(long time)
	{
		return null;
	}

	private void ShowRewards()
	{
	}

	public ActivityRefluxRewardItemJsonData GetData()
	{
		return null;
	}
}
