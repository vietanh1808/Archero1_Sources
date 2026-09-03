using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class ArtifactModelShow : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CCreateHero_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ArtifactModelShow _003C_003E4__this;

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
		public _003CCreateHero_003Ed__17(int _003C_003E1__state)
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
	private sealed class _003CCreateWing_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ArtifactModelShow _003C_003E4__this;

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
		public _003CCreateWing_003Ed__21(int _003C_003E1__state)
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
	private sealed class _003Cinit_cloth_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public int clothid;

		public ArtifactModelShow _003C_003E4__this;

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
		public _003Cinit_cloth_003Ed__18(int _003C_003E1__state)
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

	public int ui;

	public RawImage img_heroShow;

	public GameObject effectObj;

	public Tween AniUpDown;

	public bool isUpDown;

	public GameObject shineAni;

	private HeroShow heroShow;

	private HeroShow artiShow;

	public bool isShowHero;

	private BodyMask m_Body;

	private GameObject m_artiModel;

	private Coroutine m_CreateWingCoroutine;

	private LocalSave.ArtifactOne artiOne;

	public void Init()
	{
	}

	public void Open(LocalSave.ArtifactOne arti, bool showAni = true)
	{
	}

	public void Switch()
	{
	}

	private void Refresh(bool showAni = true)
	{
	}

	[IteratorStateMachine(typeof(_003CCreateHero_003Ed__17))]
	private IEnumerator CreateHero()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003Cinit_cloth_003Ed__18))]
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

	[IteratorStateMachine(typeof(_003CCreateWing_003Ed__21))]
	private IEnumerator CreateWing()
	{
		return null;
	}

	protected string GetWingString(string modelId)
	{
		return null;
	}

	public void Close()
	{
	}

	public void PlayAni_UpDown()
	{
	}
}
