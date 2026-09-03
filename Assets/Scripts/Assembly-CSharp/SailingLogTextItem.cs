using UIKit;
using UnityEngine;
using UnityEngine.UI;

public class SailingLogTextItem : UITableViewCell
{
	[SerializeField]
	private Text contentText;

	[SerializeField]
	private Image bgImage;

	private SailingManager.SailingLogItemData selfData;

	public void Init(SailingManager.SailingLogItemData data)
	{
	}

	public static string GetTextByData(SailingManager.SailingLogItemData data)
	{
		return null;
	}
}
