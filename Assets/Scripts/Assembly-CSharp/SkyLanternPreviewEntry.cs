using System.Collections.Generic;
using UnityEngine;

public class SkyLanternPreviewEntry : ViewCell
{
	public DxxText nameText;

	public RectTransform itemParent;

	public SkyLanternPreviewItem copyOne;

	private List<SkyLanternPreviewItem> items;

	private SkyLanternPreviewEntryData itemData;

	protected override void OnRefresh()
	{
	}

	private void RefreshUI()
	{
	}
}
