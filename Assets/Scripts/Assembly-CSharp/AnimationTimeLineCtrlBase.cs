using System;
using System.Collections.Generic;

public class AnimationTimeLineCtrlBase
{
	public class AniClass
	{
		private float speedinit;

		public string name { get; private set; }

		public string value { get; set; }

		public bool revert { get; set; }

		private float speed_out { get; set; }

		public float Speed_Weapon { get; private set; }

		private float speed_in { get; set; }

		public float Speed { get; private set; }

		public List<string> action_list { get; private set; }

		public Action eventCmd { get; set; }

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

	public enum AniState
	{
		none = 0,
		normal = 1,
		hit = 2,
		dead = 3,
		attack = 4
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

	protected Dictionary<string, ActionBasic> mActionList;

	protected Action actionHitted;

	protected EntityTimeLineBase owner;

	protected AniState state;

	public void Init(EntityTimeLineBase pW)
	{
	}

	public void InitWeaponSpeed(float speed)
	{
	}

	public void Dispose()
	{
	}

	public void ClearAllAction()
	{
	}

	public void SetString(string name, string value = "")
	{
	}

	public string GetString(string name)
	{
		return null;
	}

	public void SetAnimationValue(string name, string value = "")
	{
	}

	public string GetAnimationValue(string name)
	{
		return null;
	}

	public void SetAnimationSpeed(string name, float speed)
	{
	}

	public AniClass GetAniClass(string name)
	{
		return null;
	}

	protected void UpdateAnimationSpeed(string name)
	{
	}

	public void SetHittedCallBack(Action callback)
	{
	}

	protected float PlayAnimation(AniClass pAni)
	{
		return 0f;
	}

	protected void WaitAni(AniClass pAni, float waitTime, Action act)
	{
	}

	public virtual void RunState(Action pOnComplete = null)
	{
	}

	public virtual void NormalState(Action pOnComplete = null)
	{
	}

	public virtual void HitState(Action pOnComplete = null)
	{
	}

	public virtual float DeadState(Action pOnComplete = null)
	{
		return 0f;
	}

	public virtual void StartAttack(Action pOnComplete = null)
	{
	}

	public virtual void EndAttack(Action pOnComplete = null)
	{
	}

	public virtual float OnDeadState(AniClass pAni, Action pOnComplete = null)
	{
		return 0f;
	}

	public virtual void OnHitState(AniClass pAni, Action pOnComplete = null)
	{
	}

	protected virtual void OnStartAttack(AniClass pAni, Action pOnComplete = null)
	{
	}

	protected virtual void OnEndtAttack(AniClass pAni, Action pOnComplete = null)
	{
	}
}
