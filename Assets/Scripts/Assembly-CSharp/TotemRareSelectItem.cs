using System;
using UnityEngine;

public class TotemRareSelectItem : MonoBehaviour
{
	[SerializeField]
	private ButtonCtrl btnSelected;

	[SerializeField]
	private DxxText rareTxt;

	[SerializeField]
	private DxxImage selectedIcon;

	public void Init(int rare, Action<int, bool> clicked)
	{
	}

	public void SetSelectStatus()
	{
	}
}
