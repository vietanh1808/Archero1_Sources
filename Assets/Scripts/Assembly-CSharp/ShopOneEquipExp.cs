using System.Collections.Generic;
using UnityEngine;

public class ShopOneEquipExp : ShopOneBase
{
	public const float itemwidth = 235f;

	public DxxText Text_Title;

	public DxxText Text_Content;

	public GameObject goldparent;

	private List<ShopItemEquipExp> mList;

	private GameObject _itemgold;

	private LocalUnityObjctPool mPool;

	private string oncestring;

	private string timestring;

	private int lasttime;

	private float m_flasttime;

	private GameObject itemgold => null;

	protected override void OnAwake()
	{
	}

	protected override void OnInit()
	{
	}

	protected override void OnDeinit()
	{
	}

	private void Update()
	{
	}

	private void OnOpenWindowSure(int index, ShopItemEquipExp item)
	{
	}

	private void OnClickEquipExp(int index, ShopItemEquipExp item)
	{
	}

	public override void OnLanguageChange()
	{
	}

	public override void UpdateNet()
	{
	}
}
