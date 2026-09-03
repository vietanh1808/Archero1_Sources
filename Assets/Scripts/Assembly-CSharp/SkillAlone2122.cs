using UnityEngine;

public class SkillAlone2122 : SkillAloneWing
{
	public class Skill1Effect2122IgniteVO_SingleStar : CustomJsonActionVO
	{
		public Vector3 startPos;

		public Vector3 endPos;
	}

	public class Skill1Effect2122IgniteVO_CupidArrow : CustomJsonActionVO
	{
		public Vector3 bornPos;

		public float angle;

		public int targetUid;
	}

	private float raininterval;

	private int bulletId;

	private float dropRadius;

	private float arrowRadius;

	private int arrowMaxCount;

	private int arrowMinCount;

	private float hitRatio;

	private int isSkill1Effect;

	private float reduceTimePerRain;

	private float reduceTimeLimit;

	private int isSkill2Effect;

	private float addBuffRate;

	private int buffId;

	private int isSkill3Effect;

	private float throwCupidArrowRate;

	private int cupidBulletId;

	private float flySwordHitRatio;

	private int isSkill4Effect;

	private float hitRateRise;

	private float curRainInterval;

	private float cdTimeReduced;

	private float preEffectTime;

	private string SyncSkill2122_SingleStar;

	private string SyncSkill2122_CupidArrow;

	private int angleLimit;

	private ActionBasic action;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnUpdate(float delta)
	{
	}

	private void CheckPlayerStatus(float delta)
	{
	}

	private void CastSkill()
	{
	}

	private void OnHitAction(EntityBase entity, HitStruct hs, HittedData data)
	{
	}

	protected void OnCrit(EntityBase entity, long realhit, HitStruct hs)
	{
	}

	public virtual BulletBase CreateCupidArrow(int bulletId, Vector3 startpos, float angle, float hitRatio, EntityBase target)
	{
		return null;
	}

	private void CreateStars(int count)
	{
	}

	private void CreatSingleStar(Vector3 startPos, Vector3 endPos)
	{
	}

	private void UpdateBulletTransmit(BulletBase bullet)
	{
	}

	private void SyncSingleStar(Vector3 startPos, Vector3 endPos)
	{
	}

	private void SyncCupidArrow(Vector3 startPos, float angle, int uid)
	{
	}

	protected override void OnRecvCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO vo)
	{
	}
}
