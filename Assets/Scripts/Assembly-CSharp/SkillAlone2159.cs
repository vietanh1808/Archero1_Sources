using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SkillAlone2159 : SkillAloneBase
{
	[CompilerGenerated]
	private sealed class _003CSendHit_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkillAlone2159 _003C_003E4__this;

		public EntityBase entity;

		public HitStruct hs;

		private int _003Ccnt_003E5__2;

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
		public _003CSendHit_003Ed__11(int _003C_003E1__state)
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

	private float CONFIG_RATE;

	private int CONFIG_ADD_BLACK_ENERGY;

	private int _oldWeapon;

	private bool _attack;

	private Dictionary<int, int> _map;

	private WaitForSeconds _wait;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private bool CanAutoRotate()
	{
		return false;
	}

	private int OnMeleeAttackStartPre(int id)
	{
		return 0;
	}

	private void OnHit(EntityBase entity, HitStruct hs, HittedData data)
	{
	}

	[IteratorStateMachine(typeof(_003CSendHit_003Ed__11))]
	private IEnumerator SendHit(EntityBase entity, HitStruct hs)
	{
		return null;
	}

	private void OnAttackPre()
	{
	}

	private void OnAttackEnd()
	{
	}

	private bool CanRotate()
	{
		return false;
	}
}
