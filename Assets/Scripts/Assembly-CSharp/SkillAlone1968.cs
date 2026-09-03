using UnityEngine;

public class SkillAlone1968 : SkillAloneBase
{
	public class Skill1Effect1968_CallCloud : CustomJsonActionVO
	{
		public Vector3 pos;

		public int guid;
	}

	private float minCallCloudRate;

	private float maxCallCloudRate;

	private float callCloudCDTime;

	private float cloudEffectRadius;

	private float thunderDamageFactor;

	private float thunderFallInterval;

	private int maxCloudNum;

	private const int CLOUD_BULLET_ID = 1561;

	private const int CLOUD_BULLET_ID_PVP = 1563;

	private const float BULLET_POS_Y = 5.5f;

	private float preCallCloudTime;

	private int curActiveCloudNum;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnHitted(EntityBase enemySource, long hp, HitStruct hs)
	{
	}

	private void CreatCloud(EntityBase enemySource, Vector3 cloudInitPos)
	{
	}

	private void OnBulletDestroy()
	{
	}

	private void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}

	private void SyncCastSkillMsg(Vector3 pos, int guid)
	{
	}
}
