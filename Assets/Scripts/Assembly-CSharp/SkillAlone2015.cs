using System.Collections.Generic;
using Dxx.Util;

public class SkillAlone2015 : SkillAloneBase
{
	private float meteorAtkInterval;

	private List<int> triggerWeights;

	private List<float> atkPercents;

	private float addSwordRate;

	private WeightRandom mWeightRandom;

	private SequencePool mSeqPool;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	protected override void OnRecvCustomJsonActionInternal(CustomJsonDataCommand cmd, CustomJsonActionVO vo)
	{
	}

	private void onRecoverByHPDrop()
	{
	}

	private void tryMeteorAtk(int count)
	{
	}
}
