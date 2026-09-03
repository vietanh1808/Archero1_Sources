using System;
using Dxx.Net;
using XLua;

public abstract class SingletonNet<T, T1, T2> : ISingletonNet, ISingleton where T : new() where T1 : CProtocolBase where T2 : class
{
	private static T _instance;

	private static DelegateBridge __Hotfix0_get_Instance;

	private static DelegateBridge __Hotfix0_get_IsRequesting;

	private static DelegateBridge __Hotfix0_set_IsRequesting;

	private static DelegateBridge __Hotfix0_get_TimeRequest;

	private static DelegateBridge __Hotfix0_set_TimeRequest;

	private static DelegateBridge __Hotfix0_LateInit;

	private static DelegateBridge __Hotfix0_ReLogin;

	private static DelegateBridge __Hotfix0_RequestType;

	private static DelegateBridge __Hotfix0_Request;

	private static DelegateBridge __Hotfix0_OnInit;

	private static DelegateBridge __Hotfix0_OnLateInit;

	private static DelegateBridge __Hotfix0_OnReLogin;

	private static DelegateBridge __Hotfix0_OnClear;

	private static DelegateBridge __Hotfix0_SingletonNetName;

	private static DelegateBridge __Hotfix0_RequestData;

	private static DelegateBridge _c__Hotfix0_ctor;

	public static T Instance => default;

	private bool IsRequesting { get; set; }

	private TimeRequest TimeRequest { get; set; }

	protected abstract string Name { get; }

	protected abstract void Init();

	protected virtual void LateInit()
	{
	}

	protected virtual void ReLogin()
	{
	}

	protected abstract void Clear();

	protected abstract T1 RequestPacket();

	protected virtual SendType RequestType()
	{
		return SendType.eUDP;
	}

	public abstract SendRequestTime RequestTime();

	protected abstract bool AllowBurstRequest();

	protected abstract bool RequestCond();

	public void Request(Action<NetResponse> callBack = null, bool isForeceRequest = false)
	{
	}

	protected abstract void Response(NetResponse response, T2 data, TimeRequest timeRequest = TimeRequest.None);

	public void OnInit()
	{
	}

	public void OnLateInit()
	{
	}

	public void OnReLogin()
	{
	}

	public void OnClear()
	{
	}

	public string SingletonNetName()
	{
		return null;
	}

	public virtual void RequestData(Action<NetResponse> callBack, bool isForceRequest = false, TimeRequest timeRequest = TimeRequest.None)
	{
	}
}
