using System.Collections.Generic;
using Dxx.Util;
using UnityEngine;

public class SkillAlone2238 : SkillAloneBase
{
	private float createSkillInterval;

	private float blackHoleBulletDmgScale;

	private float blackHoleBulletHitEnemyInterval;

	private float blackHoleRadius;

	private float skillLastTime;

	private int maxCreateCount;

	private List<SkillAlone2231GoodCtrl> allCreateSkill;

	private SequencePool sequencePool;

	private bool allowKillCreateSkill;

	private ArtifactType ArtifactType => ArtifactType.None;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnArtifact302SkillStatusChange(bool isStartSkill)
	{
	}

	private void TryCreateSkill(Vector3 skillPos)
	{
	}

	private void OnKillEnemy(EntityBase entity, Vector3 pos, HitStruct hs)
	{
	}

	private void SendCreateBlackHoleMsg(Vector3 createPos)
	{
	}

	private void SyncCreateBlackHoleMsg(Vector3 createPos)
	{
	}

	protected void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}
}
