using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SkillAlone1626 : SkillAloneBase
{
	[CompilerGenerated]
	private sealed class _003CInvokeDelay_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkillAlone1626 _003C_003E4__this;

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
		public _003CInvokeDelay_003Ed__12(int _003C_003E1__state)
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

	private float sliderPauseTime;

	private float impulseRiseRate;

	private int hitRiseBuffId;

	private int recoverBuffId;

	private float explodeHitRatio;

	private float explodeHitRadius;

	private const int explodeBulletId = 8915;

	private const string headTopEffPath = "Effect/Battle/eff_arthur_younger_draw_end";

	private GameObject headTopEff;

	private const int effStep1Y = 4;

	private const int effStep2Y = 3;

	protected override void OnInstall()
	{
	}

	[IteratorStateMachine(typeof(_003CInvokeDelay_003Ed__12))]
	private IEnumerator InvokeDelay()
	{
		return null;
	}

	private void ParseParams()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void IsEnterKnightKing(bool isKnight)
	{
	}

	private void IsEnterKnightKingPause(bool isKnightPause)
	{
	}

	public BulletBase CreateExplodeHit(int bulletId, Vector3 bulletPos, float atkPercent, float radius)
	{
		return null;
	}
}
