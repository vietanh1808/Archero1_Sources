using DG.Tweening;
using UnityEngine;

public class SkillAlone1888 : SkillAlonePetBase
{
	private float bulletDmgScale;

	private float bulletInheritCritRateScale;

	private float bulletExtraCritDmgScale;

	private float bulletInheritCritValueScale;

	private float petLastTime;

	private Tween delayCall;

	private MoveControl m_MoveCtrl;

	private AttackControl m_AttackCtrl;

	private GameObject thunderArmour;

	protected EntityBase PlayerEntity => null;

	protected override void OnInstall(params object[] args)
	{
	}

	protected override void OnUninstall()
	{
	}

	private void RefreshPetBehaviour()
	{
	}

	protected virtual void RefreshPetEntityAttribute()
	{
	}

	private void OnUpdate(float delta)
	{
	}

	private void OnCreateBullet(BulletBase bullet)
	{
	}

	private (float, float) GetBulletCritData()
	{
		return default;
	}

	protected virtual void OnPetAppear(BattlePetVO battlePetData)
	{
	}

	protected virtual void OnPetDisAppear(BattlePetVO battlePetData)
	{
	}

	private void OnPetStartDisappear(LocalSave.PetOne petOne)
	{
	}

	private GameObject LoadEffect()
	{
		return null;
	}

	protected float GetEntityBaseDmg()
	{
		return 0f;
	}

	protected virtual void ResetSkillData()
	{
	}

	private void ResetEntityAction()
	{
	}
}
