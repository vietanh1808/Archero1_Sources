using System.Collections.Generic;
using UnityEngine;

public class SailingTurnPreviewRewardPart : MonoBehaviour
{
	public DxxText bigTitleTex;

	public DxxText smallTitleTex;

	public RectTransform contentTrans;

	public RectTransform bigOutBgTrans;

	public RectTransform bigInBgTrans;

	public RectTransform smallOutBgTrans;

	public RectTransform smallInBgTrans;

	public SailingTurnPreviewRewardItem copyOne;

	private List<SailingTurnPreviewRewardItem> dropItems;

	public void Open(int index)
	{
	}

	public void OnLanguageChange()
	{
	}

	public void Close()
	{
	}
}
