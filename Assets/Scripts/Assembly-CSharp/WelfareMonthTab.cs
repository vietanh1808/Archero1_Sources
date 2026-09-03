using System;
using UnityEngine;
using UnityEngine.UI;

public class WelfareMonthTab : MonoBehaviour
{
	public Text nameText1;

	public Text nameText2;

	public GameObject focusObj;

	public GameObject lockObj;

	public GameObject nodeCtrl;

	private Action<int> clickDo;

	private int CurTag;

	private bool isFocus;

	private bool isLock;

	private bool isExpired;

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

	public void RefreshLockState()
	{
	}

	public void Click()
	{
	}
}
