using UnityEngine;

public class SkillAlone2174 : SkillAloneBase
{
	public class Skill1Effect2174IgniteVO : CustomJsonActionVO
	{
		public Vector3 pos;
	}

	private float callRate;

	private float dmgRate;

	private bool isNextAttackSpecial;

	private bool isNextRemoteAttackSpecial;

	private int specialWeaponId;

	private int oldWeaponId;

	public const string SyncSkill2174 = "SyncSkill2174";

	protected override void OnInstall()
	{
	}

	private void ParseParams()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnAttackPre()
	{
	}

	private void OnAttackEnd()
	{
	}

	private void OnAttackStart(int id)
	{
	}

	private void OnKillEnemy(EntityBase entity, Vector3 pos, HitStruct hs)
	{
	}

	public BulletBase CreateHeavyPunch(int bulletId, Vector3 bulletPos, float atkPercent)
	{
		return null;
	}

	private bool IsMeleeAttack()
	{
		return false;
	}

	private void OnHitAction(EntityBase enemy, HitStruct hs, HittedData data)
	{
	}

	private void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}

	private void SyncCastSkillMsg(Vector3 pos)
	{
	}
}
