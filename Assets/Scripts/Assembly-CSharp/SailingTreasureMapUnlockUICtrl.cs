using System;
using UnityEngine;
using UnityEngine.UI;

public class SailingTreasureMapUnlockUICtrl : MonoBehaviour
{
	[SerializeField]
	private Image _imgTarget;

	[SerializeField]
	private DxxText _textTitle;

	[SerializeField]
	private DxxText _textDesc;

	private int _id;

	private Action<int> _callback;

	public void Init(int id, Action<int> closeCallback)
	{
	}

	public void CloseUI()
	{
	}
}
