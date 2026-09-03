using UnityEngine;

public class SkillAlone1620 : SkillAloneWing
{
	public class SkillEffect1620_RecoverVO : CustomJsonActionVO
	{
		public int Guid;

		public long Recover;
	}

	public class SkillEffect1620_Phoenix_NovaVO : CustomJsonActionVO
	{
		public Vector3 Pos;
	}

	private float TriggerPhoenixInterval;

	private float PhoenixHitRatio;

	private bool isSkill1Effect;

	private float recoverRate;

	private int recoverFrameInterval;

	private float recoverCDTime;

	private int triStaightPhoenixTimes;

	private float phoenixHitRatioStaight;

	private bool isSkill2Effect;

	private int firePathDebuffId;

	private bool isSkill3Effect;

	private bool isSkill4Effect;

	private float phoenixHitRiseRate;

	private bool isSkill5Effect;

	private float phoenixExplodeRadius;

	private float phoenixExplodeHitRatio;

	private float firstNovaDelayTime;

	private float novaInterval;

	private const int PhoenixClockwiseBulletId = 3076;

	private const int PhoenixAntiClockwiseBulletId = 3077;

	private const int PhoenixStraightBulletId = 3078;

	public const int PhoenixNovaBulletId = 3079;

	private const string SyncSkill1620_Recover = "SyncSkill1620_Recover";

	private const string SyncSkill1620_Phoenix_Nova = "SyncSkill1620_Phoenix_Nova";

	private float prePhoenixEffectTime;

	private bool isNextImpulse;

	private int straightPhoenixCountLeft;

	private float preRecoverTime;

	private BulletBase PhoenixClockwise;

	private BulletBase PhoenixAntiClockwise;

	private float preNovaTime;

	private GameObject fireEffLeft;

	private GameObject fireEffRight;

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

	public BulletBase CreatePhoenixImpulse(int bulletId, Vector3 bulletPos, float atkPercent, float rota)
	{
		return null;
	}

	private void OnAttack()
	{
	}

	private void OnPhoenixHitSelf()
	{
	}

	private void HitSelfEffect()
	{
	}

	private void StraightPhoenixEffect()
	{
	}

	private void CreatEffHand()
	{
	}

	private void CacheEffHand()
	{
	}

	private void SyncRercover(int guid, long recover)
	{
	}

	private void SyncPhoenixNova(Vector3 pos)
	{
	}

	private void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}
}
