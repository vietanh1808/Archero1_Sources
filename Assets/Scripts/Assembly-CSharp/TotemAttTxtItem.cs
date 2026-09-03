using UnityEngine;

public class TotemAttTxtItem : MonoBehaviour
{
	[SerializeField]
	private DxxImage rareIcon;

	[SerializeField]
	private DxxFitContentText descTxt;

	private Color _lockedColor;

	private Color _mainAttColor;

	public void Init(TotemAtt attData, bool isShowRare = false, bool isMain = false)
	{
	}

	public void InitLock(int unlockLevel)
	{
	}
}
