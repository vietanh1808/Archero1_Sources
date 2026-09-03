using System.Collections.Generic;
using UnityEngine;

public class Action1826Follow : ActionBasic.ActionBase
{
	private const int NEAR_X = 2;

	private const int NEAR_Y = 2;

	private AIBase.ActionSequence seq;

	protected override void OnForceEnd()
	{
	}

	protected override void OnInit()
	{
	}

	protected override void OnUpdate()
	{
	}

	private bool disable2ReachAnyMonster(List<EntityBase> m_EntityList)
	{
		return false;
	}

	public ActionBasic.ActionBase getChooseAction()
	{
		return null;
	}

	private List<Vector2Int> getAvailableGrids(EntityBase entity, int size)
	{
		return null;
	}

	private List<Vector2Int> getAvailableBackGrids(EntityBase entity, int size)
	{
		return null;
	}

	private List<Vector2Int> getAvailableFrontGrids(EntityBase entity, int size)
	{
		return null;
	}

	protected override void OnDeInit()
	{
	}
}
