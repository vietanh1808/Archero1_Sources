using System.Collections.Generic;
using UnityEngine;

public class ShopOneActive : ShopOneBase
{
	public DxxText Text_Title;

	public GameObject itemparent;

	private List<ShopItemActive> mList;

	private GameObject _item;

	private float startheight;

	private float oneheight;

	private LocalUnityObjctPool mPool;

	private GameObject item => null;

	protected override void OnAwake()
	{
	}

	protected override void OnInit()
	{
	}

	private void OnClickActive(string data, ShopItemActive item)
	{
	}

	public override void OnLanguageChange()
	{
	}

	public override void UpdateNet()
	{
	}

	protected override void OnDeinit()
	{
	}
}
