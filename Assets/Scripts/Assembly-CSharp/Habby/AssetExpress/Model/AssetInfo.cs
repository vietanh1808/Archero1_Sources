using System;
using System.Runtime.Serialization;

namespace Habby.AssetExpress.Model
{
	[Serializable]
	public class AssetInfo : ISerializable
	{
		public string name;

		public string bundle;

		public int type;

		public AssetInfo()
		{
		}

		public AssetInfo(SerializationInfo info, StreamingContext context)
		{
		}

		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
