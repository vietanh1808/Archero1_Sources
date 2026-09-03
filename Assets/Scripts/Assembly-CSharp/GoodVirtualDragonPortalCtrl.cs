using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Dxx.Util;
using UnityEngine;

public class GoodVirtualDragonPortalCtrl : MonoBehaviour
{
	public enum DoorState
	{
		eNormal = 0,
		eThrough = 1
	}

	[CompilerGenerated]
	private sealed class _003CDelaySetRendderOrder_003Ed__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GoodVirtualDragonPortalCtrl _003C_003E4__this;

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
		public _003CDelaySetRendderOrder_003Ed__32(int _003C_003E1__state)
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

	private GoodVirtualDragonPortalCtrl another;

	private Action<GoodVirtualDragonPortalCtrl, GoodVirtualDragonPortalCtrl> OnTriggerEvent;

	private EntityBase m_Entity;

	private bool isPortalEnable;

	private List<GoodVirtualDragonPortalCtrl> portalList;

	private Func<GoodVirtualDragonPortalCtrl, GoodVirtualDragonPortalCtrl> GetAnotherPortal;

	private bool isDynamicAnothter;

	private SequencePool mPool;

	private DoorState state;

	public GameObject effect_open;

	public GameObject effect_use;

	public GameObject effect_closed;

	private static readonly string sortingLayerName;

	private ParticleSystemRenderer[] particles;

	private Vector2Int SelfXY;

	private Vector2Int targetXY;

	private bool entered;

	public string UPDATE_NAME => null;

	public void Init(EntityBase entity, Action<GoodVirtualDragonPortalCtrl, GoodVirtualDragonPortalCtrl> OnTriggerEvent, Func<GoodVirtualDragonPortalCtrl, GoodVirtualDragonPortalCtrl> getAnother)
	{
	}

	private void onUpdate(float obj)
	{
	}

	public void SetPortalEnable(bool enable)
	{
	}

	public void Awake()
	{
	}

	public void OnDestroy()
	{
	}

	public void DeInit()
	{
	}

	private void onEnterDoor()
	{
	}

	private void onExitDoor()
	{
	}

	public void SetState(DoorState state)
	{
	}

	private void show_effect_open(bool value)
	{
	}

	private void show_effect_closed(bool value)
	{
	}

	private void show_effect_use(bool value)
	{
	}

	[IteratorStateMachine(typeof(_003CDelaySetRendderOrder_003Ed__32))]
	public IEnumerator DelaySetRendderOrder()
	{
		return null;
	}
}
