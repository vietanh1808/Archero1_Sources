using UnityEngine;

public class Weapon1196 : WeaponBase
{
	protected RedLinesCtrl5301 mRedLinesCtrl;

	public GameObject goStartBeam;

	private string updateName;

	private bool canAddIceImmunity;

	private bool attackStarted;

	private float deltaAttackPreSpeed;

	private AIBase.ActionRotateToTarget rotate2Target;

	private bool changeAnimSpeed;

	private const float DELTA_PERCENT = 0.58f;

	private const int LV2_CHAR_ID = 5089;

	protected override void OnInstall()
	{
	}

	private void createBeam()
	{
	}

	private void modifyAttackPreTime()
	{
	}

	protected override void OnUnInstall()
	{
	}

	private void onUpdate(float obj)
	{
	}

	protected override void OnAttack(params object[] args)
	{
	}

	private void onAttackStart()
	{
	}

	private void onAttackEnd()
	{
	}

	private void recoverAnimSpeed()
	{
	}

	private Transform createBullet1196(BulletBase b, Quaternion rotation, Vector3 startPos, Vector3 endPos)
	{
		return null;
	}

	private void showRedLines()
	{
	}

	private void clearRedLines()
	{
	}

	public int GetReboundCount()
	{
		return 0;
	}

	private float getAttackDelayTime()
	{
		return 0f;
	}
}
