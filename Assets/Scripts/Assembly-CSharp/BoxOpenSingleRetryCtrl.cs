using System;
using UnityEngine;
using UnityEngine.UI;

public class BoxOpenSingleRetryCtrl : MonoBehaviour
{
	public GameObject child;

	public DxxText Text_RetryFree;

	public DxxText Text_RetryExtra;

	public DxxText Text_RetryNotFree;

	public Image Image_Extra;

	public ButtonCtrl Button_Retry;

	public GoldTextCtrl mGoldNow;

	public GoldTextCtrl mGoldOld;

	public RedNodeCtrl mRedNodeCtrl;

	public GameObject notfreeparent;

	public GameObject freeparent;

	public GameObject extraparent;

	public DxxText Text_Extra;

	public Action onRetry;

	private float retry_y;

	private float now_y;

	private float old_y;

	private bool bawake;

	private void Awake()
	{
	}

	private void _awake()
	{
	}

	public void Init(LocalSave.TimeBoxType type, int now, int old)
	{
	}

	public void Show(bool value)
	{
	}

	public void OnLanguageChange()
	{
	}
}
