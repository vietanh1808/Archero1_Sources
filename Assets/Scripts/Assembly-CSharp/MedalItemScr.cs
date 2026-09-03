using System;
using TableTool;
using UnityEngine;
using UnityEngine.UI;

public class MedalItemScr : MonoBehaviour
{
	public ButtonCtrl btnIcon;

	public ButtonCtrl clickBtn;

	public GameObject selectBg;

	public GameObject showCheck;

	public Image icomImg;

	public Action<MedalItemScr> OnClickCallBack;

	public RedNodeCtrl redNodeCtrl;

	[HideInInspector]
	public Achieve_Medal data;

	public GameObject CommonObj;

	public GameObject AniObj;

	private void Awake()
	{
	}

	public void Init(Achieve_Medal _data)
	{
	}

	private void onButtonClick()
	{
	}

	public void onCloseUI()
	{
	}
}
