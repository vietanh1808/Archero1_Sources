using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TableTool;
using UnityEngine;
using UnityEngine.UI;

public class SailingMainTreasureMapBtn : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003COnUpdate_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SailingMainTreasureMapBtn _003C_003E4__this;

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
		public _003COnUpdate_003Ed__22(int _003C_003E1__state)
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
	private RedNodeCtrl redNodeCtrl;

	[SerializeField]
	private ButtonCtrl btn;

	[SerializeField]
	private GameObject _tips;

	[SerializeField]
	private Image _imgEvent;

	[SerializeField]
	private Image _imgEventMask;

	[SerializeField]
	private ParticleSystem _particleSystem;

	private Coroutine _coroutine;

	private WaitForSeconds _wait;

	public bool IsGuiding => false;

	private int Minute => 0;

	private int Distance => 0;

	private void Awake()
	{
	}

	public void Close()
	{
	}

	public bool IsRed()
	{
		return false;
	}

	public bool IsShow()
	{
		return false;
	}

	public void UpdateUI()
	{
	}

	private void CheckShowUnlockEventUI(IList<ShipBattle_TreasureMap> beans)
	{
	}

	private void CheckRedNode(IList<ShipBattle_TreasureMap> beans)
	{
	}

	private void CheckProcess(IList<ShipBattle_TreasureMap> beans)
	{
	}

	[IteratorStateMachine(typeof(_003COnUpdate_003Ed__22))]
	private IEnumerator OnUpdate()
	{
		return null;
	}

	private void UpdateTreasureEvent()
	{
	}

	private void OnDestroy()
	{
	}
}
