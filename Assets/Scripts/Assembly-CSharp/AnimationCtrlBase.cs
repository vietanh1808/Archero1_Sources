using System;
using System.Collections.Generic;
using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;

public class AnimationCtrlBase
{
	public class AniClass
	{
		protected ObscuredFloat _speedinit;

		protected ObscuredFloat _speed_out;

		protected ObscuredFloat _Speed_Weapon;

		protected ObscuredFloat _speed_in;

		protected ObscuredFloat _Speed;

		protected ObscuredFloat _MaxSpeed;

		public string name { get; private set; }

		public string value { get; set; }

		public bool revert { get; set; }

		private float speedinit
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		private float speed_out
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float Speed_Weapon
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		private float speed_in
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float Speed
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float MaxSpeed
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public List<string> action_list { get; private set; }

		public Action eventCmd { get; set; }

		public float Speed_In => 0f;

		public AniClass(string name, string value, List<string> action_list)
		{
		}

		public void InitSpeedInit(float speed)
		{
		}

		public void UpdateSpeedOut(float speed)
		{
		}

		public void UpdateSpeedIn(float speed)
		{
		}

		public void InitSpeedMax(float speed)
		{
		}

		public void UpdateSpeedWeapon(float speed)
		{
		}

		private void UpdateSpeed()
		{
		}

		public float GetSpeed()
		{
			return 0f;
		}

		public void AddAction(string action)
		{
		}

		public bool HaveEvent(string name)
		{
			return false;
		}
	}

	public const string AttackPrev = "AttackPrev";

	public const string AttackEnd = "AttackEnd";

	public const string Call = "Call";

	public const string Dead = "Dead";

	public const string Hitted = "Hitted";

	public const string Run = "Run";

	public const string Idle = "Idle";

	public const string Skill = "Skill";

	public const string Dizzy = "Dizzy";

	public const string Continuous = "Continuous";

	public const string SkillEnd = "SkillEnd";

	public const string TouchMoveJoy = "TouchMoveJoy";

	protected Dictionary<string, AniClass> mAniStringList;

	protected Dictionary<string, bool> mAniBoolList;

	protected bool bPlayHittedAction;

	private List<string> mGlobalActList;

	private Action<string, float> mActionSpeed;

	private Action mActionHitted;

	protected AniClass PrevState;

	protected AniClass CurrentState;

	protected Animation ani;

	protected Animation[] m_aryAllAnis;

	protected AnimatorBase mAniBase;

	protected EntityBase m_Entity;

	protected bool mAttackInterrupt;

	private bool bHittedCallback;

	private bool bInit;

	protected Dictionary<string, ActionBasic> mActionList;

	private const string ANIM_LOG = "[ANIM-TEST]";

	public string CurrentStateName => null;

	public List<string> GetAllAnims()
	{
		return null;
	}

	public bool GetPlayHittedCallback()
	{
		return false;
	}

	public virtual void OnStart()
	{
	}

	public void DeInit()
	{
	}

	public void SetAnimation(Animation ani)
	{
	}

	public void SetExtraAnimations(Animation[] anis)
	{
	}

	public void SetExtraAnimation(Animation ani)
	{
	}

	public void RemoveAnimation(Animation ani)
	{
	}

	public void AddNextAnimName(string anim, string name)
	{
	}

	public void SetAnimationValue(string name, string value = "")
	{
	}

	public string GetAnimationValue(string name)
	{
		return null;
	}

	public void SetAnimationClear(string name)
	{
	}

	public float GetAnimationTime(string name)
	{
		return 0f;
	}

	public void EnableAnimLoop(string name)
	{
	}

	public void SetAnimWrapMode(string name, WrapMode wrapMode)
	{
	}

	public float GetAnimationSpeed(string name)
	{
		return 0f;
	}

	public AnimationState GetAnimState(string animName)
	{
		return null;
	}

	public void UpdateAnimationSpeed(string name, float speed)
	{
	}

	public float GetSpeedIn(string name)
	{
		return 0f;
	}

