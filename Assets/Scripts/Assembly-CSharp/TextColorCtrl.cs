using UnityEngine;

public class TextColorCtrl : MonoBehaviour
{
	private string mText;

	private int mFontSize;

	public Color topColor1;

	public Color topColor2;

	public Color topoutlineColor;

	public Color middleColor;

	public Color middleoutlineColor;

	public Color shadowColor;

	private DxxText _text_top;

	private DxxText _text_middle;

	private DxxText _text_shadow;

	public string text
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int FontSize
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	private DxxText text_top => null;

	private DxxText text_middle => null;

	private DxxText text_shadow => null;

	private void Awake()
	{
	}
}
