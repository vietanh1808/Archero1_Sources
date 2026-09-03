using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class DragonCombineKeyAll : MonoBehaviour
{
	public ButtonCtrl Button_Close;

	public ButtonCtrl Button_Sure;

	public DxxText Text_Sure;

	public DxxText Text_Title;

	public DxxText[] Text_Line;

	public GameObject[] ChoosedFlag;

	public GameObject[] ChooseObj;

	public int choosed;

	[CompilerGenerated]
	private Action<int> m_clickCofirmDo;

	public GameObject tipsGameObject;

	public DxxText Text_Tip;

	public ButtonCtrl tipsCloseBtn;

	public ButtonCtrl tipsBtn;

	private int[] qualitys;

	public event Action<int> clickCofirmDo
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public void Init()
	{
	}

	public void Open()
	{
	}

	private bool isChoosed(int index)
	{
		return false;
	}

	public void onButtonChoose(int index)
	{
	}

	public void Close()
	{
	}

	public void onButtonSure()
	{
	}

	private void freshButtonState()
	{
	}
}
