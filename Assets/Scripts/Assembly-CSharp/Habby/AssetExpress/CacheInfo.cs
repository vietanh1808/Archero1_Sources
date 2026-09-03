using System;
using System.Runtime.Serialization;

namespace Habby.AssetExpress
{
	[Serializable]
	public class CacheInfo : ISerializable
	{
		public string AppVersion;

		public int HotfixVersion;

		public int BuiltinVersion;

		public int BundleVersionCode;

		public int PatchVersion;

		public bool Patching;

		public string LuaVersion;

		public long ExpireAt;

		public string UID;

		public CacheInfo()
		{
		}

		public CacheInfo(SerializationInfo info, StreamingContext context)
		{
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
