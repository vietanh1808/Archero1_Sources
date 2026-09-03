using System;
using HeroCapybara;
using UnityEngine;

public class HeroCapybaraSkillVO
{
	public EntityBase m_Entity;

	public string TAG;

	private StateController m_StateController;

	public CapybaraSwordController CapybaraSwordController;

	public HeroCapybaraSkillArgs SkillArgs;

	public Func<float, float> getDeltaMeteorAtkPercent;

	public StateController StateController => null;

	public HeroCapybaraSkillVO(HeroCapybaraSkillArgs _args)
	{
	}

	public void Init()
	{
	}

	public void InitForMulti()
	{
	}

	public void DeInit()
	{
	}

	public void CreateSwordWrapper()
	{
	}

	public void CreateSword(int index)
	{
	}

	private void syncSword(int index)
	{
	}

	public void ReleaseSwordWrapper()
	{
	}

	public void ReleaseSword()
	{
	}

	private void syncReleaseSword()
	{
	}

	private void addReleaseEffect(Vector3 localPos)
	{
	}
}
