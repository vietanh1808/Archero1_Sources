using UnityEngine;

public class SeasonBPEntrance : MainUIButtonBase
{
	public GameObject child;

	public RedNodeCtrl mRedCtrl;

	public ButtonCtrl Button_Reward;

	public GameObject effect;

	private void Awake()
	{
	}

	public override void OnAdd()
	{
	}

	private void Show(bool value)
	{
	}

	public new void UpdateUI()
	{
	}

	private void Update()
	{
	}

	private void RefUI()
	{
	}

	public override int GetPriority()
	{
		return 0;
	}

	public override RectTransform GetTransform()
	{
		return null;
	}

	public override bool IsShow()
	{
		return false;
	}

	public override long GetOpenTime()
	{
		return 0L;
	}
}
