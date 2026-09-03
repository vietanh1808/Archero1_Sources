using Dxx.Util;
using UnityEngine;

public class SkillAlone2148 : SkillAloneMeleeBase
{
	private int duration;

	private float energyAddPerHit;

	private float energyAddLimit;

	private float maxResistNum;

	private string shieldName;

	private EntityHero m_hero;

	private bool isCannon;

	private SequencePool mSeqPool;

	private GameObject shield;

	protected override void OnInstall()
	{
	}

	protected virtual void ParseParams()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnSuperSkill(bool flag)
	{
	}

	private void CreateShield()
	{
	}

	public void CreateShield(Vector3 bulletPos)
	{
	}

	private bool OnCheckSuperSkill()
	{
		return false;
	}

	private bool CanSuperSkill()
	{
		return false;
	}

	private void OnLanceChangeState(bool isInCannon)
	{
	}

	private void GotoNextRoom(RoomGenerateBase.Room room)
	{
	}
}
