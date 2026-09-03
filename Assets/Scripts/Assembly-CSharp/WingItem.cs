using System;
using UnityEngine;
using UnityEngine.UI;

public class WingItem : MonoBehaviour
{
	public Image bgIcon;

	public Image rarityIcon;

	public Image icon;

	public GameObject selectObj;

	public GameObject maskObj;

	public GameObject wearObj;

	public DxxText wearTex;

	private LocalSave.WingOne mData;

	private bool isSelect;

	public Action<LocalSave.WingOne> onSelect;

	public void Open(LocalSave.WingOne data)
	{
	}

	public void Refresh()
	{
	}

	public void Click()
	{
	}

	public void SetSelect(bool isSelect)
	{
	}

	public void SetSelect(int id)
	{
	}

	private void OnUnLock()
	{
	}

	private void OnWear(bool iswear)
	{
	}

	private void OnDisable()
	{
	}

	public void Close()
	{
	}
}
