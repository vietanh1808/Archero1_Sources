using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TableTool;
using UnityEngine;
using UnityEngine.UI;

public class SkyLanternModelShowPart : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CCreateHero_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkyLanternModelShowPart _003C_003E4__this;

		public int newClothid;

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
		public _003CCreateHero_003Ed__12(int _003C_003E1__state)
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
	private sealed class _003CCreateWing_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkyLanternModelShowPart _003C_003E4__this;

		public LocalSave.WingOne wing;

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
		public _003CCreateWing_003Ed__16(int _003C_003E1__state)
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
	private sealed class _003Cinit_cloth_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public int clothid;

		public SkyLanternModelShowPart _003C_003E4__this;

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
		public _003Cinit_cloth_003Ed__13(int _003C_003E1__state)
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

	public WeaponSkinWeaponItem weaponSkinWeaponItem;

	public DxxText nameText;

	public GameObject exchangeObj;

	private HeroShow heroShow;

	private HeroShow wingShow;

	private HeroShow petShow;

	private BodyMask m_Body;

	private GameObject m_WingModel;

	private Coroutine m_CreateWingCoroutine;

	public void Init()
	{
	}

	public void Open(Drop_DropModel.DropData data, float scale)
	{
	}

	[IteratorStateMachine(typeof(_003CCreateHero_003Ed__12))]
	private IEnumerator CreateHero(int newClothid)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003Cinit_cloth_003Ed__13))]
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

	[IteratorStateMachine(typeof(_003CCreateWing_003Ed__16))]
	private IEnumerator CreateWing(LocalSave.WingOne wing)
	{
		return null;
	}

	protected string GetWingString(int wingId)
	{
		return null;
	}

	private void CreatPet(LocalSave.PetOne pet)
	{
	}

	public void Close()
	{
	}
}
