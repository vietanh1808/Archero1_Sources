using System;

public class FlashSuperSkillVO
{
	private const string UPDATE_NAME = "FlashSuperSkillVO-Update";

	public EntityHero m_Entity;

	public float ConfigFlashSuperSkillTime;

	public float FlashUpdateStep;

	public Action OnSuperSkillStartCallback;

	public Action OnSuperSkillEndCallback;

	private float flashSuperSkillTime;

	protected bool m_bSuperSkill;

	private float m_fTime;

	public virtual void Init()
	{
	}

	public virtual void DeInit()
	{
	}

	private bool CanSaveSuperSkillCD()
	{
		return false;
	}

	private bool CanSuperSkillCD()
	{
		return false;
	}

	private bool CanSuperSkill()
	{
		return false;
	}

	private bool OnCheckSuperSkill()
	{
		return false;
	}

	private void OnSuperSkill(bool flag)
	{
	}

	protected void OnSuperSkillEnd()
	{
	}

	protected void OnUpdate(float delta)
	{
	}

	public virtual bool IsSuperSkillWorking()
	{
		return false;
	}
}
