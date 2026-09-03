using UnityEngine;

public class SkillAlone2161 : SkillAloneBase
{
	private int CONFIG_BULLET_ID;

	private float CONFIG_HIT_RATIO;

	private int CONFIG_DURATION;

	private float CONFIG_ENERGY_ADD_PERHIT;

	private float CONFIG_ENERGY_ADD_LIMIT;

	private int CONFIG_MAX_RESIST_NUM;

	private float CONFIG_INTERVAL;

	private string CONFIG_SHIELD_RESNAME;

	private GameObject _shield;

	private float _lastShieldTime;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnBigShieldResist(BulletBase bullet)
	{
	}

	private void OnLanceChangeState(bool isInCannon)
	{
	}

	public void CreateShield(Vector3 pos)
	{
	}

	private void GotoNextRoom(RoomGenerateBase.Room room)
	{
	}
}
