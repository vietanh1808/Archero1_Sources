using System.Collections.Generic;
using UnityEngine;

public class SkillAlone1624 : SkillAloneBase
{
	private float bubbleRate;

	private int bubbleBuffId;

	private float bubbleEndHitRatio;

	private float shieldRecoverRate;

	private float bubbleExplodeHitRatio;

	private float bubbleExplodeRadius;

	private float bubbleHitInterval;

	private int ExplodeBulletId;

	private Dictionary<int, float> preBubbleEffectDict;

	protected override void OnInstall()
	{
	}

	private void ParseParams()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnHitAction(EntityBase enemy, HitStruct hs, HittedData ht)
	{
	}

	private void OnBuffRemoved(EntityBase entity, int buffId)
	{
	}

	private void OnEnemyDing(EntityBase attackTarget)
	{
	}

	public BulletBase CreateBubbleHit(int bulletId, Vector3 bulletPos, float atkPercent, float radius)
	{
		return null;
	}

	private void GotoNextRoom(RoomGenerateBase.Room room)
	{
	}
}
