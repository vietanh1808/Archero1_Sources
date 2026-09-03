using System;
using UnityEngine;

public class RuneTabItemCtrl : MonoBehaviour
{
	public DxxText labelText;

	public RedNodeCtrl redCtrl;

	public Action<int, RuneGroup> onClick;

	private int index;

	private readonly Color inactiveTextColor;

	private readonly Color activeTextColor;

	public RuneGroup data { get; set; }

	public void InitData(int index, RuneGroup data)
	{
	}

	public void SetStatus(bool isActive)
	{
	}

	public void UpdateRed()
	{
	}

	public void OnLanguageChange()
	{
	}

	public void OnClick()
	{
	}
}
