using System;
using System.Collections.Generic;
using UnityEngine;

public class SkillAlone1227Ctrl : SkillAloneGoodCtrlBase
{
	public Action<SkillAlone1227Ctrl> OnDeInitAction;

	[SerializeField]
	private Transform child;

	private float m_fBuffRange;

	private List<int> m_listDebuffIds;

	private float m_fTime;

	protected override void UpdateProcess()
	{
	}

	private void CreateThunder(EntityBase entity)
	{
	}

	private void syncThunderCommand(int _bulletId, Vector3 _pos, Vector3 _scale)
	{
	}

	protected override void OnInit()
	{
	}

	protected override void OnDeInit()
	{
	}
}
