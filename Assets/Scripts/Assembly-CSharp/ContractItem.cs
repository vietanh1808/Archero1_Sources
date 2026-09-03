using System;
using TableTool;
using UnityEngine;
using UnityEngine.UI;

public class ContractItem : ButtonCtrl
{
	[SerializeField]
	private Image m_imgSelected;

	[SerializeField]
	private Image m_imgIcon;

	[SerializeField]
	private DxxText m_textLv;

	private bool m_bSelected;

	public Daily_HeroDefenceChallenge Data { get; private set; }

	public void Init(Daily_HeroDefenceChallenge data, Action<ContractItem> OnClickAction)
	{
	}

	public void UpdateState(bool bSelected)
	{
	}
}
