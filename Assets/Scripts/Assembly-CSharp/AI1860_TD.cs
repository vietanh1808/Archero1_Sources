using UnityEngine;

public class AI1860_TD : AINormalAttack_TD
{
	private const int TowerId = 1860;

	private const string Attacking = "Attacking";

	private GameObject fireEffect;

	private int state;

	private float time;

	private float dtime;

	private int bulletId;

	private EntityTD2023_1860 td1860;

	private float fireAtkInterval;

	private float fireRangeMin;

	private float fireRangeMax;

	private float fireRange;

	private float fireTime;

	public float AtkWaitTime => 0f;

	public long FirePillarAtkValue => 0L;

	public float FireAtkInterval => 0f;

	public float FireRange => 0f;

	public float FireRangePercent => 0f;

	public float FireRangeAdd => 0f;

	public float FireTime => 0f;

	protected override void OnInitOnce()
	{
	}

	protected override void OnAIDeInit()
	{
	}

	private void onTDAtkSpeedChanged()
	{
	}

	protected override void OnUpdate(float delta)
	{
	}

	protected override int GetWeaponId()
	{
		return 0;
	}

	protected override void PopulateActions()
	{
	}

	private void createBullet()
	{
	}

	private void initParams()
	{
	}
}
