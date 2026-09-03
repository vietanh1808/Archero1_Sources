using UnityEngine;

public class GemCombineKeyAll : MonoBehaviour
{
	public ButtonCtrl Button_Close;

	public ButtonCtrl Button_Sure;

	public DxxText Text_Coin;

	public DxxText Text_Title;

	public DxxText[] Text_Line;

	public GameObject[] ChoosedFlag;

	public GameObject P1;

	public DxxText Text_KeyAll;

	[HideInInspector]
	public int[] choosed;

	private GemCombineCtrl combineCtrl;

	public void Awake()
	{
	}

	public void init(GemCombineCtrl ui)
	{
	}

	public void onButtonChoose(int index)
	{
	}

	public void onButtonClose()
	{
	}

	public void onButtonSure()
	{
	}

	private void freshButtonState()
	{
	}
}
