using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

public class SkillAlone2277 : SkillAloneBase
{
	public class SkillEffect2277_SyncHitVO : CustomJsonActionVO
	{
		public int GuidSource;

		public int GuidTarget;
	}

	[CompilerGenerated]
	private sealed class _003CDelayCall_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkillAlone2277 _003C_003E4__this;

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
		public _003CDelayCall_003Ed__11(int _003C_003E1__state)
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

	private float triggerRate;

	private float hitRate;

	private string HitEffPath;

	private const string SyncSkill2277_SyncHit = "SyncSkill2277_SyncHit";

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void ParseParams()
	{
	}

	private string InitGodPunishEffPath()
	{
		return null;
	}

	private void OnEntityCreated(EntityBase enemy)
	{
	}

	private void Punish(EntityBase souce, EntityBase target, bool isSync)
	{
	}

	private void HitEnermy(EntityBase souce, EntityBase target, bool isSync)
	{
	}

	private void GotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	[IteratorStateMachine(typeof(_003CDelayCall_003Ed__11))]
	private IEnumerator DelayCall()
	{
		return null;
	}

	private void OnHitByGodPunish(HitStruct hs)
	{
	}

	private void SyncBullets(int GuidSource, int GuidTatget)
	{
	}

	private void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}
}
