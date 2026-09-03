using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class WingModelShowPart : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CCreateHero_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public WingModelShowPart _003C_003E4__this;

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
		public _003CCreateHero_003Ed__14(int _003C_003E1__state)
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
	private sealed class _003CCreateWing_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public WingModelShowPart _003C_003E4__this;

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
		public _003CCreateWing_003Ed__18(int _003C_003E1__state)
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
	private sealed class _003Cinit_cloth_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public int clothid;

		public WingModelShowPart _003C_003E4__this;

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
		public _003Cinit_cloth_003Ed__15(int _003C_003E1__state)
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

	public GameObject effectObj;

	private HeroShow heroShow;

	private HeroShow wingShow;

	public bool isShowHero;

	private BodyMask m_Body;

	private GameObject m_WingModel;

	private Coroutine m_CreateWingCoroutine;

	private LocalSave.WingOne wing;

	private bool mIsPreviewMax;

	public void Init()
	{
	}

	public void Open(LocalSave.WingOne wing, bool isPreViewMax)
	{
	}

	public void Switch()
	{
	}

	private void Refresh()
	{
	}

	[IteratorStateMachine(typeof(_003CCreateHero_003Ed__14))]
	private IEnumerator CreateHero()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003Cinit_cloth_003Ed__15))]
	private IEnumerator init_cloth(int clothid)
	{
		return null;
	}

	private void createHeroModel(GameObject o2)
	{
	}

	protected string GetBodyString(string value)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CCreateWing_003Ed__18))]
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

	public void Close()
	{
	}
}
