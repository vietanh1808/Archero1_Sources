using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ApplicationEvent : MonoBehaviour
{
	public static ApplicationEvent Instance;

	[CompilerGenerated]
	private static Action<bool> m_OnAppPause;

	[CompilerGenerated]
	private static Action<bool> m_OnOnlyMain;

	[CompilerGenerated]
	private static Action m_OnUpdate;

	public static bool bDontExcuteFrontEvent;

	private bool isPause;

	private bool bFirstInGame;

	public static bool bQuit;

	private bool bCheckOnlyMain;

	private bool bOnlyMain;

	private int gametime;

	private int currentgametime;

	private int lastgametime;

	public bool OnlyMain => false;

	public static event Action<bool> OnAppPause
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public static event Action<bool> OnOnlyMain
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public static event Action OnUpdate
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private void Awake()
	{
	}

	private void OnApplicationFocus(bool value)
	{
	}

	private void OnApplicationPause(bool value)
	{
	}

	private void try_login()
	{
	}

	private bool CheckNotice()
	{
		return false;
	}

	private void LateUpdate()
	{
	}

	private void Update()
	{
	}

	private void OnWindowOpen(WindowID openID, List<WindowID> holdlist)
	{
	}

	private void OnWindowClose(WindowID closeID, List<WindowID> holdlist)
	{
	}

	private void check_only_main()
	{
	}

	public bool check_app_start()
	{
		return false;
	}

	private void OnApplicationQuit()
	{
	}
}
