using System;
using PureMVC.Patterns;

public class ChallengeContractProxy : Proxy
{
	public class Transfer
	{
		public Action OnCloseEvent;

		public Transfer(Action OnCloseEvent)
		{
		}
	}

	public new const string NAME = "ChallengeContractProxy";

	public ChallengeContractProxy(object data)
	{
	}
}
