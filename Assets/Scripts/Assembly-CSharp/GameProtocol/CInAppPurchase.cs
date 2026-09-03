using System;
using System.IO;
using Newtonsoft.Json;

namespace GameProtocol
{
	[Serializable]
	public sealed class CInAppPurchase : CProtocolBase
	{
		public uint m_nTransID;

		public ushort m_nPlatformIndex;

		public string m_nProductID;

		public string m_strReceiptData;

		public uint m_nExtraInfo;

		public string m_strExtra;

		public ushort m_nPayMethod;

		public ushort m_nRowIapId;

		public string m_strPreOrderId;

		public ushort m_nPayRegion;

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
