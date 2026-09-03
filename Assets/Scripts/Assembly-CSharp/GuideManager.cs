using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GuideManager
{
	public class GuideData
	{
		public int index;

		public Graphic t;

		public int order;

		public override string ToString()
		{
			return null;
		}
	}

	public class GuideCard : GuideUIBase
	{
		protected override void OnInit()
		{
		}

		protected override bool GetCanStartGuide()
		{
			return false;
		}
	}

	public abstract class GuideUIBase
	{
		public ulong serveruserid;

		public int process;

		protected int guidecount;

		protected Dictionary<int, GuideData> mGuideList;

		protected int mGuideIndex;

		protected bool bUserChanged;

		protected Action mGuideUpdate;

		protected GuideNoMaskCtrl _GuideOneCtrl;

		protected GuideNoMaskCtrl mGuideOneCtrl => null;

		private void CheckBug()
		{
		}

		public void Init(ulong serveruserid)
		{
		}

		protected virtual void OnInit()
		{
		}

		public void StartGuide()
		{
		}

		protected abstract bool GetCanStartGuide();

		public virtual bool CheckGuide()
		{
			return false;
		}

		public virtual void CurrentOver(int index)
		{
		}

		protected virtual void OnGuideEnd()
		{
		}

		public bool IsGuideOver()
		{
			return false;
		}

		public bool IsGuiding()
		{
			return false;
		}

		public void GoNext(int index, Graphic t)
		{
		}

		public void GoNext(GuideData data)
		{
		}

		private void show_guide(bool value)
		{
		}

		public void DeInit()
		{
		}

		protected virtual void OnDeInit()
		{
		}
	}

	public class GuideEquip : GuideUIBase
	{
		protected override void OnInit()
		{
		}

		protected override bool GetCanStartGuide()
		{
			return false;
		}

		public override bool CheckGuide()
		{
			return false;
		}
	}

	private GameObject currentobj;

	private bool bBattleNeedGuide;

	private List<int> learnedSkills;

	private readonly string[] noobSkillSet;

	public GuideCard mCard { get; private set; }

	public GuideEquip mEquip { get; private set; }

	public void Init()
	{
	}

	public void DeInit()
	{
	}

	public bool GetNeedGuide()
	{
		return false;
	}

	public void GuideBattleNext()
	{
	}

	private void RemoveLastGuide()
	{
	}

	public bool GetFlowerAttack()
	{
		return false;
	}

	public bool GetGuideMove()
	{
		return false;
	}

	public GameObject GetGuideObj(int index)
	{
		return null;
	}

	public void Clear()
	{
	}

	public void InitNoobSkills()
	{
	}

	public void RemoveSkill(int skillId)
	{
	}

	public List<int> GetSkill9(int times)
	{
		return null;
	}

	private void Card_Init()
	{
	}

	public void Card_DeInit()
	{
	}

	private void Equip_Init()
	{
	}

	public void Equip_DeInit()
	{
	}
}
