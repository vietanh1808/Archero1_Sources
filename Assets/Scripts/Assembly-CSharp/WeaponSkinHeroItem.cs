using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Dxx.Util;
using TableTool;
using UnityEngine;
using UnityEngine.UI;

public class WeaponSkinHeroItem : MonoBehaviour
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct _003C_003Ec__DisplayClass17_0
	{
		public WeaponSkinHeroItem _003C_003E4__this;

		public int colorId;
	}

	[CompilerGenerated]
	private sealed class _003CInitWeapon_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public WeaponSkinHeroItem _003C_003E4__this;

		public int colorId;

		public int weaponid;

		private _003C_003Ec__DisplayClass17_0 _003C_003E8__1;

		private Weapon_weapon _003Cweapondata_003E5__2;

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
		public _003CInitWeapon_003Ed__17(int _003C_003E1__state)
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
	private sealed class _003Cinit_cloth_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public WeaponSkinHeroItem _003C_003E4__this;

		public Weapon_weapon weaponData;

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
		public _003Cinit_cloth_003Ed__14(int _003C_003E1__state)
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

	private HeroShow heroShow;

	public GameObject child;

	protected BodyMask m_Body;

	private List<GameObject> weaponobj;

	protected int weaponid;

	protected int weaponHandId;

	protected int clothid;

	protected int colorID;

	private SequencePool mSeqPool;

	protected bool bShow;

	public GameObject ChangeEffect;

	private GameObject curWeaponObj;

	public void Show(bool value)
	{
	}

	[IteratorStateMachine(typeof(_003Cinit_cloth_003Ed__14))]
	private IEnumerator init_cloth(Weapon_weapon weaponData)
	{
		return null;
	}

	private void createHeroModel(GameObject o2, Weapon_weapon weaponData)
	{
	}

	private GameObject createHeroShow(GameObject o2, Weapon_weapon weaponData)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CInitWeapon_003Ed__17))]
	public IEnumerator InitWeapon(int weaponid, int colorId = 0)
	{
		return null;
	}

	protected int GetWeaponHandId(int weaponId)
	{
		return 0;
	}

	private int GetWeaponIdById(int weaponId)
	{
		return 0;
	}

	protected string GetBodyString(string value)
	{
		return null;
	}

	public void HideHero()
	{
	}

	public void ShowChangeEffect()
	{
	}

	private void ResetWeaponMaterials(GameObject weaponObj)
	{
	}

	public void SetWeaponColor(int colorID)
	{
	}
}
