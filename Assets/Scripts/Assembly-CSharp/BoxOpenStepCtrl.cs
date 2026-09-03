using System.Collections.Generic;
using Dxx.Util;
using TableTool;
using UnityEngine;
using UnityEngine.UI;

public class BoxOpenStepCtrl : MonoBehaviour
{
	public enum Step
	{
		eStart = 0,
		eBoxFly = 1,
		eRotate = 2,
		eLight = 3,
		eEnd = 4
	}

	public BoxOpenEquipCtrl mEquipCtrl;

	public Image Image_Light;

	public RectTransform startnode;

	public RectTransform endnode;

	public GameObject effect_lightparent;

	public Animation ani_equip;

	public GameObject effect_out;

	public GameObject effect_out_purple;

	public GameObject effect_out_gold;

	public GameObject effect_out_red;

	private Step mStep;

	private SequencePool mSeqPool;

	private Dictionary<int, UISortOrder> effect_lights;

	public void SetEquip(Drop_DropModel.DropData data)
	{
	}

	public void SetStep(Step step)
	{
	}

	private void show_effect_light(bool value)
	{
	}

	private void show_effect_out(bool value)
	{
	}

	public void DeInit()
	{
	}

	public void RoteToFinal(Drop_DropModel.DropData data)
	{
	}
}
