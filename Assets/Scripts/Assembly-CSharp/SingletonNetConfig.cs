using System;
using Dxx.Net;

public abstract class SingletonNetConfig<T, T1, T2> : SingletonNet<T, T1, T2>, ISingletonNetConfig, ISingletonNet, ISingleton where T : new() where T1 : CProtocolBase where T2 : class
{
	protected abstract string ConfigFolderPath { get; }

	protected abstract string ConfigFolderName { get; }

	protected abstract void ResponseConfig(string configData);

	protected virtual SendType ConfigRequestType()
	{
		return SendType.eUDP;
	}

	public void RequestConfig(Action<string> successCallBack = null, Action<float> downLoadingProgress = null, bool isForce = false)
	{
	}

	public string NetConfigFolderPath()
	{
		return null;
	}

	public string NetConfigFolderName()
	{
		return null;
	}

	public SendType NetConfigRequestType()
	{
		return SendType.eUDP;
	}

	public virtual void RequestConfigData(Action<string> successCallBack, Action<float> downLoadingProgress, bool isForce)
	{
	}
}
