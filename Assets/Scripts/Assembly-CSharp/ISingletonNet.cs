using System;
using Dxx.Net;

public interface ISingletonNet : ISingleton
{
	string SingletonNetName();

	void RequestData(Action<NetResponse> callBack, bool isForceRequest = false, TimeRequest timeRequest = TimeRequest.None);

	SendRequestTime RequestTime();
}
