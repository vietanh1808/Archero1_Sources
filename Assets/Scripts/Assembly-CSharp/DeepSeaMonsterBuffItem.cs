using System;
using UnityEngine;
using UnityEngine.UI;

public class DeepSeaMonsterBuffItem : MonoBehaviour
{
	public Image buffIcon;

	public ButtonCtrl clickBtn;

	public DxxText activeText;

	private Action clickCallBack;

	public void Init(DeepSeaMonsterManager.BuffData buffData, Action callBack)
	{
	}

	private void Click()
	{
	}
}
