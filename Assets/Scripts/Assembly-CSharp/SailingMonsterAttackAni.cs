using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using GameProtocol;
using UnityEngine;

public class SailingMonsterAttackAni : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CStartAutoPlay_003Ed__48 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SailingMonsterAttackAni _003C_003E4__this;

		private List<SailingMonsterShipAutoFireData>.Enumerator _003C_003E7__wrap1;

		private SailingMonsterShipAutoFireData _003CaData_003E5__3;

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
		public _003CStartAutoPlay_003Ed__48(int _003C_003E1__state)
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

		private void _003C_003Em__Finally1()
		{
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[SerializeField]
	private RectTransform target;

	[SerializeField]
	private GameObject targetBeHitEffect;

	[SerializeField]
	private GameObject prePremiumStartHitEffect;

	[SerializeField]
	private GameObject prePremiumLoopHitEffect;

	[SerializeField]
	private GameObject prePremiumEndHitEffect;

	[SerializeField]
	private GameObject preNormalStartHitEffect;

	[SerializeField]
	private GameObject preNormalLoopHitEffect;

	[SerializeField]
	private GameObject preNormalEndHitEffect;

	[SerializeField]
	private Transform effectParent;

	[SerializeField]
	private ButtonCtrl maskBtn;

	[SerializeField]
	private SailingMonsterMCannonAni mcannonAni;

	[SerializeField]
	private SailingMonsterHittedItem damagedAni;

	private List<GameObject> hitEffect;

	private List<SailingMonsterMCannonAni> mcannonItemList;

	private List<SailingMonsterHittedItem> damagedItemList;

	private List<Sequence> MCannonSequenceList;

	private Sequence sequence;

	private Tweener shake;

	private CRespShipBattleSeasonFire response;

	private int oldLevel;

	private List<SailingMonsterMCannonDamageData> damageData;

	private SailingMonsterShipAutoFireData _crtFireData;

	private bool _isAutoFire;

	private bool isAddRate;

	private SailingMCannonType _crtFireType;

	private List<SailingMonsterShipAutoFireData> _autoFireData => null;

	public void Init()
	{
	}

	public void ResetEffectStatus()
	{
	}

	public void SetIsAddRate(bool isAdd)
	{
	}

	public void PlayAni(List<SailingMonsterMCannonDamageData> damageData, CRespShipBattleSeasonFire response, int oldLevel)
	{
	}

	public void Play()
	{
	}

	public void Clear()
	{
	}

	public void PlayStartPreHit()
	{
	}

	public void PlayLoopPreHit()
	{
	}

	public void PlayEndPreHit()
	{
	}

	public void StopAni()
	{
	}

	public void CompleteAni()
	{
	}

	public Tweener PlayArrowAni(SailingMCannonType arrowType)
	{
		return null;
	}

	public void StopArrowAni()
	{
	}

	public void PlayTargetHitAni()
	{
	}

	public void StopTargetHitAni()
	{
	}

	public Tweener PlayTargetShakeAni()
	{
		return null;
	}

	public void StopTargetShakeAni()
	{
	}

	public void Click()
	{
	}

	public void PlayRewardAni()
	{
	}

	public Tweener PlayDamageTextAni(int damage, bool isCrit)
	{
		return null;
	}

	public void SetAutoPlay(bool isAutoFire)
	{
	}

	[IteratorStateMachine(typeof(_003CStartAutoPlay_003Ed__48))]
	public IEnumerator StartAutoPlay()
	{
		return null;
	}

	public void AutoPlay(SailingMonsterShipAutoFireData aData)
	{
	}

	public void SetMonsterData(RectTransform target)
	{
	}
}
