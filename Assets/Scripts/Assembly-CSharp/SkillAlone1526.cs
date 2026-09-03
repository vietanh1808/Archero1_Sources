using UnityEngine;

public class SkillAlone1526 : SkillAloneBase
{
	private float soliderSakuraRate;

	private float bossSakuraRate;

	protected float sakuraInterval;

	protected int maxSakuraCount;

	private int m_sakuraCount;

	private float curTimeInterval;

	protected int CurSakuraCount
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnOpenDoor(RoomGenerateBase.Room room)
	{
	}

	protected virtual void ParseArgs()
	{
	}

	protected override void OnRecvCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO vo)
	{
	}

	protected virtual void InitCurSakuraCount()
	{
	}

	protected virtual void AddCallback()
	{
	}

	protected virtual void RemoveCallback()
	{
	}

	private void onSyncElaineSakuraCount(CustomJsonDataCommand cmd)
	{
	}

	protected void CheckIfProduceSakura(EntityBase attackTarget)
	{
	}

	private void synSakuraCount(int count)
	{
	}

	protected virtual void TryCreateDropHP(EntityBase attackTarget)
	{
	}

	private void onKill(EntityBase attackTarget, Vector3 HittedDirection, HitStruct hs)
	{
	}

	private void onKillMonster(EntityBase attackTarget)
	{
	}

	private void OnResetHp()
	{
	}
}
