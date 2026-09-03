using UnityEngine;
using UnityEngine.Events;

public class AdsController : MonoBehaviour, AdsRequestHelper.AdsCallback
{
	public ADSource source;

	public ADCountSource countSource;

	public UnityAction<bool> callback_WatchAd;

	public int adapterId;

	public bool adInside;

	public void doWatchAds()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
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

	private void onRewardWrapper(AdsRequestHelper.AdsDriver sender, string networkName)
	{
	}

	private void onRewardInternal()
	{
	}
}
