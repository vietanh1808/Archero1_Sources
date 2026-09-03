using UnityEngine;

public class SkillAlone2126 : SkillAloneBase
{
	protected float waveBulletRadius;

	protected float waveBulletMoveSpeed;

	protected float waveBulletDmgScale;

	protected float waveBulletTriggerRadius;

	protected float waveBulletTriggerInterval;

	protected int buffID;

	private const float LocalCheckInterval = 0.1f;

	private float lastCheckTime;

	private float lastCastSkillTime;

	protected virtual int SkillEffectID => 0;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnUpdate(float delta)
	{
	}

	private EntityBase GetRadiusTarget()
	{
		return null;
	}

	protected virtual void CastSkill(EntityBase entity, Vector3 pos, Vector3 dir)
	{
	}

	protected virtual void CreateSkill(EntityBase entity, Vector3 pos, Vector3 dir)
	{
	}

	private void SendCreateWaveMsg(EntityBase entity, Vector3 pos, Vector3 dir)
	{
	}

	private void SyncCreateWaveMsg(EntityBase entity, Vector3 pos, Vector3 dir)
	{
	}

	private void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}
}
