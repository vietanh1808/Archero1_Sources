using System;
using UnityEngine;

public class SkillAlone2103GoodCtrl : SkillAlone1928GoodCtrl
{
	protected float backRatio;

	private int IsSkill2Effect;

	protected int debuffId;

	private int hitIndex;

	private Action<int> ReduceCdTime;

	public void SetDebuff(int isEffect, int debuffId)
	{
	}

	public virtual void Refresh(float radius, float playSpeed, float igniteDmgMult, float backRatio, Vector3 pos, Action<int> action, float time = 0f)
	{
	}

	protected override void AttackEnemy(EntityBase entity)
	{
	}
}
