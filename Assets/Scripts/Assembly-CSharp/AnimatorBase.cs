using UnityEngine;

public class AnimatorBase
{
	public const int FRAMES_PER_SECOND = 30;

	public const int AttackPrev = 20;

	public const int AttackNext = 21;

	public const int Dead = 100;

	public const int Hitted = 200;

	public EntityBase m_Entity;

	protected Animation m_AnimationBase;

	public virtual void Init(EntityBase entity)
	{
	}

	public void UpdateAnimationBase()
	{
	}

	public void DeInit()
	{
	}

	public void SendEvent(string eventName, bool force = false)
	{
	}

	public void Reborn()
	{
	}

	public float GetAnimationTime(string eventName)
	{
		return 0f;
	}

	public float GetTotalFrames(string eventName)
	{
		return 0f;
	}

	public string GetAnimationValue(string eventName)
	{
		return null;
	}

	public void DeadDown()
	{
	}

	public void ClearString(string name)
	{
	}

	public void SetString(string name, string value = "")
	{
	}

	public string GetString(string name)
	{
		return null;
	}

	public void SetBool(string name, bool value)
	{
	}

	public void SetTouchMoveJoy(bool value)
	{
	}

	public void SetAttackPrevString(string value)
	{
	}

	public void SetAttackEndString(string value)
	{
	}

	public float GetSkillAnimationTime()
	{
		return 0f;
	}

	public float GetCallAnimationTime()
	{
		return 0f;
	}
}
