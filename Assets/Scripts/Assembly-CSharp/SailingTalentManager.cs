using System;
using System.Collections.Generic;
using System.Text;
using Dxx.Net;
using GameProtocol;

public class SailingTalentManager : SingletonNet<SailingTalentManager, CReqShipBattleTalent, CRespShipBattleTalent>
{
	private class Weight
	{
		public int id;

		public int weight;
	}

	private bool m_bHaveSyncData;

	private const string Tag = "SailingTalentManager";

	private StringBuilder sb;

	protected override string Name => null;

	private CampTalentPersonalData SailingTalentPersonalData { get; set; }

	private SailingTalentPersonalProgressData SailingTalentPersonalProgressData { get; set; }

	public List<string> SailingTalentBattleAttributes => null;

	public List<int> SailingTalentBattleSkillIds => null;

	public bool NewPlay125_ReplaceDouble_Value => false;

	public float NewPlay125_Replace_Value => 0f;

	public int ShipPower => 0;

	protected override void Init()
	{
	}

	protected override void Clear()
	{
	}

	protected override CReqShipBattleTalent RequestPacket()
	{
		return null;
	}

	public override SendRequestTime RequestTime()
	{
		return SendRequestTime.None;
	}

	protected override bool AllowBurstRequest()
	{
		return false;
	}

	public bool IsSyncData()
	{
		return false;
	}

	protected override bool RequestCond()
	{
		return false;
	}

	protected override void Response(NetResponse response, CRespShipBattleTalent data, TimeRequest timeRequest = TimeRequest.None)
	{
	}

	public SailingTalentPersonalProgressData GetSailingTalentPersonalProgressData()
	{
		return null;
	}

	private void SetData(CShipBattleTalent[] personalTalentData)
	{
	}

	private void SaveData(CShipBattleTalent[] salingTalent)
	{
	}

	public string GetPersonalReachAttribute(bool isSpecial)
	{
		return null;
	}

	public string GetPersonalAttributeWithNext(int talentID, int level)
	{
		return null;
	}

	public void RequestPersonalUpgrade(int talentID, Action<CCommonRespMsg> success = null, Action<CRespShipBattleTalent> failure = null)
	{
	}

	public CampTalentPersonalData GetSailingTalentPersonalData()
	{
		return null;
	}

	public void SavePersonalData(int id, int level)
	{
	}

	public bool HavePersonalRed()
	{
		return false;
	}

	public List<SailingTalentPersonalProgressItemData> GetAllUpgradePersonalTalentData()
	{
		return null;
	}

	public List<CampTalentAttribute> GetAttributesByType(SailingTalentAttributeType attrType)
	{
		return null;
	}

	public string GetAttributeDescirbesByType(SailingTalentAttributeType attrType)
	{
		return null;
	}

	private int GetAttributeNumByName(string name)
	{
		return 0;
	}

	private List<string> GetExtraParam1ByName(string name)
	{
		return null;
	}

	public (int, int) NewPlay125_QualityRateUp_Value(int quality)
	{
		return default;
	}

	public (int, int) NewPlay125_IDRateUp_Value(int id)
	{
		return default;
	}

	public int NewPlay125_MixMoney_Value(int quality)
	{
		return 0;
	}

	public List<int> NewPlay125_FirstItem_Value()
	{
		return null;
	}

	public int NewPlay125_RefreshNewItem_Value(int times)
	{
		return 0;
	}

	public int Ship_EventRateGetItemPercent_Value(int equipId)
	{
		return 0;
	}

	private (int, int) GetRateUp(string name, Func<int, bool> func)
	{
		return default;
	}

	private void Log(string message)
	{
	}

	private void LogError(string message)
	{
	}

	private void LogWarning(string message)
	{
	}

	private void add2Attrs(List<string> attrs, string attrName, int attrValue)
	{
	}

	private void add2Attrs(List<string> attrs, string attr)
	{
	}

	private void add2SkillIds(string[] attributes, List<int> skillIds)
	{
	}
}
