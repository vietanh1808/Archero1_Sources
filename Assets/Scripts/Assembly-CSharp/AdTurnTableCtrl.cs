using System;
using UnityEngine;
using UnityEngine.UI;

public class AdTurnTableCtrl : MonoBehaviour, AdsRequestHelper.AdsCallback
{
	public DxxText Text_Title;

	public Image Image_Ad;

	public ButtonCtrl Button_Cancel;

	public ButtonCtrl Button_Ad;

	public GameTurnTableCtrl mTurnCtrl;

	public DxxText Text_Turn;

	public DxxText Text_BPFree;

	public DxxText Text_Last;

	[SerializeField]
	private GameObject jumpMask;

	[SerializeField]
	private DxxText jumpText;

	[SerializeField]
	private ButtonCtrl jumpBtn;

	public Action onClickClose;

	private ADSource source;

	private float Text_TurnX;

	private bool bStartTurn;

	private TurnTableType resultType;

	private int[] qualities;

	private bool bAdReward;

	private bool bOpened;

	private Action OnRotateStartAction;

	private Action OnRotateEndAction;

	public void Init(Action onRotateStart, Action onRotateEnd)
	{
	}

	public void Open()
	{
	}

	private void InitUI()
	{
	}

	public void show_close(bool value)
	{
	}

	private void show_button(bool value)
	{
	}

	public void Deinit()
	{
	}

	public void OnLanguageChange()
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

	private void onRewardWrapper()
	{
	}

	public void onReward(AdsRequestHelper.AdsDriver sender, string networkName)
	{
	}

	private void onRewardInternal()
	{
	}
}
