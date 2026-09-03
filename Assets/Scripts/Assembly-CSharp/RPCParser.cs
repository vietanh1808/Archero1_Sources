using System;
using System.Collections.Generic;
using Newtonsoft.Json;

public class RPCParser
{
	public delegate object RpcMethod(List<object> param);

	protected Dictionary<string, RpcMethod> RPCHandler;

	private JsonSerializerSettings settings;

	public string HandleMessage(string json)
	{
		return null;
	}

	public string formatRequest(string method, object idAction, List<object> param = null)
	{
		return null;
	}

	public string formatResponse(object idAction, object result)
	{
		return null;
	}

	public string formatResponseError(object idAction, IDictionary<string, object> data, Exception e)
	{
		return null;
	}

	public void addRpcMethod(string name, RpcMethod method)
	{
	}
}
