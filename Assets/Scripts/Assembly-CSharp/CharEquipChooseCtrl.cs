using System;
using UnityEngine;

public class CharEquipChooseCtrl : MonoBehaviour
{
	[NonSerialized]
	public LocalSave.EquipOne equipdata;

	private int wearindex;

	private bool bShow;

	private string uniqueid;

	private int mIndex;

	public void Init(LocalSave.EquipOne equip)
	{
	}

	public void Show(bool show)
	{
	}

	public void Miss()
	{
	}

	public void ChangeShow()
	{
	}

	public bool GetShow()
	{
		return false;
	}

	public void SetIndex(int index)
	{
	}

	public int GetIndex()
	{
		return 0;
	}

	public void UpdateNet()
	{
	}

	public void OnLanguageChange()
	{
	}
}
