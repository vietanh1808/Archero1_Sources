using System;
using UnityEngine;

public class BattlePassNewBtnCtrl : MonoBehaviour
{
	public DxxImage iconSelect;

	public DxxImage iconUnselected;

	public GameObject go_SelectRed;

	public GameObject go_UnSelectRed;

	public DxxText textName;

	public ButtonCtrl btnClick;

	private LocalSave.NewBpType _curBpType;

	public void Init(LocalSave.NewBpType bpType, Action<LocalSave.NewBpType> clickCallBack)
	{
	}

	public void RefreshName()
	{
	}

	public void RefreshBtnSelect(LocalSave.NewBpType bpType)
	{
	}

	public void RefreshRedNode()
	{
	}
}
