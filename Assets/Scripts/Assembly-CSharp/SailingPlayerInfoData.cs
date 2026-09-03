using System.Collections.Generic;
using GameProtocol;

public class SailingPlayerInfoData
{
	public ulong UserID;

	public string UserName;

	public int HeadID;

	public int HeadFrameID;

	public long HeadFrameTimeStamp;

	public int Peerage;

	public int VipLevel;

	public STShipBattleShipInfoProtoData ShipAllData;

	public int TalentLevel;

	public Dictionary<string, double> ShipAttr;

	public int AllPower;

	public static SailingPlayerInfoData Create(ulong userID, string userName, int headID, int headFrameID, long headFrameTimeStamp, int peerage, int vipLevel, STShipBattleShipInfoProtoData shipData, int talentLevel, Dictionary<string, double> shipAtt, int allPower)
	{
		return null;
	}
}
