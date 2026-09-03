using System.Collections.Generic;
using UnityEngine;

public class HolyLightPreviewEntry : ViewCell
{
	public DxxText nameText;

	public RectTransform itemParent;

	public HolyLightPreviewItem copyOne;

	private List<HolyLightPreviewItem> items;

	private HolyLightPreviewEntryData itemData;

	protected override void OnRefresh()
	{
	}

	private void RefreshUI()
	{
	}
}
