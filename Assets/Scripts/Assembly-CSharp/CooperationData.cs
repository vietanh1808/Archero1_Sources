using System;

[Serializable]
public class CooperationData
{
	public enum ModeType
	{
		creatRoom = 0,
		match = 1,
		joinRoom = 2
	}

	public enum MatchType
	{
		none = 0,
		normal = 1,
		pvp1 = 2,
		pvp2 = 3,
		pvp3 = 4,
		pvp4 = 5
	}

	public ModeType type;

	public MatchType matchType;

	public int dailyId { get; set; }

	public string roomId { get; set; }

	public int netVersion { get; set; }

	public object data { get; set; }

	public void SetCooperationData(ModeType pModeType, int pID, MatchType pMatchType)
	{
	}

	public void CopyFrom(CooperationData pDst)
	{
	}
}
