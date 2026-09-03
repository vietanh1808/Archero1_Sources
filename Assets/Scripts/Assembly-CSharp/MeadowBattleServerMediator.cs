using System.Collections.Generic;
using Cooperation.NetEvent;
using GameProtocol;
using MeadowBattle;
using PureMVC.Interfaces;
using PureMVC.Patterns;
using TableTool;

public class MeadowBattleServerMediator : Mediator
{
	public new const string NAME = "MeadowBattleServerMediator";

	private uint cacheBattleTransId;

	public override IEnumerable<string> ListNotificationInterests => null;

	public MeadowBattleServerMediator(string name, object view)
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

	private void onShowGameOverWithNoNetwork(SendMatchResultVO resultVO)
	{
	}

	private void onOpenWinBox(Farm_VictoryReward victoryReward)
	{
	}

	private void onOpenGachaBox()
	{
	}

	private int[] dc_eggReward(List<Drop_DropModel.DropData> datalist)
	{
		return null;
	}

	private void saveBattleTransId()
	{
	}

	public uint GetCacheBattleTransId()
	{
		return 0u;
	}

	private uint[] getSelfTeamMonsterIds()
	{
		return null;
	}

	private void onRequestPlayGame(bool isFree)
	{
	}

	private void onDebugStartStandaloneGame()
	{
	}

	private void onRequestSaveFormation()
	{
	}

	private void onRequestGameOver(SCBattleOverEvent tdata)
	{
	}

	private void onRequestFormation()
	{
	}

	private void onRequestMBInfo(RequestMBInfoVO vo)
	{
	}

	private void onGetMBInfoSuccess(STFarmPvpRespInfo data)
	{
	}

	private void enterMeadowBattleScene(bool showDefensive, MatchVO _matchVO)
	{
	}
}
