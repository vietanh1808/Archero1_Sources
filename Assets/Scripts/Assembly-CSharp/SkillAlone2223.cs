using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class SkillAlone2223 : SkillAloneArtifactBase
{
	private string skillStrData;

	private int randomCount;

	private float skillEndDelayTime;

	private float skillBoomRadius;

	private float skillBoomDmgScale;

	private float flySwordBoomRadius;

	private float flySwordBoomDmgScale;

	private int enemeyBeHitMaxNum;

	private float flySwordRotateDeltaAngle;

	private float flySwordDmgScale;

	private float flySwordDecraseDmgRatio;

	private float flySwordMinDmgRatio;

	public const int BulletID = 5379;

	public const int SkillEffectID = 2223;

	public const int SkillEndBoomEffectID = 3100112;

	public const int FlySwordHitEnemyBoomEffectID = 3100113;

	private Dictionary<int, int> hitEnemeyNum;

	protected Bullet5379 curFlyBullet;

	private Tween delayCall;

	protected SkillAlone2223RandomData randomData;

	protected List<SkillAlone2223RandomItemData> randomAllData;

	private SkillAlone2223GoodCtrl playerCreateSkill;

	protected virtual int RandomItemCount => 0;

	protected virtual float RealSkillEndDelayTime => 0f;

	protected SkillAlone2223RandomItemData MaxRandomData => null;

	protected virtual bool IsBulletHitEnemy(HitStruct hs)
	{
		return false;
	}

	protected override void OnInstall()
	{
	}

	protected override void CastSkill()
	{
	}

	protected virtual List<SkillAlone2223RandomItemData> SkillRandomData()
	{
		return null;
	}

	protected virtual int GetRandomMinValue()
	{
		return 0;
	}

	private void CreateSkillStart(List<SkillAlone2223RandomItemData> randomItemDatas)
	{
	}

	protected virtual void SkillStartStart()
	{
	}

	protected virtual void SkillEndStart()
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

	protected virtual void StartSendBullet()
	{
	}

	private void CreateSendBullet(EntityBase target, bool isSelf)
	{
	}

	protected virtual BulletBase SendBullet(EntityBase sender, EntityBase target)
	{
		return null;
	}

	protected virtual void OnFlySwordRecycle(Vector3 curPos)
	{
	}

	protected virtual void OnFlySwordHitEnemy(Vector3 curPos)
	{
	}

	protected EntityBase GetFlySwordAttackTarget()
	{
		return null;
	}

	protected override void OnHitAction(EntityBase attackTarget, HitStruct hs, HittedData hd)
	{
	}

	protected override void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private SkillAlone2223RandomItemData GetMaxRandomData()
	{
		return null;
	}

	protected virtual float GetSkillFinalBoomDmgScale()
	{
		return 0f;
	}

	private void SendSkillStartMsg(List<SkillAlone2223RandomItemData> randomItemDatas)
	{
	}

	private void SyncSendSkillStartMsg(List<SkillAlone2223RandomItemData> randomItemDatas)
	{
	}

	private void SendCreateSendBulletMsg(EntityBase target)
	{
	}

	private void SyncSendCreateSendBulletMsg(EntityBase target)
	{
	}

	protected override void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}
}
