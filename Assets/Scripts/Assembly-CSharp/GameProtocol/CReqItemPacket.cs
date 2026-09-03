using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using TableTool;

namespace GameProtocol
{
	[Serializable]
	public sealed class CReqItemPacket : CProtocolBase
	{
		public enum eItemType
		{
			EBattleType = 1,
			ETimeType = 2,
			ELevelType = 3,
			ELayerType = 4,
			EDiamondType = 5,
			EMailType = 6,
			EDiamondToCoinType = 7,
			EItemUpgrade = 8,
			EEquipItemTrans = 9,
			EDiamondToLifeTrans = 10,
			ECoinToPotionTrans = 11,
			EDiamondToPotionTrans = 12,
			EObtainTreasureTrans = 13,
			EBuyDiamondsFromShop = 14,
			EFirstRewardFromShop = 15,
			EEquipCompositeTrans = 16,
			EGameHarvestType = 17,
			EAdGetLifeType = 18,
			EAdGetLuckyType = 19,
			eBlackAdShop = 20,
			eIAPDiscountType = 21,
			eOneStoreFirstReward = 22,
			eHeroBattleType = 23,
			eheroLayerType = 24,
			eDoubleLevelUp = 25,
			EFirstIAPRewardFromShop = 26,
			EDiamondLarge10 = 27,
			EEquipDecompose = 28,
			EOldUserBackReward = 29,
			EStrengthAdUse = 32,
			EUseSkillCard = 33,
			EUseMazeItem = 34,
			NormalTen = 35,
			LargeTen = 36,
			EHellBattleType = 38,
			EHellLayerType = 39,
			EBattlepassReportType = 1001,
			EBattlepassRewardType = 1002,
			EDailyPlayType = 1007,
			EDailyBattleType = 1008,
			ECoopBattleNetReportType = 1013,
			EInvalidType = 1014
		}

		public uint m_nTransID;

		public ushort m_nPacketType;

		public ushort m_nFromType;

		public uint m_nExtraInfo;

		public uint m_nCoinAmount;

		public uint m_nDiamondAmount;

		public ushort m_nLife;

		public uint m_nExperince;

		public CEquipmentItem[] arrayEquipItems;

		public ushort m_nNormalDiamondItem;

		public ushort m_nLargeDiamondItem;

		public ushort m_nRebornCount;

		[NonSerialized]
		private string m_strExtraInfo2;

		public LocalSave.BattleInBase.ServerDropEquips m_dropEquipData;

		public long m_lTime;

		public string m_strMonKill;

		public string m_strGuildMonKill;

		public uint m_nBloodPoint;

		public uint m_nBattleDropActivityMonKillNum;

		[JsonIgnore]
		public override ushort GetMsgType => 0;

		public string m_strExtraInfo
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static bool IsGameOver(eItemType type)
		{
			return false;
		}

		protected override void OnReadFromStream(BinaryReader reader)
		{
		}

		protected override void OnWriteToStream(BinaryWriter writer)
		{
		}

		public List<Drop_DropModel.DropData> getlistBasic(bool refresh_locals_reward)
		{
			return null;
		}

		public List<Drop_DropModel.DropData> getlist(bool refresh_locals_reward)
		{
			return null;
		}

		public List<Drop_DropModel.DropData> getlist(bool refresh_locals_reward, CRespItemPacket data)
		{
			return null;
		}
	}
}
