using System.Collections.Generic;
using UnityEngine;

public class IdentfyPlanCtl : MonoBehaviour
{
	public IdentfyStoneItemCtl stoneItemCtl;

	public const int itemCount = 2;

	private bool inited;

	public List<IdentfyStoneItemCtl> itemList { get; private set; }

	public void Init()
	{
	}

	public void OnLanguageChange()
	{
	}

	public void OnOpen()
	{
	}

	public void OnClose()
	{
	}
}
