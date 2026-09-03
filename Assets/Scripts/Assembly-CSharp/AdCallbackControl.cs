using System;
using Dxx.Util;

public class AdCallbackControl : AdsRequestHelper.AdsCallback
{
	public Action onAdClose;

	public int adapterId;

	private ADSource source;

	private Action callback;

	private SequencePool mPool;

	private bool bCallback;

	private bool bOpened;

	public AdCallbackControl(ADSource source)
	{
	}

	public void SetCallback(Action callback)
	{
	}

	public void Init()
	{
	}

	public void DeInit()
	{
	}

	public bool IsLoaded(int adapterId = 0)
	{
		return false;
	}

	public void Show(int adapterId = 0)
	{
	}

	public void onRequest(AdsRequestHelper.AdsDriver sender, string networkName)
	{
	}

	public void onLoad(AdsRequestHelper.AdsDriver sender, string networkName)
	{
	}

	public void onFail(AdsRequestHelper.AdsDriver sender, string msg)
	{
	}

	public void onOpen(AdsRequestHelper.AdsDriver sender, string networkName)
	{
	}

	public void onClose(AdsRequestHelper.AdsDriver sender, string networkName)
	{
	}

	public void onClick(AdsRequestHelper.AdsDriver sender, string networkName)
	{
	}

	public void onReward(AdsRequestHelper.AdsDriver sender, string networkName)
	{
	}
}
