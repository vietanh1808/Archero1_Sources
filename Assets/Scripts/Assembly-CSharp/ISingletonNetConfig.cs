using System;
using Dxx.Net;

public interface ISingletonNetConfig : ISingletonNet, ISingleton
{
	string NetConfigFolderPath();

	string NetConfigFolderName();

	SendType NetConfigRequestType();

	void RequestConfigData(Action<string> successCallBack, Action<float> downLoadingProgress, bool isForce);
}
