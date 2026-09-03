using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SkillAlone1964 : SkillAloneBase
{
	public class Skill1Effect1964IgniteVO : CustomJsonActionVO
	{
		public Vector3 pos;
	}

	[CompilerGenerated]
	private sealed class _003CMoonFallEffCor_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkillAlone1964 _003C_003E4__this;

		public Vector3 pos;

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
		public _003CMoonFallEffCor_003Ed__12(int _003C_003E1__state)
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

	private float callMoonFallRate;

	private float callMoonFallCDTime;

	private float fallDelayTime;

	private float columnRadius;

	private float moonFallAtkPercent;

	private Dictionary<int, float> enemyAttackedTimeDic;

	private int moonFallBulletId;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnHitted(EntityBase enemy, HitStruct hs, HittedData ht)
	{
	}

	private void CreatMoonFallWithSyn(Vector3 pos)
	{
	}

	private void MoonFallEff(Vector3 pos)
	{
	}

	[IteratorStateMachine(typeof(_003CMoonFallEffCor_003Ed__12))]
	private IEnumerator MoonFallEffCor(Vector3 pos)
	{
		return null;
	}

	private void SyncCastSkillMsg(Vector3 pos)
	{
	}

	private void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}
}
