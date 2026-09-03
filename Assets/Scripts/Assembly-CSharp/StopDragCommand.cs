using PureMVC.Interfaces;
using PureMVC.Patterns;
using UnityEngine;

public class StopDragCommand : SimpleCommand
{
	public override void Execute(INotification notification)
	{
	}

	private void trySnap(EntityMonsterBase dragMonster)
	{
	}

	public void DeleteMonsterFromStage(EntityMonsterBase dragMonster)
	{
	}

	private void onMonsterPositionChanged(EntityMonsterBase _dragMonster)
	{
	}

	private void onMonsterPlaced(EntityMonsterBase _monster, Vector2Int anchorGrid)
	{
	}

	private void refreshStageArea()
	{
	}
}
