using System;
using System.Collections.Generic;
using UnityEngine;

public class DragonSortCtrl : MonoBehaviour
{
	public ButtonCtrl Button_Sort;

	public DxxText Text_Sort;

	private const int sorttypecount = 2;

	private static string[] sortstrings;

	public Action<List<LocalSave.EquipOne>> OnButtonClick;

	private string sortKey;

	private Func<List<LocalSave.EquipOne>>[] sorts;

	private EquipType mEquipType;

	private int mSortType
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	public List<LocalSave.EquipOne> GetList()
	{
		return null;
	}

	public void OnLanguageChange()
	{
	}
}
