using System;
using System.Collections.Generic;
using Dxx.Net;

public class EquipStoragePageMgr : CInstance<EquipStoragePageMgr>
{
	public EquipStorageData ESData;

	private int crtPage;

	public const int DEFAULT_ROLE = 10000;

	public const int DEFAULT_ROLE_SKIN = 110000;

	public const int MaxPageCount = 3;

	public const float ClickCD = 5f;

	private float clickLeftTime;

	private bool isPage1Saved;

	private bool isPage2Saved;

	private bool isPage3Saved;

	public List<string> Wears
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private int OpenLevel => 0;

	private int ForceOpenLevel => 0;

	public void SetClickLeftTime(float leftTime)
	{
	}

	public float GetClickLeftTime()
	{
		return 0f;
	}

	protected override void Init()
	{
	}

	protected override void Clear()
	{
	}

	public bool IsOpen()
	{
		return false;
	}

	public bool IsForceOpen()
	{
		return false;
	}

	public void ReqEquipStorageInfo(Action<bool> callback = null)
	{
	}

	public void ReqSaveEquipStorageInfo(string json, Action<bool> callback)
	{
	}

	public void ReqUseEquipStorageCase(Action<bool> callback)
	{
	}

	private bool ValidResponse(NetResponse response, Action<bool> action)
	{
		return false;
	}

	public bool IsCrtPageSaved()
	{
		return false;
	}

	public EquipStorageItemData GetStorageDataByPageIndex(int index)
	{
		return null;
	}

	public EquipStorageItemData GetStorageCrtPageData()
	{
		return null;
	}

	public void SetCrtPage(int page)
	{
	}

	public int GetCrtPage()
	{
		return 0;
	}

	public string GetCrtWearJsonData()
	{
		return null;
	}
}
