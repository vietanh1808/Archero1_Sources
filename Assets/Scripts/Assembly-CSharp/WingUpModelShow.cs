using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class WingUpModelShow : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CCreateWing_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public WingUpModelShow _003C_003E4__this;

		private IResourcesLoader _003Ctloader_003E5__2;

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
		public _003CCreateWing_003Ed__8(int _003C_003E1__state)
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

	public RawImage img_heroShow;

	private HeroShow wingShow;

	private GameObject m_WingModel;

	private Coroutine m_CreateWingCoroutine;

	private LocalSave.WingOne wing;

	public void Init()
	{
	}

	public void Open(LocalSave.WingOne wing)
	{
	}

	private void Refresh()
	{
	}

	[IteratorStateMachine(typeof(_003CCreateWing_003Ed__8))]
	private IEnumerator CreateWing()
	{
		return null;
	}

	protected string GetWingString(int wingId)
	{
		return null;
	}

	public void RegistEnent()
	{
	}

	public void UnRegistEvent()
	{
	}

	private void OnStarUp()
	{
	}

	public void RefreshStar(int star)
	{
	}

	public void Close()
	{
	}
}
