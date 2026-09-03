using UnityEngine;

public class SkillAlone9039 : SkillAloneBase
{
	public class SkillEffect9039_SyncBulletsVO : CustomJsonActionVO
	{
		public Vector3 Pos;

		public int Seed;

		public float rotate;
	}

	private float explodeRate;

	private float elementHitRatio;

	private float interval;

	private int bulletId;

	private float preEffectTime;

	private const string SyncSkill9039_SyncBullets = "SyncSkill9039_SyncBullets";

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void ParseParams()
	{
	}

	protected virtual void OnHitAction(EntityBase entity, HitStruct hs, HittedData ht)
	{
	}

	private void CreatBullets(Vector3 pos, int randomSeed, float rotate = -999f)
	{
	}

	public BulletBase CreateElementBullet(int bulletId, Vector3 bulletPos, float atkPercent, float rota)
	{
		return null;
	}

	private void SyncBullets(Vector3 pos, int seed, float rot)
	{
	}

	private void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}
}
