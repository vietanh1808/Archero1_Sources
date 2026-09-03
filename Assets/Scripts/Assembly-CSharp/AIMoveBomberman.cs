using System.Collections.Generic;
using TableTool;
using UnityEngine;

public class AIMoveBomberman : AIMoveBase
{
	private EntityBase target;

	private List<Grid.NodeItem> findpath;

	private Vector3 nextpos;

	private Vector3 endpos;

	private Weapon_weapon weaponData;

	private int range;

	private Vector2Int checkpos;

	public AIMoveBomberman(EntityBase entity, int range)
		: base(null)
	{
	}

	private void InitPos()
	{
	}

	protected override void OnInitBase()
	{
	}

	protected override void OnUpdate()
	{
	}

	private void MoveNormal()
	{
	}

	private void AIMoveStart()
	{
	}

	private bool issamepos(Grid.NodeItem item)
	{
		return false;
	}

	private void UpdateMoveData()
	{
	}

	private void UpdateDirection()
	{
	}

	private void Find()
	{
	}

	private void AIMoving()
	{
	}

	protected override void OnEnd()
	{
	}
}
