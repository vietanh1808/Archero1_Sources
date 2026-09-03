public class Act5thHuntingGameData
{
	public int GameSceneID { get; set; }

	public Act5thHuntingArrowCreatorData ArrowCreatorData { get; set; }

	public Act5thHuntingAnimalCreatorData AnimalCreatorData { get; set; }

	public int GameTotalTime => 0;

	public static Act5thHuntingGameData Create(int gameSceneID, Act5thHuntingArrowCreatorData arrowCreatorData, Act5thHuntingAnimalCreatorData animalCreatorData)
	{
		return null;
	}
}
