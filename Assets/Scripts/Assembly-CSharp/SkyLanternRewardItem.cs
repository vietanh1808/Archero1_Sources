using System;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class SkyLanternRewardItem : MonoBehaviour
{
	public Image iconImg;

	public DxxText numText;

	public ButtonCtrl showBtn;

	public ButtonCtrl exchangeBtn;

	public GameObject lanternObj;

	public GameObject lightObj;

	public GameObject selecteffectObj;

	public GameObject lanterneffectObj;

	public GameObject selectObj;

	public Image lanternImg;

	public bool isBig;

	public Action<SkyLanternRewardData> onClickExchange;

	private Tween tween;

	public SkyLanternRewardData mData { get; private set; }

	public void Init(Action<SkyLanternRewardData> callBack)
	{
	}

	public void Open(SkyLanternRewardData data)
	{
	}

	public void Refresh()
	{
	}

	public void ClickShow()
	{
	}

	public void ClickExchange()
	{
	}

	public void ShowLight(bool isShow)
	{
	}

	public void ShowSelect()
	{
	}

	public void SetHasGet()
	{
	}

	public void PlayFly()
	{
	}

	public void PlayBack(Action callBackDo)
	{
	}

	public void SrtatFloat()
	{
	}
}
