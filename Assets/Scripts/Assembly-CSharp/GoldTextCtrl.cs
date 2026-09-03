using Dxx.UI;
using UnityEngine;
using UnityEngine.UI;

public class GoldTextCtrl : MonoBehaviour
{
	private bool _iconfront;

	private float _interval;

	private DxxText text;

	private Color textColor;

	private Color redColor;

	private RectTransform imageRect;

	private Image image;

	private TextColor3Dxx text3;

	private Color topColor;

	private Color bottomColor;

	private float allwidth;

	private int needGold;

	private int gold;

	private CurrencyType type;

	private int equipId;

	private bool useTextRed;

	private bool bInit;

	public bool bIconFront
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public float Interval
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	private void init()
	{
	}

	public void SetAdd(int value)
	{
	}

	public void SetReduce(int value)
	{
	}

	public void SetValue(int value)
	{
	}

	public void SetNeedValue(int value)
	{
	}

	public void SetValue(float value)
	{
	}

	public void SetValue(string value)
	{
	}

	private void SetValueInternal(string value, string before)
	{
	}

	public void SetCurrencyType(int type)
	{
	}

	public void SetCurrencyType(CurrencyType type)
	{
	}

	public void SetEquipType(int equipId)
	{
	}

	public void UseTextRed()
	{
	}

	public void SetButtonEnable(bool value)
	{
	}

	public void SetTextRed(bool red)
	{
	}

	private void UpdateTextRed()
	{
	}

	public float GetWidth()
	{
		return 0f;
	}
}
