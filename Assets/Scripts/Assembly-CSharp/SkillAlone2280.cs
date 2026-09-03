using UnityEngine;

public class SkillAlone2280 : SkillAloneBase
{
	private int resistTimes;

	private float lifeTime;

	private EntityHero m_hero;

	private bool isUsingDagger;

	private bool isShieldOn;

	private float preShieldEffTime;

	private int resistCount;

	private const string WaterShieldEffPath = "Effect/Battle/eff_trident_water_shield";

	private GameObject shieldEffect;

	protected override void OnInstall()
	{
	}

	protected virtual void ParseParams()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnTridentChangeState(bool isInCannon)
	{
	}

	private void OnSuperSkill(bool flag)
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

	private void OnHit(EntityBase enemy, long realhit, HitStruct hs)
	{
	}

	private void CreatShield()
	{
	}

	private void DestroyShield()
	{
	}

	private void OnUpdate(float delta)
	{
	}
}
