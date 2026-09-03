using System.Collections.Generic;
using PureMVC.Interfaces;
using PureMVC.Patterns;
using UnityEngine;

public class MeadowBattleMediator : Mediator
{
	public new const string NAME = "MeadowBattleMediator";

	private Vector3 startPos;

	public override IEnumerable<string> ListNotificationInterests => null;

	public MeadowBattleMediator(string name, object view)
	{
	}

	public override void OnRegister()
	{
	}

	public override void OnRemove()
	{
	}

	public override void HandleNotification(INotification notification)
	{
	}

	private void onRecycleAllMonsters()
	{
	}

	private void deleteMonsterFromStage(EntityMonsterBase dragMonster)
	{
	}

	private void onResumeGame()
	{
	}

	private void onPauseGame()
	{
	}

	private void onTouchBegin(GameTouch touch)
	{
	}

	private void onTouchMove(GameTouch touch)
	{
	}

	private void onTouchEnd(GameTouch touch)
	{
	}

	private void onCreateMonster(LocalSave.MonsterData data)
	{
	}

	private void onSelectMonster(EntityMonsterBase monsterEntity)
	{
	}

	private void onStartGame()
	{
	}

	private void showSnapCircles(List<Vector2Int> posList, bool visible)
	{
	}

	private void checkIfGameOver()
	{
	}

	private void closeGame()
	{
	}

	private void backToMain()
	{
	}

	private void onExitGame(MBExitGameVO exitGameVO)
	{
	}

	private void handleSeasonEnd(MBExitGameVO exitGameVO)
	{
	}

	private void onClickBtnSurrender()
	{
	}
}
