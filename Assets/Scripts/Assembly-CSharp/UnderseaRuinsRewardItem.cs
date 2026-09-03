using System;
using TableTool;
using UnityEngine;
using UnityEngine.UI;

public class UnderseaRuinsRewardItem : MonoBehaviour
{
	public Image propIcon;

	public DxxText numTex;

	public ButtonCtrl clickBtn;

	public GameObject selectLight;

	public ParticleSystem effect_Normal;

	public ParticleSystem effect_BigReward;

	private bool mIsBig;

	public void Init(Drop_DropModel.DropData dropData, bool isBig, Action clickDo)
	{
	}

	public void SetSelect(bool isSelect)
	{
	}

	public void PlayReward()
	{
	}

	public void Close()
	{
	}
}
