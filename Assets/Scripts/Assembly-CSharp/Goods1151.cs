using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Dxx.Util;
using UnityEngine;

public class Goods1151 : GoodsBase
{
	public class Door1151
	{
		public List<Goods1151> Doors;

		public void AddDoor(Goods1151 d)
		{
		}

		public void GotoDoor(Goods1151 d)
		{
		}

		private Goods1151 GetOtherDoor(Goods1151 d)
		{
			return null;
		}

		private void OnGotoNextRoom(RoomGenerateBase.Room room)
		{
		}

		public void Clear()
		{
		}

		public void DeInit()
		{
		}
	}

	public enum DoorState
	{
		eNormal = 0,
		eThrough = 1
	}

	[CompilerGenerated]
	private sealed class _003CDelaySetRendderOrder_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Goods1151 _003C_003E4__this;

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
		public _003CDelaySetRendderOrder_003Ed__15(int _003C_003E1__state)
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

	private static Door1151 mDoorData;

	private SequencePool mPool;

	private DoorState state;

	public GameObject effect_open;

	public GameObject effect_use;

	private static readonly string sortingLayerName;

	private ParticleSystemRenderer[] particles;

	public static Door1151 DoorData
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public void SetState(DoorState state)
	{
	}

	protected override void AwakeInit()
	{
	}

	protected override void Init()
	{
	}

	[IteratorStateMachine(typeof(_003CDelaySetRendderOrder_003Ed__15))]
	public IEnumerator DelaySetRendderOrder()
	{
		return null;
	}

	protected override void StartInit()
	{
	}

	protected override void OnDeInit()
	{
	}

	private void show_effect_open(bool value)
	{
	}

	private void show_effect_use(bool value)
	{
	}

	public override void ChildTriggerEnter(GameObject o)
	{
	}

	public override void ChildTriggetExit(GameObject o)
	{
	}
}
