using UnityEngine;

public class SkillAlone2113 : SkillAloneBase
{
	public class Skill1Effect2113IgniteVO_SyncSnakes : CustomJsonActionVO
	{
		public Vector3 bornPos;
	}

	private int snakeBuffId;

	private float attachRate;

	private int snakeBulletId;

	private float snakeBulletHitRatio;

	private float riseHurtRatio;

	private float snakeBulletRadius;

	private string SyncSkill2113_SyncSnakes;

	protected override void OnInstall()
	{
	}

	private void ParseParams()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnHitted(EntityBase enemy, HitStruct hs, HittedData ht)
	{
	}

	public BulletBase CreateSnake(int bulletId, Vector3 bulletPos, float rotate, float atkPercent, float radius)
	{
		return null;
	}

	private void DeadAction(EntityBase enemy)
	{
	}

	private void CreateSnakes(Vector3 bornPos)
	{
	}

	private void SyncSnakes(Vector3 bornPos)
	{
	}

	protected override void OnRecvCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO vo)
	{
	}
}
