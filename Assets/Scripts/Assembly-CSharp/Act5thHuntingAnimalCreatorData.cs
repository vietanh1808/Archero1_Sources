using System.Collections.Generic;

public class Act5thHuntingAnimalCreatorData
{
	public int GameSceneID { get; set; }

	public List<Act5thHuntingAnimalData> AnimalData { get; set; }

	public List<Act5thHuntingAnimalData> AnimalDataPoolA { get; set; }

	public List<Act5thHuntingAnimalData> AnimalDataPoolB { get; set; }

	public List<Act5thHuntingAnimalData> AnimalDataPoolC { get; set; }

	public bool IsAnimalAllDeadAndRecycle => false;

	public List<Act5thHuntingAnimalData> GetAllDeadAnimal => null;

	public List<Act5thHuntingAnimalData> GetAllLegalAnimal => null;

	public List<Act5thHuntingAnimalData> GetAllAliveAnimal => null;

	public int WaveTime => 0;

	public (int, int) AnimalCreateCountRange => default;

	public (int, int) AnimalCreatHighPoolCountRange => default;

	public static Act5thHuntingAnimalCreatorData Create(int gameSceneID, List<Act5thHuntingAnimalData> animalData)
	{
		return null;
	}

	public bool HaveAnimalCreate()
	{
		return false;
	}

	public void UpdateAliveAnimalCreateStatus()
	{
	}

	private void UpdateAliveAnimalCreateStatus(List<Act5thHuntingAnimalData> animalData)
	{
	}

	public void InitAnimalData(List<Act5thHuntingAnimalData> animalData)
	{
	}

	public List<Act5thHuntingAnimalData> GetPoolCanCreateAnimal(Act5thHuntingAnimalPoolType poolType)
	{
		return null;
	}

	private (int, int) GetCreateCountRange()
	{
		return default;
	}

	private (int, int) GetCreatHighPoolCountRange()
	{
		return default;
	}
}
