using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SkillAlone2178 : SkillAloneBase
{
	[Serializable]
	private class SyncSkill2178WaterRainVO : CustomJsonActionVO
	{
		public Vector3 Center;

		public float Duration;
	}

	[CompilerGenerated]
	private sealed class _003CWaterRainCoroutine_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SkillAlone2178 _003C_003E4__this;

		public Vector3 center;

		public float duration;

		private float _003Celapsed_003E5__2;

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
		public _003CWaterRainCoroutine_003Ed__21(int _003C_003E1__state)
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

	private float rainRadius;

	private float damageInterval;

	private float damageRatio;

	private float baseDuration;

	private int slowDebuffId;

	private float cooldown;

	private float battleStateExtraTime;

	private float lastTriggerTime;

	private bool isInBattleState;

	private Coroutine rainCoroutine;

	private const int WaterBulletId = 1621;

	private const string WaterRainEffPath = "Effect/Battle/eff_water_rain";

	private const string WaterRainEffPVPPath = "Effect/Battle/eff_water_rain_pvp";

	private GameObject rainEff;

	private const string SyncSkill2178_WaterRain = "SyncSkill2178_WaterRain";

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void ParseParams()
	{
	}

	private void OnAquaStateChanged(bool enterBattle)
	{
	}

	private void OnFrozen(bool isFrost, BuffAloneBase buff)
	{
	}

	private void StartWaterRain(Vector3 center, float duration)
	{
	}

	[IteratorStateMachine(typeof(_003CWaterRainCoroutine_003Ed__21))]
	private IEnumerator WaterRainCoroutine(Vector3 center, float duration)
	{
		return null;
	}

	private void CreateWaterRainBullet(Vector3 center)
	{
	}

	private void GotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void SyncWaterRain(Vector3 center, float duration)
	{
	}

	private void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}
}
