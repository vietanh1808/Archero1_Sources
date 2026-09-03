using System.Collections.Generic;
using DG.Tweening;

public class SkillAlone2201 : SkillAloneArtifactBase
{
	private float crystalLastTime;

	protected float crystalRadius;

	private float crystalItemRadius;

	private int crystalFragmentCount;

	private int originShowCrystalFragmentCount;

	private float showCrystalFragmentMoreInterval;

	private float crystalBoomDmgScale;

	private float crystalItemDmgScale;

	public const int BulletID = 5368;

	private List<BulletBase> allCreateBullet;

	private List<BulletBase> removeCreateBullet;

	private SkillAlone2201GoodCtrl playerCreateSkill;

	private SkillAlone2201BoomGoodCtrl playerBoomSkill;

	private Tween delayCall;

	protected virtual int SkillEffectID => 0;

	protected virtual int BoomEffectID => 0;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
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

	protected virtual float GetAutoSendBulletInterval()
	{
		return 0f;
	}

	protected virtual void OnCreateBullet(BulletBase bulletBase)
	{
	}

	protected virtual void SkillTriggerEntityEnter(EntityBase triggerEntity)
	{
	}

	protected virtual void SkillTriggerEntityExit(EntityBase triggerEntity)
	{
	}

	protected override void OnUpdate(float delta)
	{
	}

	protected override void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	protected override void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}
}
