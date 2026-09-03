using System;
using UnityEngine;

public class EquipColorItem : MonoBehaviour
{
	[SerializeField]
	private ButtonCtrl btnColor;

	[SerializeField]
	private DxxImage colorIcon;

	[SerializeField]
	private GameObject goTick;

	[SerializeField]
	private GameObject goSelect;

	[SerializeField]
	private GameObject goLock;

	[SerializeField]
	private GameObject goRed;

	[SerializeField]
	private GameObject goEffect;

	public int _colorID;

	public int _typeInfoID;

	public void Init(int colorID, int typeInfoID, Action<int> callBack)
	{
	}

	public void SetSelect(int colorID)
	{
	}

	public void RefreshRed()
	{
	}
}
