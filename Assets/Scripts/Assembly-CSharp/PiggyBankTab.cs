using System;
using UnityEngine;
using UnityEngine.UI;

public class PiggyBankTab : MonoBehaviour
{
	[SerializeField]
	private ButtonCtrl btn;

	[SerializeField]
	private Image img_tab;

	private PiggyBankItemData data;

	public void Init(int index, int imgType, Action<int> callback)
	{
	}
}
