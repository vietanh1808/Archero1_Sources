using UnityEngine;

public class Action5090Skill3 : AIMoveToTarget
{
	private ActionBasic actionMsg;

	private bool isElite;

	private GameObject goShield;

	private const int SHIELD_EFFECT_ID = 3100094;

	private const int ICE_BULLET_ID = 5308;

	private const int REFLECT_BULLET_ID = 5313;

	private const int CURVE_ICE_BULLET_ID = 5309;

	private float rotateDegreesPerSecond;

	private float cumulatedDegrees;

	private float curDegrees;

	public Action5090Skill3(EntityBase entity)
		: base(null)
	{
	}

	protected override void OnInitBase()
	{
	}

	protected override void OnEnd()
	{
	}

	protected override void OnUpdate()
	{
	}

	protected override void onCloseEnough()
	{
	}

	protected override void updateDir()
	{
	}

	private void onUmbrellaEnabledAction(bool enabled, HitStruct hit)
	{
	}

	private void quickRotate()
	{
	}

	private void createIceBullet(Vector3 dir, int bulletId)
	{
	}
}
