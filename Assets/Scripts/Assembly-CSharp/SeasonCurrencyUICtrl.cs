using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class SeasonCurrencyUICtrl : MediatorCtrlBase
{
	[SerializeField]
	private RectTransform title;

	[SerializeField]
	private ButtonCtrl Button_Key;

	[SerializeField]
	private ButtonCtrl Button_Diamond;

	[SerializeField]
	private DxxText Text_SoulPoint;

	[SerializeField]
	private DxxText Text_Crystallization;

	[SerializeField]
	private DxxText Text_Diamond;

	[SerializeField]
	private DxxText Text_SuperCrystal;

	[SerializeField]
	private ProgressTextCtrl mProgressCtrl;

	[SerializeField]
	private DxxText Text_UseKey;

	[SerializeField]
	private CanvasGroup mUseKey;

	[SerializeField]
	private Image mImageKey;

	[SerializeField]
	private Image mImageSoulPoint;

	[SerializeField]
	private Image mImageSoulCrystal;

	[SerializeField]
	private Image mImageSuperSoulCrystal;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void SetUseKeyShow(bool value)
	{
	}

	public override void OnLanguageChange()
	{
	}

	private void setSuperVisible(bool isSuperVisible)
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	public override object OnGetEvent(string eventName)
	{
		return null;
	}

	private Vector3 GetUseStartPos(CurrencyType type)
	{
		return default;
	}
}
