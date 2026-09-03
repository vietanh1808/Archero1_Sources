using System;
using UnityEngine;

public class RuneTabCtrl : MonoBehaviour
{
	public RuneTabItemCtrl runeTab;

	public Action<int, RuneGroup> onClick;

	private RuneTabItemCtrl[] runeTabs;

	public void OnInit()
	{
	}

	public void OnOpen()
	{
	}

	public void OnClick(int index, RuneGroup data)
	{
	}

	public void UpdateRed()
	{
	}

	public void OnLanguageChange()
	{
	}
}
