using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class DSMShells : MonoBehaviour
{
	public class TimeLineShellsToPoint : TimeLineItem
	{
		[CompilerGenerated]
		private sealed class _003CMove_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TimeLineShellsToPoint _003C_003E4__this;

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
			public _003CMove_003Ed__5(int _003C_003E1__state)
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

		private Vector3 endPoint;

		private float moveSpeed;

		private Transform self;

		private Vector3 dir;

		public TimeLineShellsToPoint(Transform shell, Vector3 toPoint, float speed)
		{
		}

		[IteratorStateMachine(typeof(_003CMove_003Ed__5))]
		private IEnumerator Move()
		{
			return null;
		}
	}

	[SerializeField]
	private GameObject normalMCannon;

	[SerializeField]
	private GameObject premiumMCannon;

	[SerializeField]
	private Transform shellsParent;

	[SerializeField]
	private GameObject hitEffect;

	[SerializeField]
	private SailingMonsterHittedItem hittedItem;

	private TimeLineContainer timeline;

	[HideInInspector]
	public bool isFinish;

	public Action OnArriveDo;

	public Action OnFinshDo;

	public void Init()
	{
	}

	public void Shoot(Transform launch, Transform target, SailingMonsterMCannonDamageData damageData, int pathPointCount, float shootTime, Vector2 offsetRange)
	{
	}

	public void Close()
	{
	}

	public void RefreshOrder()
	{
	}
}
