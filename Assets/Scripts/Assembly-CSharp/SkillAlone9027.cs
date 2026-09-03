using UnityEngine;

public class SkillAlone9027 : SkillAloneBase
{
	private float lastCheckTime;

	private bool isFireState;

	private float m_needTime;

	private int m_buffId;

	private float m_checkHP;

	private float m_recoverHP;

	private float m_attackRate;

	private float m_critRate;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void addState()
	{
	}

	private void removeState()
	{
	}

	private void OnReborn()
	{
	}

	protected void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void CheckAndActivateFireState()
	{
	}

	private void OnChangeHP(long currentHP, long maxHP, float percent, long change)
	{
	}

	private void onKillEnd(EntityBase attackTarget, Vector3 HittedDirection, HitStruct hs)
	{
	}
}
