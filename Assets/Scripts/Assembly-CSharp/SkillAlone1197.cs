using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SkillAlone1197 : SkillAloneMagicBookBase
{
	[CompilerGenerated]
	private sealed class _003CClearFirePath_003Ed__40 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkillAlone1197 _003C_003E4__this;

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
		public _003CClearFirePath_003Ed__40(int _003C_003E1__state)
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

	private float time;

	private float time2;

	private const float totalTime = 0.5f;

	private int total;

	private int m_nBodyScaleTarget;

	private float m_fShieldValuePercent;

	private float m_fBodyHitRatio;

	private long m_lBodyHit;

	private float m_fThunderRadius;

	private float m_fThunderAttackRatio;

	private List<int> m_listSwordIds;

	private Dictionary<int, int> m_dicSwordSkillMutexMap;

	private GameObject good;

	private ParticleSystem mParticle;

	private SkillAlone1014Ctrl ctrl;

	private AutoDespawn mAutoDespawn;

	private bool m_bIsWaveRoom;

	private int[] RotateSwordSkillIds;

	private bool EnergyFull => false;

	private bool ShieldEmpty => false;

	private bool HaveAliveEnermy => false;

	private bool IsAngleRoom => false;

	private bool IsDoorOpen => false;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void DeInitGood()
	{
	}

	protected override bool OnExcuteOneArg(string str)
	{
		return false;
	}

	private void OnUpdate(float delta)
	{
	}

	private void CoundDown(float delta)
	{
	}

	private void OnAttackPre()
	{
	}

	private void BreakOut()
	{
	}

	private void Over()
	{
	}

	private void ToBig(float delta)
	{
	}

	private void ToSmall(float delta)
	{
	}

	private void ExcuteAttribute(string name, long value)
	{
	}

	private void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	[IteratorStateMachine(typeof(_003CClearFirePath_003Ed__40))]
	private IEnumerator ClearFirePath()
	{
		return null;
	}

	private void OnPositionBy(Vector3 p)
	{
	}

	private void CreateFirePath()
	{
	}

	private void CreateThunder()
	{
	}

	private void OnLearnNewSkill(int id)
	{
	}
}
