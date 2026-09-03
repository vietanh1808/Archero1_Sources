using UnityEngine;
using UnityEngine.UI;

public class MainUIDropUpCtrl : MainUIButtonBase
{
	public GameObject child;

	public RedNodeCtrl mRedCtrl;

	public ButtonCtrl Button_Reward;

	public GameObject effect;

	private bool isexecute;

	public DxxText Text_Time;

	public Image Image_Icon;

	private int showAct;

	private long showTime;

	private void Awake()
	{
	}

	private void Show(bool value)
	{
	}

	public new void UpdateUI()
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

	private void UpdateTime()
	{
	}

	public override long GetOpenTime()
	{
		return 0L;
	}

	public override bool isRed()
	{
		return false;
	}

	private (long, DropUpPropType) GetBeginTime()
	{
		return default;
	}
}
