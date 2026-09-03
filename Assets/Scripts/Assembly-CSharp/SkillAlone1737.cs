using UnityEngine;

public class SkillAlone1737 : SkillAloneBase
{
	private float CONFIG_CREAT_DIS;

	private float CONFIG_TIME;

	private float CONFIG_HP_PERCENT;

	private int[] CONFIG_DEBUFFS;

	private GameObject good;

	private ParticleSystem mParticle;

	private AutoDespawn mAutoDespawn;

	private Vector3 m_pos;

	private SkillAlone1737Ctrl ctrl;

	private float m_fTime;

	private bool Condition => false;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnUpdate(float delta)
	{
	}

	private void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void OnParentChangeHP(long currentHP, long maxHP, float percent, long change)
	{
	}

	private void CreateSkillOne()
	{
	}

	private void CreateSkillAlone()
	{
	}

	private void CacheEffect()
	{
	}
}
