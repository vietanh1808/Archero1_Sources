using System.Collections.Generic;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class BattleLoadUICtrl : MediatorCtrlBase
{
	private const string ShowAnimationName = "LoadShow";

	private const string MissAnimationName = "LoadMiss";

	public static Color debugColor;

	public static bool useDebugColor;

	public Image bgimage;

	public Animator ani;

	public CanvasGroup ani_canvasgroup;

	public DxxText Text_Content;

	public GameObject loadingparent;

	private float anitime;

	private BattleLoadProxy.BattleLoadData loaddata;

	private WaitForSecondsRealtime wait01;

	private WaitForSecondsRealtime opentime;

	private int startframe;

	private bool bStart;

	private int levelAssetCount;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void InitUI()
	{
	}

	public static bool TryGetBundleGroup(out string groupName)
	{
		groupName = null;
		return false;
	}

	protected override void OnClose()
	{
	}

	private void PlayOpen()
	{
	}

	private void BeginClose()
	{
	}

	private void OnCheckFinish(string groupName, bool ifFinish, int downloadCount, int downloadSize, List<string> downloadList)
	{
	}

	private void OnLoadGroup(string groupName, bool ifFinish, float percent)
	{
	}

	private void OnDownloadGroup(ResourceManager.BundleGroup group, bool ifSuccess)
	{
	}

	private void OnLoadAsset(string assetName, bool ifSuccess, object obj)
	{
	}

	private void PlayClose()
	{
	}

	private void show_camera(bool value)
	{
	}

	public override object OnGetEvent(string eventName)
	{
		return null;
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	public override void OnLanguageChange()
	{
	}
}
