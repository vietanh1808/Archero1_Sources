using System.Collections.Generic;
using GameProtocol;
using TableTool;

public class Act5thHuntingAnimalData : Act5thHuntingEntityData
{
	public int AnimalID { get; set; }

	public int AnimalUniqueID { get; set; }

	public float Radius { get; set; }

	public List<Drop_DropModel.DropData> DropProp { get; set; }

	public Act5thHuntingPreyConfigData AnimalConfigData => null;

	public int KillScore => 0;

	public string HeadIcon => null;

	public float SpeedUpValue => 0f;

	public float SpeedUp => 0f;

	public int Quality => 0;

	public Act5thHuntingAnimalType Type => Act5thHuntingAnimalType.None;

	public Act5thHuntingAnimalPoolType PoolType => Act5thHuntingAnimalPoolType.None;

	public (int, int) CreateAngle => default;

	public Act5thHuntingAnimalData SetData(int animalID, int animalUniqueID, CRewardItem[] dropProp)
	{
		return null;
	}

	public Act5thHuntingAnimalData SetData(int animalID, int animalUniqueID, List<Drop_DropModel.DropData> dropProp)
	{
		return null;
	}

	private (int, int) GetCreateAngle()
	{
		return default;
	}
}
