using System;
using UnityEngine;
using UnityEngine.UI;

public class OBBLoadingUICtrl : MediatorCtrlBase
{
	public static OBBLoadingUICtrl Instance;

	public RectTransform bg;

	public ProgressTextCtrl mProgress;

	public DxxText Text_Loading;

	public Button Button_Retry;

	public DxxText Text_Retry;

	public Action onDownloadFinish;

	private float time;

	private int count;

	public override void OnLanguageChange()
	{
	}

	private void Awake()
	{
	}

	private void update_loading(int count)
	{
	}

	private void Update()
	{
	}

	public void Show(bool value)
	{
	}

	public void start_download()
	{
	}

	private void update_progress(float percent)
	{
	}

	private void showretry(bool value)
	{
	}

	private string get_downloading_language()
	{
		return null;
	}

	private string get_retry_language()
	{
		return null;
	}
}
