using System;
using System.IO;
using Newtonsoft.Json;

namespace GameProtocol
{
	[Serializable]
	public sealed class CLifeTransPacket : CProtocolBase
	{
		public enum eLifeTransType
		{
			ETransSpendLife = 1,
			ETransDiamondToLife = 2,
			ETransCoinToPotion = 3,
			ETransDiamondToPotion = 4,
			ETransDiamondToRevival = 5,
			ETransDiamondToMageRefresh = 6,
			EInvalidType = 7
		}

		public uint m_nTransID;

		public ushort m_nMaterial;

		public byte m_nType;

		public byte m_nOffline;

		public uint m_nBattleTransID;

		public ushort m_nChapId;

		[JsonIgnore]
		public override ushort GetMsgType => 0;

		protected override void OnReadFromStream(BinaryReader reader)
		{
		}

		protected override void OnWriteToStream(BinaryWriter writer)
		{
		}
	}
}
