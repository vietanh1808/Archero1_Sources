using System;

[Serializable]
public class BeliefTalentData
{
	public int ID;

	public int Status;

	public static BeliefTalentData Create(int id, int status)
	{
		return null;
	}

	public void RefreshStatus(int status)
	{
	}

	public int GetStatus()
	{
		return 0;
	}

	public BeliefTalentData Clone()
	{
		return null;
	}
}
