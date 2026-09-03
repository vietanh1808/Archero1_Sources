using System;
using UnityEngine;

public class SkillAlonePetBase : SkillAloneBase
{
	protected BattlePetVO BattlePetVO;

	protected string[] SkillArgs;

	protected int SkillLevel => 0;

	protected override void OnInstall(params object[] args)
	{
	}

	protected override void OnUninstall()
	{
	}

	protected bool IsPetMatched(BattlePetVO vo)
	{
		return false;
	}

	public long GetPlayerAttack(EntityData.AttackValueEnum petAttackValueEnum)
	{
		return 0L;
	}

	private void initSkillArgs()
	{
	}

	private void initBattlePetVO(BattlePetVO vo)
	{
	}

	protected void PrintInfo(string info)
	{
	}

	protected void PrintError(string error)
	{
	}

	protected void preloadBulletModel(int id, Action<GameObject> callback = null)
	{
	}
}
