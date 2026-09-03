using System;
using System.Collections.Generic;
using TableTool;

public class Act5thHuntingGameResultData
{
	public Act5thHuntingResulPanelType PanelType { get; set; }

	public int AllAnimalCount { get; set; }

	public List<int> KillAnimal { get; set; }

	public int GetScore { get; set; }

	public List<Drop_DropModel.DropData> GetReward { get; set; }

	public Action QuitAction { get; set; }

	public Action CloseAction { get; set; }

	public bool IsQuitKeepWindow { get; set; }

	public static Act5thHuntingGameResultData Create(Act5thHuntingResulPanelType panelType, int allAnimalCount, List<int> killAnimal, int getScore, List<Drop_DropModel.DropData> getReward, Action quitAction, Action closeAction, bool isQuitKeepWindow = false)
	{
		return null;
	}
}
