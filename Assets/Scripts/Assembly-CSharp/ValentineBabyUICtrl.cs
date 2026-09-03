using System.Collections.Generic;
using UnityEngine;

public class ValentineBabyUICtrl : MediatorCtrlBase
{
	public Transform HeroContainer;

	public ButtonCtrl BtnAccept;

	public DxxText TextAccept;

	public DxxText TextTitle;

	public DxxText TextContent;

	public DxxText TextTips;

	private int m_nHeroId;

	private readonly Dictionary<int, int> skins;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void UpdateUI()
	{
	}

	public override void OnLanguageChange()
	{
	}

	protected override void OnClose()
	{
	}
}
