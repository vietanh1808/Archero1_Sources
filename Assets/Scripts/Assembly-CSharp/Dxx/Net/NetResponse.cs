using GameProtocol;

namespace Dxx.Net
{
	public class NetResponse
	{
		public IProtocol data;

		public CCommonRespMsg error;

		public int errorid;

		public string requestId;

		public bool IsSuccess => false;

		public bool IsTimeOut => false;
	}
}
