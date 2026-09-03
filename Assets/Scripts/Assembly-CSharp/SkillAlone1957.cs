using System.Collections.Generic;
using UnityEngine;

public class SkillAlone1957 : SkillAloneBase
{
	private int movingBuff;

	private float maxDis;

	private float radius;

	private int initFlashChainEjectCount;

	private float flashChainDis;

	private float flashChainInitRatio;

	private float flashChainDecreaseRatio;

	private float flashChainMinRatio;

	private ActionMovingDis movingDis;

	private bool addBuff;

	private GameObject goThunderSphere;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void onGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void onHeroDrop2Floor()
	{
	}

	protected override void OnRecvCustomJsonActionInternal(CustomJsonDataCommand cmd, CustomJsonActionVO vo)
	{
	}

	private void OnMoveEvent(bool isMoving)
	{
	}

	private void onReachMaxDis()
	{
	}

	private void createFlashChain(Vector3 bulletDir)
	{
	}

	private void syncFlashChain(Vector3 bulletDir)
	{
	}

	private List<EntityBase> getSelectedEnemies()
	{
		return null;
	}

	private void initThunderSphere()
	{
	}

	private void deinitThunderSphere()
	{
	}

	private GameObject createThunderSphere()
	{
		return null;
	}
}
