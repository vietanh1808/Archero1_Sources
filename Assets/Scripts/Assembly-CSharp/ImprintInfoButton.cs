using System;
using UnityEngine;

public class ImprintInfoButton : MonoBehaviour
{
	public ButtonCtrl button;

	public DxxText btn_text;

	public DxxText tip_text;

	public RedNodeCtrl redNode;

	private Action clickDo;

	private string buttonName;

	private Func<bool> onRedShow;

	public void Init(Action _clickDo, string _buttonName, Func<bool> _onRedShow)
	{
	}

	public void onClick()
	{
	}

	public void RefreshRed()
	{
	}

	public void SetTip(string str)
	{
	}

	public void OnLanguageChange()
	{
	}

	public void SetButtonName(string name)
	{
	}
}
