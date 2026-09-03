using System;
using Dxx.Addressable;
using PureMVC.Patterns;
using UnityEngine;

public class DownloadLevelProxy : Proxy
{
	public class Transfer
	{
		public FunctionalModule module;

		public Sprite sp;

		public long cd;

		public Func<FunctionalModule, float> process;

		public Action endCb;
	}

	public new const string NAME = "DownloadLevelProxy";

	public DownloadLevelProxy(object data)
	{
	}
}
