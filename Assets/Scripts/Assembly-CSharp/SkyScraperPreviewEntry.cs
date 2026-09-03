using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkyScraperPreviewEntry : ViewCell
{
	public Image sockImg;

	public DxxText nameText;

	public RectTransform itemParent;

	public SkyScraperPreviewItem copyOne;

	private List<SkyScraperPreviewItem> items;

	private SkyScraperPreviewData itemData;

	protected override void OnRefresh()
	{
	}

	private void RefreshUI()
	{
	}
}
