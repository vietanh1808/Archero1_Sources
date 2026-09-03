using DG.Tweening;
using UnityEngine;

public class SkillAlone2186 : SkillAloneBase
{
	private int createThunderCloudProb;

	private float thunderCloudDelayMoveTime;

	private float thunderCloudMoveScaleA;

	private float thunderCloudMoveScaleB;

	private float thunderCloudMoveScale;

	private float thunderAttackInterval;

	private float thunderAttackDmgScale;

	private float thunderRadius;

	public int thunderCloudAddBuff;

	private SkillAlone2186GoodCtrl goodCtrl;

	private Tween delayCall;

	private LocalSave.Skill2186VO Skill2186VO => null;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void OpenDoor(RoomGenerateBase.Room room)
	{
	}

	private void TryCreateThunderCloud(int curRoomID)
	{
	}

	private void CrateThunderCloud(Vector3 skillPos)
	{
	}

	private void StartThunderMove()
	{
	}

	private void InitEffectBuff()
	{
	}

	private void DeInitEffectBuff()
	{
	}
}
