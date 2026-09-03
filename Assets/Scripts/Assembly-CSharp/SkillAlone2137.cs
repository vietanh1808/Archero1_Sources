using UnityEngine;

public class SkillAlone2137 : SkillAloneBase
{
	private int createBlackBallProb;

	private float blackBallStayLastTime;

	private float createBlackBallInterval;

	private float blackHoleBulletHitEnemyInterval;

	public const int BlackBallBulletID = 5346;

	public const int BlackHoleBulletID = 5347;

	public const int SkillEffectID = 2137;

	private float lastCreateBlackBallTime;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	protected virtual void HitAction(EntityBase attackTarget, HitStruct hs, HittedData hd)
	{
	}

	protected void SendBlackBall(EntityBase sender, Vector3 targetPos, bool needTryReSendBlackHole, bool isSelf)
	{
	}

	protected void SendBlackBallOnly(EntityBase sender, Vector3 targetPos)
	{
	}

	protected bool AllowCreateBlackBall()
	{
		return false;
	}

	private void SendCreateBlackBallMsg(EntityBase sender, Vector3 pos, bool needTryReSendBlackHole)
	{
	}

	private void SyncCreateBlackBallMsg(EntityBase sender, Vector3 pos)
	{
	}

	private void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}
}
