using System.IO;

namespace GameProtocol
{
	public sealed class CRespUserLoginPacket : IProtocol
	{
		public CEquipmentItem[] m_arrayEquipData;

		public CRestoreItem[] m_arrayRestoreData;

		public CTimestampItem[] m_arrayTimestampData;

		public uint m_nTransID;

		public uint m_nCoins;

		public int m_nDiamonds;

		public ushort m_nMaxLayer;

		public ushort m_nLayerBoxID;

		public ushort m_nLevel;

		public uint m_nExperince;

		public uint m_nTreasureRandomCount;

		public ushort m_nBattleRebornCount;

		public string m_strUserAccessToken;

		public ulong m_nUserRawId;

		public ushort m_nExtraNormalDiamondItem;

		public ushort m_nExtraLargeDiamondItem;

		public ulong m_nGameSystemMask;

		public ushort m_nMaxHeroLayer;

		public ushort m_nHeroLayerBoxID;

		public ushort m_nLargeDiamondItemCount;

		public ulong m_nNowTime;

		public ulong m_nTodayEndTimestamp;

		public ushort m_nAccountStatus;

		public uint m_nTotalCash;

		public bool m_bTalentBackCoin;

		public ushort m_nAdCount;

		public CHeroItem[] m_arrayHeroData;

		public string m_strBindEmailAddress;

		public ushort[] vecActivityRechargeResetType;

		public bool m_bHeroSkinItemIsBuy;

		public string m_strNickName;

		public uint m_nHeadIcon;

		public uint m_nHeadFrame;

		public ulong m_nHeadFrameTimestamp;

		public STHeadItem[] m_vecHeadItem;

		public bool m_bOpenIdfa;

		public uint m_nRemameDiamonds;

		public ushort m_nRenameCount;

		public bool m_bHeroSkinSeniorItemIsBuy;

		public string m_strSkinItemIapProductId;

		public ushort m_nChapFailCnt;

		public ushort m_nHeroChapFailCnt;

		public uint m_nPurcahseInTowWeeks;

		public uint m_nLatest3PurchaseAvg;

		public ushort m_nMixBoxItem;

		public ushort m_nMixBoxSingleCount;

		public ushort m_nMixBoxSingleTotalCount;

		public ushort m_nMixBoxTenCount;

		public ushort m_nDragonBoxItem;

		public ushort m_nDragonBoxCountLow;

		public ushort m_nDragonBoxCountMid;

		public ushort m_nDragonBoxCountHigh;

		public ulong m_nFreeCoinTimestamp;

		public ushort m_nVipLevel;

		public uint m_nVipScore;

		public ulong m_nChapterBanTimestamp;

		public ushort m_nRelicsBoxItem;

		public ushort m_nRelicsBoxCountLow;

		public ushort m_nRelicsBoxCountHigh;

		public ushort m_nOfflineBattleCount;

		public ushort m_nEquipSBoxItem;

		public ushort m_nEquipSBoxCountLow;

		public ushort m_nEquipSBoxCountHigh;

		public uint m_nWorkerBoxKeyCount;

		public ushort m_nWorkerBoxCountLow;

		public ushort m_nWorkerBoxCountMid;

		public ushort m_nWorkerBoxCountHigh;

		public STPetInfo[] m_vecPetInfo;

		public uint m_nPetBoxKeyCount;

		public ushort m_nPetBoxCountLow;

		public ushort m_nPetBoxCountMid;

		public ushort m_nPetBoxCountHigh;

		public string m_strHabbyID;

		public ulong m_nMustDropMask;

		public ulong m_nGuildStopTimestamp;

		public uint m_nStarDiamond;

		public ulong m_nExperinceInt64;

		public long m_nCoinsInt64;

		public uint m_nImprintBoxKeyCount;

		public CBoxAssuranceItem[] m_arrayAssuranceData;

		public ushort m_nMaxHellLayer;

		public ushort m_nHellLayerBoxID;

		public ushort m_nChapHellFailCount;

		public CArtifact[] m_vecArtifactArray;

		public ushort m_nUpgradeLevel;

		public uint m_nCardThemeId;

		public ulong m_nCardThemeTimestamp;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}

		private byte[] buildPacket()
		{
			return null;
		}
	}
}
