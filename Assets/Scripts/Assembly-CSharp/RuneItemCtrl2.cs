using UnityEngine;
using UnityEngine.UI;

public class RuneItemCtrl2 : MonoBehaviour
{
	public static readonly string[] TextColor;

	public GameObject lockItem;

	public RectTransform levelItem;

	public Text DescText;

	public Text LockDescText;

	public Text LockLevelText;

	public Text Text_Rare;

	public Image Icon_Rare;

	public DxxText Text_Test;

	public int Index { get; private set; }

	public RuneItem Data { get; private set; }

	public bool ShowLock { get; private set; }

	public int UnlockLevel { get; private set; }

	public bool IfShowLimit { get; private set; }

	public void InitData(int index, RuneItem data, bool showLock, int unlockLevel)
	{
	}

	public void UdpateData(RuneItem data, bool showLock, int unlockLevel, bool ShowLimit = false)
	{
	}

	public void UpdateByData()
	{
	}

	public float GetHeight()
	{
		return 0f;
	}
}
