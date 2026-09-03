using System;

public class SkillAlone2328ShieldCtrl : BulletResist
{
	private float lifeTime;

	private int absorbedBulletCount;

	private Action<int> onShieldEnd;

	public void Init(float pLifeTime, Action<int> pOnShieldEnd)
	{
	}

	public override void SetEntityParent(EntityBase entity)
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnUpdate(float delta)
	{
	}

	private void OnBulletResistHitted(BulletResist resist, BulletBase bullet)
	{
	}

	private void EndShield()
	{
	}

	private void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}
}
