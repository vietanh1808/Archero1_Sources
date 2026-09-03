using System.IO;

namespace GameProtocol
{
	public sealed class STRespActivityPrivilege : IProtocol
	{
		public CCommonRespMsg m_stRetMsg;

		public ulong m_nStartTime;

		public ulong m_nEndTime;

		public uint m_nOpenGameLevel;

		public uint[] m_arrayPrivileges;

		public string strTasks;

		public uint[] m_arrayPrivilegeValues;

		public string m_strTaskConfig;

		public ushort GetMsgType => 0;

		public void ReadFromStream(BinaryReader reader)
		{
		}

		public void WriteToStream(BinaryWriter writer)
		{
		}
	}
}