	public void UpdateSpeedOut(float speed)
	{
	}

	public void InitWeaponSpeed(float speed)
	{
	}

	public void InitWeaponSpeed(float speed, float maxSpeed)
	{
	}

	public void UpdateAttackPrevSpeed(float speed)
	{
	}

	public void UpdateWeaponSpeed(float speed)
	{
	}

	public void SetAllSpeed(float speed)
	{
	}

	public void UpdateAnimationSpeed(string name)
	{
	}

	public void ReplayCurrentState()
	{
	}

	public void SetAnimationRevert(string name, bool revert)
	{
	}

	public bool GetAnimationRevert(string name)
	{
		return false;
	}

	public void SetBool(string name, bool value)
	{
	}

	public virtual void SetAnimatorBase(AnimatorBase b)
	{
	}

	public void SetHittedCallBack(Action callback)
	{
	}

	public void SetHeroPlayMakerColtrol(HeroPlayMakerControl ctrl)
	{
	}

	public void Reborn()
	{
	}

	public void SetDontPlayHittedAction()
	{
	}

	public void SetPlayHittedAction()
	{
	}

	public void ForcePlay(string eventName)
	{
	}

	public virtual void SendEvent(string eventName, bool force = false)
	{
	}

	public bool IsAnimNamePlaying(string animName)
	{
		return false;
	}

	public void TempAnimWarning(string animName)
	{
	}

	public bool HasClip(string animName)
	{
		return false;
	}

	protected virtual void ChangeState(AniClass state)
	{
	}

	public void ForcePlayCurState()
	{
	}

	public bool IsCurrentState(string state)
	{
		return false;
	}

	protected void ResetPrevState()
	{
	}

	public virtual void DizzyEnd()
	{
	}

	private void Event_AttackPrev()
	{
	}

	protected virtual void Event_AttackPrevI(AniClass a)
	{
	}

	private void Event_AttackEnd()
	{
	}

	protected virtual void Event_AttackEndI(AniClass a)
	{
	}

	private void Event_Call()
	{
	}

	protected virtual void Event_CallI(AniClass a)
	{
	}

	private void Event_Skill()
	{
	}

	protected virtual void Event_SkillI(AniClass a)
	{
	}

	private void Event_Continuous()
	{
	}

	protected virtual void Event_ContinuousI(AniClass a)
	{
	}

	private void Event_Dizzy()
	{
	}

	private void Event_SkillEnd()
	{
	}

	protected virtual void Event_SkillEndI(AniClass a)
	{
	}

	protected virtual void AttackInterrupt()
	{
	}

	protected virtual void Event_DizzyI(AniClass a)
	{
	}

	private void Event_Dead()
	{
	}

	protected virtual void Event_DeadI(AniClass a)
	{
	}

	private void Event_Idle()
	{
	}

	protected virtual void Event_IdleI(AniClass a)
	{
	}

	private void Event_Run()
	{
	}

	protected virtual void Event_RunI(AniClass a)
	{
	}

	private void Event_Hitted()
	{
	}

	protected virtual void Event_HittedZI(AniClass a)
	{
	}

	public void UpdateTouch()
	{
	}

	public void ForceUpdateTouch()
	{
	}

	private bool IsWuKongSkillAnim()
	{
		return false;
	}

	private bool IsSharkSkillAnim()
	{
		return false;
	}

	private bool IsSkill1823Anim()
	{
		return false;
	}

	private void StopAllActions()
	{
	}

	protected void PlayHittedAction(bool value)
	{
	}

	public void AddExtraAnimClassWrap(string animName, List<string> list = null)
	{
	}

	public void AddExtraAnimClass(string animName, AniClass animClass)
	{
	}

	public void RemoveExtraAnimClass(string animName)
	{
	}

	public AniClass ChangeAnimClass(string animName, AniClass animClass)
	{
		return null;
	}

	public void ClearAttackEndAction()
	{
	}

	public void ClearAttackPrevAction()
	{
	}
}
