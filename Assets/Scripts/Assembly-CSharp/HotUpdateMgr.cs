using System.Collections.Generic;
using Habby.AssetExpress.Model;

public class HotUpdateMgr : CInstance<HotUpdateMgr>
{
	private class CachedEvent
	{
		public string action;

		public string source;

		public int verOld;

		public int verNew;

		public string reason;
	}

	private bool needPopup;

	private Queue<CachedEvent> cachedEvents;

	private static readonly string[] typeStr;

	private static readonly string[] statusStr;

	public new void Init()
	{
	}

	public void OnBundleDownloadedStart(DownloadDescription downloadDesc)
	{
	}

	public void OnBundleDownloadedFinish(DownloadDescription downloadDesc)
	{
	}

	public void OnBundleDownloadedFail(DownloadDescription downloadDesc)
	{
	}

	public void OnHotfixDownloadStarted(ResourceInfo resourceInfo)
	{
	}

	public void OnHotfixDownloadFinished(ResourceInfo resourceInfo)
	{
	}

	public void CheckUpdatePopup()
	{
	}

	public void OnCloseGame()
	{
	}

	private void SendEvent(string action, string source, string reason = null)
	{
	}

	public void FlushMessages()
	{
	}

	public string GetStatus()
	{
		return null;
	}
}
