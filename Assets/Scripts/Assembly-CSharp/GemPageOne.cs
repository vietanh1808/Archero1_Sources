using UnityEngine;

public class GemPageOne : MonoBehaviour
{
	public DxxText Text_Title;

	public DxxText Text_TotalLevel;

	public GemSlotOne[] slot;

	public GameObject[] lighting;

	public Material[] Mat_Line;

	public RectTransform effectRT;

	public DxxText Text_Prop1;

	public DxxText Text_Prop2;

	public RectTransform RTF_Attr;

	public RectTransform RTF_AttrBasic;

	public RectTransform RTF_AttrCenter;

	public RectTransform RTF_Property2;

	public GameObject cpAttrText;

	public GameObject cpAttrItem;

	public ButtonCtrl Button_Info1;

	public ButtonCtrl Button_Info2;

	public GameObject[] Effect_Ball;

	private int Location;

	public void init(int index, int location)
	{
	}

	public void freshUI()
	{
	}

	private void onButtonInfo1()
	{
	}

	private void onButtonInfo2()
	{
	}

	public void onButtonTopIcon(int index)
	{
	}

	public void changeState(int state)
	{
	}

	public void switchGemDownAni(int pos)
	{
	}

	public void addGemBallAni(int quality)
	{
	}

	public void hideEffectState()
	{
	}
}
