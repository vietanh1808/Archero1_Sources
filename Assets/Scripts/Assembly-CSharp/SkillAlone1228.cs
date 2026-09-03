using System.Collections.Generic;
using UnityEngine;

public class SkillAlone1228 : SkillAloneBabyBase
{
	private float m_fCdTime;

	private float m_fContinousTime;

	private float m_fRadius;

	private int m_nDebuffId;

	private int m_nEffectId;

	private List<Vector3> m_listNewElkPositions;

	private List<AI2020> m_listCatchedElks;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnOnSpecialGoodsGenerate(int id, int x, int y)
	{
	}

	private void OnOpenDoor(RoomGenerateBase.Room room)
	{
	}

	private void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private AI2020 InitBaby(EntityBabyBase baby)
	{
		return null;
	}

	private void OnBabyCatched(AI2020 baby)
	{
	}

	private void OnCloseWindow(WindowID id)
	{
	}
}
