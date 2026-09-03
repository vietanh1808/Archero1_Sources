using System.IO;
using Newtonsoft.Json;

namespace GameProtocol
{
	public sealed class CUserLoginPacket : CProtocolBase
	{
		public uint m_nTransID;

		public string m_strPlatform;

		[JsonIgnore]
		private string _strOldUserID;

		public override ushort GetMsgType => 0;

		[JsonIgnore]
		public string m_strOldUserID
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected override void OnReadFromStream(BinaryReader reader)
		{
		}

		protected override void OnWriteToStream(BinaryWriter writer)
		{
		}
	}
}
