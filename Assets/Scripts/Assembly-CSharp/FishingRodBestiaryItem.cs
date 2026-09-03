using UIKit;
using UnityEngine;
using UnityEngine.UI;

public class FishingRodBestiaryItem : UITableViewCell
{
	[SerializeField]
	private Image rodBg;

	[SerializeField]
	private Image rodIcon;

	[SerializeField]
	private Image rodQualityBg;

	[SerializeField]
	private DxxText rodQuality;

	[SerializeField]
	private DxxText rodName;

	[SerializeField]
	private DxxText getSource;

	[SerializeField]
	private DxxText effectDesc;

	[SerializeField]
	private DxxText getStatus;

	private FishingRodBestiaryItemData data;

	public void Refresh(FishingRodBestiaryItemData data)
	{
	}

	private void RefreshText()
	{
	}

	private void RefreshStatus()
	{
	}

	private string GetEffectDesc()
	{
		return null;
	}
}
