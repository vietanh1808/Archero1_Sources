using System.Collections.Generic;
using TableTool;

public class Act5thHuntingPreviewItemData
{
	private Act5thHuntingPreviewItemSourceData ConfigData { get; set; }

	public int ID => 0;

	public string HeadImg => null;

	public string AnimalName => null;

	public int Quality => 0;

	public int Type => 0;

	public int HaveKillCount => 0;

	public int HaveGetScore => 0;

	public List<Drop_DropModel.DropData> DropData => null;

	public static Act5thHuntingPreviewItemData Create(Act5thHuntingPreviewItemSourceData configData)
	{
		return null;
	}
}
