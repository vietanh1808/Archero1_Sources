using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

public class SkillAlone1989 : SkillAloneBase
{
	public class SkillEffect1989_CreatPumpkinBomb : CustomJsonActionVO
	{
		public int guid;
	}

	[CompilerGenerated]
	private sealed class _003CChangeBoxingGloveEffectId_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EntityHero hero;

		public int id;

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
		public _003CChangeBoxingGloveEffectId_003Ed__12(int _003C_003E1__state)
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

	private int buffId1;

	private float addBombRate;

	private float explodeDelayTime;

	private float explodeRange;

	private float damageRate;

	private int buffId2;

	private int addBombCDTime;

	private float preAddBombTime;

	private const int PUMPKIN_BULLET_ID = 1570;

	private const int superSkillEffectId = 3411660;

	private Dictionary<int, int> haveBombDict;

	protected override void OnInstall()
	{
	}

	[IteratorStateMachine(typeof(_003CChangeBoxingGloveEffectId_003Ed__12))]
	private IEnumerator ChangeBoxingGloveEffectId(EntityHero hero, int id)
	{
		return null;
	}

	protected override void OnUninstall()
	{
	}

	private void OnHitEnemy(EntityBase enemy, HitStruct hs, HittedData ht)
	{
	}

	private void CreatePumpkinBomb(EntityBase target)
	{
	}

	private void RemoveGuid(int guid)
	{
	}

	private void OnAbsorbHpFood(FoodBase food)
	{
	}

	private void SyncCastSkillMsg(int guid)
	{
	}

	private void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}
}
