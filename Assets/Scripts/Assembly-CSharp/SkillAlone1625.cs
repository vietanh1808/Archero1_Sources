using UnityEngine;

public class SkillAlone1625 : SkillAloneBase
{
	public class SkillEffect1625_FlowerHit : CustomJsonActionVO
	{
		public int Guid;

		public long Hit;
	}

	private float criticalInterval;

	private int flowerBuffId;

	private float flowerHitRate;

	private float flowerHitRatio;

	private const string SyncSkill1625_FlowerHit = "SyncSkill1625_FlowerHit";

	private float preCriticalTime;

	private const string flowerExplodeEffPath = "Effect/Battle/eff_melinda_princess_blossom";

	private GameObject effExplode;

	protected override void OnInstall()
	{
	}

	private void ParseParams()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnUpdate(float delta)
	{
	}

	private void OnCritWithHitStruct(EntityBase enemy, long hit, HitStruct hs)
	{
	}

	private void FlowerHit(long hit, EntityBase target)
	{
	}

	private void OnWeaponCreated()
	{
	}

	private void OnAfterSetBulletAttribute(BulletBase b)
	{
	}

	private void SyncFlowerHit(int guid, long hit)
	{
	}

	private void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}
}
