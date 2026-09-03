using UnityEngine;
using UnityEngine.UI;

public class MainUIHarvestCtrl : MainUIButtonBase
{
	public GameObject child;

	public ButtonCtrl Button_Harvest;

	public RedNodeCtrl mRedCtrl;

	public DxxText mDescText;

	public Image mImage;

	private void Awake()
	{
	}

	private void Show(bool value)
	{
	}

	public new void UpdateUI()
	{
	}

	public override bool IsShow()
	{
		return false;
	}

	public override int GetPriority()
	{
		return 0;
	}

	public override RectTransform GetTransform()
	{
		return null;
	}

	public override void OnLanguageChange()
	{
	}

	public override long GetOpenTime()
	{
		return 0L;
	}

	public void onButtonIcon()
	{
	}
}
