using System;
using PureMVC.Patterns;

public class ChooseRoleReversalProxy : Proxy
{
	public class Transfer
	{
		public Action<bool> OnChooseEvent;

		public int ID { get; private set; }

		public float scale { get; private set; }

		public Transfer(int id, float scale, Action<bool> OnChooseEvent)
		{
		}
	}

	public new const string NAME = "ChooseRoleReversalProxy";

	public ChooseRoleReversalProxy(object data)
	{
	}
}
