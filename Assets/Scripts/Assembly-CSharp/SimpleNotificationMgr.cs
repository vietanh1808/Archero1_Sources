using System;
using System.Collections.Generic;
using UnityEngine;

public class SimpleNotificationMgr : MonoBehaviour
{
	private static readonly string titleKey;

	private static readonly string contentKey;

	private List<int> timeDelayList;

	public static readonly string ChannelId;

	public static void Init()
	{
	}

	private void Awake()
	{
	}

	private void OnApplicationPause(bool pause)
	{
	}

	private void OnApplicationQuit()
	{
	}

	private void ClearAllNotifications()
	{
	}

	private void RegistAllNotifications()
	{
	}

	public int SendNotification(string title, string body, DateTime fireTime)
	{
		return 0;
	}
}
