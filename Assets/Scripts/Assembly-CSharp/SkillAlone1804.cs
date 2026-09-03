using System.Collections.Generic;
using UnityEngine;

public class SkillAlone1804 : SkillAloneBase
{
	private class ComboEffectVO
	{
		public EntityBase m_Entity;

		public string ExternalTag;

		public int Index;

		public int ConditionValue;

		public int BuffId;

		public int EffectId;

		private GameObject _effect;

		public string PrintInfo()
		{
			return null;
		}

		public void SetEffectVisible(bool visible)
		{
		}

		public void Clear()
		{
		}
	}

	private const string UPDATE_NAME = "SkillAlone1804-UPDATE";

	private List<ComboEffectVO> comboEffectList;

	private float comboTime;

	private ComboEffectVO curComboEffectVO;

	private ConditionTime comboTimeCondition;

	private int comboCount;

	private bool hasNewCombo;

	protected override void OnInstall()
	{
	}

	protected override void OnUninstall()
	{
	}

	protected override void OnRecvCustomJsonActionInternal(CustomJsonDataCommand cmd, CustomJsonActionVO vo)
	{
	}

	private void onAttack()
	{
	}

	private void onUpdate(float obj)
	{
	}

	private void OnAttackPre()
	{
	}

	private ComboEffectVO getComboEffectVO(int _count)
	{
		return null;
	}

	private void parseComboEffectArgs(string arg, int index)
	{
	}

	private void makeAllInvisible()
	{
	}

	private void syncAllInvisible()
	{
	}

	private void syncCurComboVisible(int index)
	{
	}
}
