using System.Collections.Generic;
using Dxx.Util;
using UnityEngine;

public class SkillAlone2214 : SkillAloneArtifactBase
{
	private float skillLastTime;

	private float sendBulletInterval;

	private float effectTime;

	private float effectDmgScale;

	private float bulletDmgScale;

	public const int SkillEffectID = 2214;

	public const int BulletID = 5378;

	protected Dictionary<EntityBase, int> triggerAllEntity;

	private SkillAlone2214GoodCtrl playerCreateSkill;

	private SequencePool sequencePool;

	private Dictionary<int, float> enemyData;

	private bool IsSendBulletBySelf => false;

	private float ExtraSKillRadius => 0f;

	protected override float ModelLegalPositionOffset => 0f;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnArtifactSkill2214EntitySendBullet(EntityBase target, float angle, Vector3 bulletStartPos)
	{
	}

	protected override void CastSkill()
	{
	}

	protected override void SkillStart()
	{
	}

	protected override void SkillEnd()
	{
	}

	protected override void SkillClear()
	{
	}

	protected virtual float GetSkillEffectRadius()
	{
		return 0f;
	}

	protected virtual void StartSendBullet(EntityBase target, float angle, Vector3 bulletStartPos, bool allowSelfSlantArrow, bool isSelf)
	{
	}

	protected virtual BulletBase SendBullet(EntityBase target, float bulletAngle, Vector3 startPos, bool isSelf)
	{
		return null;
	}

	private float OnArtifact201BulletHit(int guid, int bulletID)
	{
		return 0f;
	}

	protected virtual void SkillTriggerEntityEnter(EntityBase triggerEntity)
	{
	}

	protected virtual void SkillTriggerEntityExit(EntityBase triggerEntity)
	{
	}

	protected virtual void SkillExtraTriggerEntityEnter(EntityBase triggerEntity)
	{
	}

	protected virtual void SkillExtraTriggerEntityExit(EntityBase triggerEntity)
	{
	}

	protected override void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void SendStartBulletMsg(EntityBase target, float angle, Vector3 bulletStartPos, bool allowSelfSlantArrow)
	{
	}

	private void SyncStartBulletMsg(EntityBase target, float angle, Vector3 bulletStartPos, bool allowSelfSlantArrow)
	{
	}

	protected override void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}
}
