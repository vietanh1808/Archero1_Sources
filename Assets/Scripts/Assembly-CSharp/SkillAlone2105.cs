using System.Collections.Generic;
using UnityEngine;

public class SkillAlone2105 : SkillAloneWing
{
	public class Skill1Effect2105IgniteVO_IceExplode : CustomJsonActionVO
	{
		public Vector3 pos;
	}

	private float interval;

	private float duration;

	private float radius;

	private float reduceRate;

	private int effectId;

	private int IsSkill1Effect;

	private float durationAdd;

	private int IsSkill2Effect;

	private int bulletId;

	private float hitRate;

	private int IsSkill3Effect;

	private float radiusAdd;

	private int IsSkill4Effect;

	private string SyncSkill2105_IceExplode;

	private bool hasCallEnd;

	private float preEffectEndTime;

	private GameObject effect;

	private Dictionary<int, BulletBase> InFieldBulletsDict;

	protected override float WingEffectUp => 0f;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	private void BulletEnterSpeedReduceField(bool isEnter, BulletBase bullet)
	{
	}

	private void ResetEffectControl()
	{
	}

	private void OnUpdate(float delta)
	{
	}

	public BulletBase CreateIceExplode(int bulletId, Vector3 bulletPos, float atkPercent)
	{
		return null;
	}

	private void ReceiveCustomJsonAction(CustomJsonDataCommand cmd, CustomJsonActionVO data)
	{
	}

	private void SycnIceExplode(Vector3 bulletPos)
	{
	}
}
