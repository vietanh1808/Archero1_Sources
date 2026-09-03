using UnityEngine;

public class RedNodeCtrl : MonoBehaviour
{
	private Transform _child;

	private RedNodeOneCtrl _redctrl;

	private int _value;

	private string _text;

	private RedNodeType _type;

	private Transform child => null;

	private RedNodeOneCtrl mRedCtrl => null;

	public int Value
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	private void child_show(bool show)
	{
	}

	public void DestroyChild()
	{
	}

	private void SetText(string value)
	{
	}

	public void SetType(RedNodeType type)
	{
	}

	public void OnLanguageChange()
	{
	}

	private void OnDestroy()
	{
	}

	public bool isShow()
	{
		return false;
	}
}
