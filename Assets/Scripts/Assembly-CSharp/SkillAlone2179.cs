using Dxx.Util;

public class SkillAlone2179 : SkillAloneBase
{
	private float statusTransHpPercent;

	private int baseTriggerProb;

	private int zeroHPTriggerProb;

	private int lowHpAddbuffID;

	private int originCallThunderCount;

	private float callPerThunderInterval;

	private float lossHpAddThuner;

	private int lossHpAddThunerCount;

	private float autoCastPerThunerInerval;

	private float inheritPlayerBaseAttackScale;

	private float inheritPlayerCritScale;

	private float inheritPlayerCritValueScale;

	private SequencePool mSeqPool;

	private SequencePool mSeqThunderPool;

	public const int SkillAlone2179BulletID = 3069;

	public const int SkillAlone2179PVPEnemyBulletID = 3070;

	private bool isAddBuff;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	protected virtual void HitAction(EntityBase attackTarget, HitStruct hs, HittedData hd)
	{
	}

	private void OnCreatePlayer()
	{
	}

	private void OnChangeHP(long curHP, long maxHp, float curPercent, long deltaHp)
	{
	}

	private void CheckAddBuff(float hpPercent)
	{
	}

	private float GetHpPercent(EntityBase curEntity)
	{
		return 0f;
	}

	private void TimeToCallThunder()
	{
	}

	private void RandomOneCastThunder()
	{
	}

	private float GetCritProb(EntityBase sender)
	{
		return 0f;
	}

	private void CastThunder(EntityBase sender, EntityBase target, bool isShowSelf, bool isCrit)
	{
	}

	private void SendCastThunderMsg(EntityBase sender, EntityBase target)
	{
	}

	private void SyncCastThunderMsg(EntityBase sender, EntityBase target, bool isCrit)
	{
	}

	private void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}
}
