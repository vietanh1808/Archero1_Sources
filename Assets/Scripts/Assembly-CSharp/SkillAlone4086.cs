using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SkillAlone4086 : SkillAlone1033_Net
{
	public class SkillEffect4086Action : CustomJsonActionVO
	{
	}

	[CompilerGenerated]
	private sealed class _003CPlayerTransformedEff_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkillAlone4086 _003C_003E4__this;

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
		public _003CPlayerTransformedEff_003Ed__21(int _003C_003E1__state)
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

	protected const string String_HittedCallRate = "HittedCallRate";

	protected const string String_BuffId = "BuffId";

	protected const string String_PartBodyCount = "PartBodyCount";

	private float effectRate;

	private int buffId;

	private int partBodyCount;

	private float duration;

	private int effectTime;

	private int curEffectTimes;

	private float transformedEffectDelayTime;

	private int transformEffectId;

	private int transformedEffectId;

	private GameObject transformEffect;

	private GameObject transformedEffect;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	protected override void Excute(string str, bool bExcute = false)
	{
	}

	private void OnHitted(EntityBase enemy, long hit)
	{
	}

	private void GotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void CallArchorParts(EntityBase enemy)
	{
	}

	private void PlayTransformEff()
	{
	}

	[IteratorStateMachine(typeof(_003CPlayerTransformedEff_003Ed__21))]
	private IEnumerator PlayerTransformedEff()
	{
		return null;
	}

	private void SyncPlayEff()
	{
	}

	private void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}
}
