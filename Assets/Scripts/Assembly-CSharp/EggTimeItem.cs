using System;
using UnityEngine;
using UnityEngine.UI;

public class EggTimeItem : MonoBehaviour
{
	public Image Image_BG;

	public DxxText Text_Title;

	public DxxText Text_Time;

	public DxxText Text_Num;

	public DxxText Text_Use;

	private LocalSave.EquipOne equipOne;

	private int pressTimes;

	private LocalSave.EggData eggData;

	public void init(LocalSave.EggData data, int equipid)
	{
	}

	public void freshItem()
	{
	}

	public void onButtonClick()
	{
	}

	public void onButtonLongPress()
	{
	}

	public void onButtonLongPressCancel()
	{
	}

	private void showNoCard()
	{
	}

	private void showCardOnlyOne(Action action, Action cancel)
	{
	}
}
