using System;
using UnityEngine;

public class ButtonAdControl : MonoBehaviour
{
	public enum ButtonType
	{
		eNormal = 0,
		eInside = 1
	}

	public enum ButtonPath
	{
		ButtonAdOne_NormalYellow = 0,
		ButtonAdOne_NormalGreen = 1,
		ButtonAdOne_LargeYellow = 2,
		ButtonAdOne_SmallYellow = 3,
		ButtonAdOne_SmallGreen = 4,
		ButtonAdOne_240_100_Green = 5
	}

	public ButtonPath Path;

	public ButtonType type;

	public ADSource source;

	public ADCountSource countSource;

	public Action onShowBefore;

	public Action onClose;

	private int adapterId;

	private string languagetid;

	private Action onclick;

	private AdCallbackControl mAd;

	private ButtonAdControlOne _one;

	private ButtonAdControlOne mOne => null;

	private void onAdEndWrapper()
	{
	}

	public void Init(string languagetid, Action onclick)
	{
	}

	public void Init_High(string languagetid, Action onclick)
	{
	}

	private void onclick_normal()
	{
	}

	private void onclick_inside()
	{
	}

	public void Open()
	{
	}

	public void Close()
	{
	}

	public void OnLanguageChange()
	{
	}
}
