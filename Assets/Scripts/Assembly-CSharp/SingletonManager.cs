using System;
using System.Collections.Generic;

public class SingletonManager : CInstance<SingletonManager>
{
	private List<ISingletonNet> SingletonNets;

	private List<ISingletonNetConfig> SingletonNetConfigs;

	private List<ISingleton> Singletons;

	public new void Init()
	{
	}

	public new void ReLogin()
	{
	}

	public new void Clear()
	{
	}

	public void RequestLogin()
	{
	}

	public List<Action> GetRequestsMain()
	{
		return null;
	}

	public void RequestMain()
	{
	}

	public void RequestConfigStart()
	{
	}
}
