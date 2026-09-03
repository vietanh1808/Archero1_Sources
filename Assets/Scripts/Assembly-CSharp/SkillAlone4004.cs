using UnityEngine;

public class SkillAlone4004 : SkillAloneBase
{
	private const string String_HarmRate = "HarmRate%";

	private const string String_WeightIni = "WeightIni";

	private const string String_WeightArgs = "WeightArgs";

	private const string String_WeightLimit = "WeightLimit";

	private const string String_BulletId = "BulletId";

	private const string String_CatNumAdd = "CatNumAdd";

	private int WeightIni;

	private int WeightArgs;

	private int WeightLimit;

	protected int BulletId;

	private float attackRatio;

	private float m_fLastCallTime;

	private int catNumAdd;

	private float timeInterval;

	protected override void OnInstall()
	{
	}

	private void ParseInPvp()
	{
	}

	private void ParseInNonPvp()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void Excute(string str)
	{
	}

	protected void OnHitAction(EntityBase entity, HitStruct hs, HittedData data)
	{
	}

	private void CreateCatBullet(EntityBase entity)
	{
	}

	private void onCreateCatBulletInPvp(Vector3 bulletPos, float angle, float attackRatio, EntityBase entity)
	{
	}

	private void onCreateCatBulletInNonPvp(Vector3 bulletPos, float angle, float attackRatio, EntityBase entity)
	{
	}
}
