using System.Collections.Generic;
using Dxx.Util;
using UnityEngine;

public class AI5041 : AIBase
{
	private WeightRandomCount mWeightRandom;

	private SequencePool mSeqPool;

	private float yellow_prev_scale;

	private float yellow_delay;

	private int blue_index;

	private float blue_startangle;

	private int red_count;

	private GameObject effect_color;

	private const int effect_blueid = 3100029;

	private const int effect_redid = 3100025;

	private Dictionary<int, string> meffects;

	private ThunderContinueMgr.ThunderContinueReceive receive;

	private Entity3097BaseCtrl mBaseCtrl;

	private int yellow_count => 0;

	protected override void OnInitOnce()
	{
	}

	private void change_color(int effectid)
	{
	}

	protected override void OnInit()
	{
	}

	private void deinit_receive()
	{
	}

	protected override void OnAIDeInit()
	{
	}

	private bool Conditions()
	{
		return false;
	}
}
