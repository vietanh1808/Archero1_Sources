using System;

[Serializable]
public class LocalCampTalentData : LocalSave.ICloneable<LocalCampTalentData>
{
	public int rewardID;

	public int donateTeamPoint;

	public int teamTalentPoint;

	public CampTalent[] campTalent;

	public void Clone(LocalCampTalentData source)
	{
	}

	public void SetData(CampTalent[] campTalent, int teamTalentPoint, int donateTeamPoint, int rewardID)
	{
	}

	public void SetData(int id, int level)
	{
	}

	public void SetData(int teamTalentPoint)
	{
	}

	public void Clear()
	{
	}
}
