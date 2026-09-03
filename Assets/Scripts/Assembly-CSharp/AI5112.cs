using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class AI5112 : AIBase
{
	[CompilerGenerated]
	private sealed class _003CcreatePreAlarmCircleAsync_003Ed__55 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public List<Vector3> alarmPosList;

		public AI5112 _003C_003E4__this;

		private int _003Clen_003E5__2;

		private int _003Ci_003E5__3;

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
		public _003CcreatePreAlarmCircleAsync_003Ed__55(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CcreateSlopeBullets_003Ed__56 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public List<Vector3> alarmPosList;

		public AI5112 _003C_003E4__this;

		private int _003Clen_003E5__2;

		private float _003CxPos_003E5__3;

		private int _003Ci_003E5__4;

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
		public _003CcreateSlopeBullets_003Ed__56(int _003C_003E1__state)
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

	private const string SKILL_1_ANIM = "Throw Forward";

	private const string SKILL_2_ANIM = "Throw Into Sky";

	protected const string SKILL_3_ANIM = "Dash And Stab";

	private const string SKILL_4_ANIM = "Summon";

	private const string SKILL_5_ANIM_IDLE2HALF = "Idle To Half Head";

	private const string SKILL_5_ANIM_HALF_HEAD = "Half Head";

	public const string SKILL_5_ANIM_HALF2IDLE = "Half Head To Idle";

	private const string REST_ANIM = "Walk Forward";

	private const int PRE_ALARM_CIRCLE_ID = 3100074;

	private const int TOTAL_SWORD_COUNT = 8;

	private const float RADIUS = 3.5f;

	private const float DELAY_BEFORE_SKILL_2_BULLETS = 0.2f;

	private const float SWORD_FISH_HEIGHT = 30f;

	private const float MIDDLE_POS_PERCENT = 0.99f;

	private float intervalDegrees;

	private const float DELTA_ALARM_CIRCLE = 3f;

	private const float PRE_ALARM_COUNT = 10f;

	private const float ALARM_LIVE_TIME = 0.1f;

	private const float OFFSET_X = 7f;

	private const float OFFSET_Y = 10f;

	private float SLOPE_BULLET_TIME_INTERVAL;

	private const int CALL_ID = 3194;

	private const int MAX_COUNT_PER_CALL = 2;

	private const int MAX_COUNT_IN_STAGE = 4;

	private const int MAX_ACCUMULATED_COUNT = 12;

	private const int MIN_RADIUS = 4;

	private const int MAX_RADIUS = 8;

	private int randomCallId;

	private const float HALF_HEAD_DURATION = 300f;

	private float animTime_idle2half;

	private Vector3 cacheDir;

	protected override void OnInitOnce()
	{
	}

	protected override void OnInit()
	{
	}

	protected override void OnUpdate(float delta)
	{
	}

	private float getAnimTime(string animName)
	{
		return 0f;
	}

	private void playAnim(string animName)
	{
	}

	public virtual ActionBase skill_1()
	{
		return null;
	}

	public ActionBase skill_4()
	{
		return null;
	}

	public virtual ActionSequence skill_5()
	{
		return null;
	}

	protected virtual void OnIdleToHalf()
	{
	}

	protected virtual void OnHalfToIdle()
	{
	}

	private bool checkIfCanCall()
	{
		return false;
	}

	private ActionBase getRandomSkill()
	{
		return null;
	}

	public ActionBase move()
	{
		return null;
	}

	private ActionSequence fireBulletForSkill1()
	{
		return null;
	}

	private GameObject createPreAlarmCircle()
	{
		return null;
	}

	private float getDelayFireTime(int delayFireFrames)
	{
		return 0f;
	}

	public ActionBase skill_2()
	{
		return null;
	}

	private ActionSequence fireBulletForSkill2()
	{
		return null;
	}

	private void throwSwordfishInSky()
	{
	}

	private List<Vector3> createAllPreAlarmCircles()
	{
		return null;
	}

	private void createSwordfishBulletsInSkill2(List<Vector3> posList)
	{
	}

	private Vector3 getCenterPos()
	{
		return default;
	}

	public virtual ActionBase skill_3()
	{
		return null;
	}

	private void fireBulletForSkill3()
	{
	}

	[IteratorStateMachine(typeof(_003CcreatePreAlarmCircleAsync_003Ed__55))]
	private IEnumerator createPreAlarmCircleAsync(List<Vector3> alarmPosList)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CcreateSlopeBullets_003Ed__56))]
	private IEnumerator createSlopeBullets(List<Vector3> alarmPosList)
	{
		return null;
	}
}
