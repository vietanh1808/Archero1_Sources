using System.Collections.Generic;
using UnityEngine;

public class SkillAlone2184 : SkillAloneBase
{
	private int createFirePanProb;

	private float firePanEffectRadius;

	private int inRangeBuff;

	private int outRangeBuff;

	private int randomPosPercent;

	private Dictionary<int, int> entityStatus;

	private SkillAlone2184GoodCtrl goodCtrl;

	private LocalSave.Skill2184VO Skill2184VO => null;

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

	private void TryRandomCreateFirePan(int curRoomID, int roomHeight)
	{
	}

	private void CrateFirePan(Vector3 createPos)
	{
	}

	private void TriggerEnter(EntityHero hero)
	{
	}

	private void TriggerExit(EntityHero hero)
	{
	}

	private void DeInitSkill()
	{
	}
}
