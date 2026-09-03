using System.Collections.Generic;
using TableTool;
using UnityEngine;

public class FirstRewardOneCtrl : MonoBehaviour
{
	public DxxText Text_Title;

	public DxxText Text_Get;

	public DxxText Text_GotoPurchase;

	public ButtonCtrl ButtonGet;

	public GameObject itemone;

	public Transform itemparent;

	private LocalUnityObjctPool mPool;

	private bool bInit;

	public DxxText descText;

	public DxxText valuePrice;

	public DxxText valueTex;

	private List<Drop_DropModel.DropData> mDataList;

	public void Init()
	{
	}

	public void Refresh()
	{
	}

	public void OnLanguageChange()
	{
	}
}
