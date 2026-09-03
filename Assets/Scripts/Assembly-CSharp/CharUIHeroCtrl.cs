using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Dxx.Util;
using TableTool;
using UnityEngine;
using UnityEngine.UI;
using homepage;

public class CharUIHeroCtrl : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass47_0
	{
		public CharUIHeroCtrl _003C_003E4__this;

		public int index;

		public Character_Char chardata;

		internal void _003Cinit_pet_003Eb__0(GameObject o2)
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003Cinit_cloth_003Ed__40 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CharUIHeroCtrl _003C_003E4__this;

		public int nCharId;

		public int nSkinId;

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
		public _003Cinit_cloth_003Ed__40(int _003C_003E1__state)
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
	private sealed class _003Cinit_pet_003Ed__47 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CharUIHeroCtrl _003C_003E4__this;

		public int index;

		private _003C_003Ec__DisplayClass47_0 _003C_003E8__1;

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
		public _003Cinit_pet_003Ed__47(int _003C_003E1__state)
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

	private const int CUR_MESH_ORDER = 21;

	public string HeroShowName;

	public RawImage img_heroShow;

	protected HeroShow heroShow;

	public GameObject child;

	public GameObject[] petsparent;

	public GameObject effectparent;

	public bool isShowWing;

	protected BodyMask m_Body;

	private GameObject weaponobj;

	private GameObject dualWeaponObj;

	private GameObject[] pets;

	protected int weaponid;

	protected int weaponHandId;

	protected int clothid;

	private int[] petsid;

	private SequencePool mSeqPool;

	private bool bChildShow;

	protected bool bShow;

	protected bool bShowEffect;

	protected Dictionary<int, GameObject> mChangeEffects;

	private Sequence mSeq;

	private GameObject mMagicBookEffectParent;

	public GameObject mFloor;

	[SerializeField]
	protected RectTransform mBodyEffectParent;

	protected int _skinId;

	protected int _wingId;

	private const int SeniorMagicBookEquipIdPrefix = 1270;

	private const int MagicBookEquipIdPrefx = 1070;

	protected HeroEquipsVO heroEquipsVO;

	protected List<LocalSave.ArtifactOne> artiList;

	protected int artiInUI;

	public int MeshOrder { get; private set; }

	public void OnOpen()
	{
	}

	public void OnClose()
	{
	}

	protected void DestroyHeroShow()
	{
	}

	public void Show(bool value)
	{
	}

	protected virtual int GetWeaponHandId(int weaponId)
	{
		return 0;
	}

	public void InitWeapon(int weaponid)
	{
	}

	public void SetMeshOrder(int order)
	{
	}

	public void RefreshHero()
	{
	}

	public virtual void InitCloth(int clothid, int nSkinId = 0, int nWingId = 0, int wingStar = 0)
	{
	}

	[IteratorStateMachine(typeof(_003Cinit_cloth_003Ed__40))]
	public virtual IEnumerator init_cloth(int nCharId, int nSkinId, int nWingId, int wingStar = 0)
	{
		return null;
	}

	private void createHeroModel(GameObject o2)
	{
	}

	private GameObject createHeroShow(GameObject o2)
	{
		return null;
	}

	public virtual void InitWing(int nModelId, int nSkinId, int wingStar)
	{
	}

	private void PlayWingIdleAni(int nWeaponId, bool bLoadAni = true)
	{
	}

	protected string GetBodyString(string value)
	{
		return null;
	}

	public virtual void InitPet(int index, int petid)
	{
	}

	[IteratorStateMachine(typeof(_003Cinit_pet_003Ed__47))]
	private IEnumerator init_pet(int index)
	{
		return null;
	}

	public void ShowAttributeChange(Dictionary<string, long> attrs)
	{
	}

	public virtual void show_effect(int playerId)
	{
	}

	public void showMagicBookEffect(int id)
	{
	}

	public void hideMagicBookEffect()
	{
	}

	public void SetHeroEquipsVO(HeroEquipsVO vo)
	{
	}

	public void initArtifactShow(List<LocalSave.ArtifactOne> items, int showinui = 0)
	{
	}

	public void SetWeaponColor()
	{
	}
}
