using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SkillAlone1499 : SkillAloneBase
{
	[CompilerGenerated]
	private sealed class _003CTimer_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkillAlone1499 _003C_003E4__this;

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
		public _003CTimer_003Ed__24(int _003C_003E1__state)
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

	private float INTERVAL;

	private int CHARGE_ADD;

	private int CHARGE_MAX;

	private int BULLET_MAX;

	private float RATIO_1;

	private float RADIUS;

	private float RATIO_2;

	private int DEBUFFID;

	private int m_nCharge;

	private int m_nBulletCnt;

	private int m_nAddFlag;

	private bool m_bIsWaveRoom;

	protected EntityHero mHero;

	private List<BulletBase> m_listForwardBullets;

	private Coroutine m_Coroutine;

	private WaitForSeconds m_wait;

	protected virtual int BulletCnt
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void waveroom_playermove(Vector3 moveby)
	{
	}

	private void OnMove(bool value)
	{
	}

	private bool CanTimer()
	{
		return false;
	}

	[IteratorStateMachine(typeof(_003CTimer_003Ed__24))]
	private IEnumerator Timer()
	{
		return null;
	}

	private void OnAttack()
	{
	}

	private void UpdateBulletCnt()
	{
	}

	private void OnCreateForwardBullet(BulletBase bullet)
	{
	}

	private void OnHitWall(BulletBase bullet, Collider o)
	{
	}

	private void OnBulletCache(BulletBase bullet)
	{
	}

	private void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void OnResetHp()
	{
	}
}
