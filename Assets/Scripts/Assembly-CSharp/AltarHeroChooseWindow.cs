using System;
using UnityEngine;
using UnityEngine.UI;

public class AltarHeroChooseWindow : MonoBehaviour
{
	public DxxText Text_Title;

	public DxxText Text_Desc1;

	public DxxText Text_Desc2;

	public DxxText Text_Num;

	public Slider slider;

	public ButtonCtrl Button_OK;

	public ButtonCtrl Button_Close;

	public DxxText Text_OK;

	private Action<int, int> changeSliderCount;

	private int equipid;

	private int count;

	private int max;

	public void init(int equipid, int count, Action<int, int> callback)
	{
	}

	public void onSliderValueChanged(float f)
	{
	}

	public void onButtonAdd()
	{
	}

	public void onButtonReduce()
	{
	}

	private void onButtonClose()
	{
	}

	private void onButtonOK()
	{
	}

	public void SecondConfirmButtonOk()
	{
	}
}
