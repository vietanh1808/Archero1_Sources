using System;
using System.Collections.Generic;
using UnityEngine;

public class SkillAlone1202 : SkillAloneBase
{
	private float m_fDistance;

	private float m_fMoveSpeed;

	private float m_fAttack;

	private List<Vector2Int> m_listWaters;

	private bool m_bAddFlag;

	private Func<int, int, Vector3> GetWorldPosition;

	private float time;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void OnGotoNextRoom(RoomGenerateBase.Room room)
	{
	}

	private void OnUpdate(float delta)
	{
	}

	private void ExcuteAttribute(string name, float value)
	{
	}
}
