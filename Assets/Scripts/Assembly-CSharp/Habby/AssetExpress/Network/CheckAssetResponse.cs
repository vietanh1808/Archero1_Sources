using Habby.AssetExpress.Model;

namespace Habby.AssetExpress.Network
{
	public class CheckAssetResponse
	{
		public const int CODE_SUCCESS = 0;

		public int code;

		public ResourceInfo data;
	}
}
