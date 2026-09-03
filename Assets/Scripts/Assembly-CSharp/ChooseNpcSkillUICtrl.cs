using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class ChooseNpcSkillUICtrl : ChooseSkillUICtrl
{
	private class SkillWeight
	{
		public int id;

		public int weight;

		public SkillWeight(string str)
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CRebuild_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ChooseNpcSkillUICtrl _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CRebuild_003Ed__30(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	public DxxText mSkillTitle;

	public DxxText mSkillRemain;

	public ScrollRect mScrollView;

	public SkillButtonCtrl CopyOne;

	public Transform mBottomBar;

	public BottomBarButton CopyOne2;

	public GameObject mSkillParent;

	public RectTransform mTopBar;

	public DxxText mTextHp;

	public DxxText mTextAttack;

	public Image mHeroImage;

	private LocalUnityObjctPool mCachePool;

	private LocalUnityObjctPool mCachePool2;

	private int m_nSelectId;

	private List<SkillWeight> m_listNpcSkills;

	private List<BottomBarButton> m_listBottmBtns;

	private Dictionary<int, EntityAttributeBase> m_dicPartBodies;

	private int m_nWeightAll;

	protected override bool IsShowJumpSkillBtn => false;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void GetTransfer()
	{
	}

	private void InitBottomBar()
	{
	}

	private void InitPartBodies()
	{
	}

	protected override List<int> GetSkillList()
	{
		return null;
	}

	private int RandomSkill()
	{
		return 0;
	}

	private void InitBabyNpcSlotinSkill()
	{
	}

	private void UpdateUI()
	{
	}

	[IteratorStateMachine(typeof(_003CRebuild_003Ed__30))]
	private IEnumerator Rebuild()
	{
		return null;
	}

	private void OnClickBottom(int id, BottomBarButton btn)
	{
	}

	private void EnableBottomBtns(bool enable)
	{
	}

	private bool CanLearnNewSkill()
	{
		return false;
	}

	public override void OnLanguageChange()
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	private void ExcuteSkillAttribute(int id, int[] skillids, EntityAttributeBase attribute = null)
	{
	}

	private void OnChooseSkill(int skillid)
	{
	}

	protected override void OnClose()
	{
	}
}
