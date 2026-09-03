using System;
using UnityEngine;
using UnityEngine.UI;

public class RedShopTab : MonoBehaviour
{
	public Text nameText1;

	public Text nameText2;

	public GameObject focusObj;

	public GameObject nodeCtrl;

	private Action<int> clickDo;

	private int CurTag;

	private bool isFocus;

	public void Init(int tag, Action<int> callback)
	{
	}

	public void OnLanguageChange()
	{
	}

	public void RefrshRedNode()
	{
	}

	public void SetFocus(bool isFocus)
	{
	}

	public void Click()
	{
	}
}
