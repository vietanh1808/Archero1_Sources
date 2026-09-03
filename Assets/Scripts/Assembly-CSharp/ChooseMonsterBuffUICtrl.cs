using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class ChooseMonsterBuffUICtrl : MediatorCtrlBase
{
	[CompilerGenerated]
	private sealed class _003CShowTips_003Ed__39 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ChooseMonsterBuffUICtrl _003C_003E4__this;

		public Vector3 pos;

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
		public _003CShowTips_003Ed__39(int _003C_003E1__state)
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

	[SerializeField]
	private GameObject cantclickObj;

	[SerializeField]
	private DxxText m_textTitle;

	[SerializeField]
	private DxxText m_textContent;

	[SerializeField]
	private DxxText m_textBuffContent;

	[SerializeField]
	private DxxText m_textTips;

	[SerializeField]
	private ButtonCtrl m_btnClose;

	[SerializeField]
	private ButtonCtrl m_btnChange;

	[SerializeField]
	private Text m_textChangeText;

	[SerializeField]
	private Text m_textRemainTimes;

	[SerializeField]
	private DxxText m_textPrice;

	[SerializeField]
	private RectTransform m_tips;

	[SerializeField]
	private RectTransform m_tipsContent;

	[SerializeField]
	private RectTransform m_imgArrow;

	[SerializeField]
	private DxxText m_textTipsLine1Pre;

	[SerializeField]
	private DxxText m_textTipsLine1;

	[SerializeField]
	private DxxText m_textTipsLine2Pre;

	[SerializeField]
	private DxxText m_textTipsLine2;

	[SerializeField]
	private Animator Ani_bg;

	[SerializeField]
	private Animator Ani_skill;

	[SerializeField]
	private Animator Ani_level;

	[SerializeField]
	private Animator Ani_content;

	[SerializeField]
	private List<ButtonCtrl> skillbutton;

	[SerializeField]
	private List<ChooseSkillButtonCtrl> chooseskillbutton;

	[SerializeField]
	private ChooseMonsterBuffOneCtrl[] chooseones;

	[SerializeField]
	private List<ChooseSkillColumnCtrl> columns;

	[SerializeField]
	private List<DxxText> skillnameList;

	[SerializeField]
	private GameObject[] stoneContainers;

	[SerializeField]
	private DxxText[] buffEffects;

	[SerializeField]
	private ButtonCtrl maskBtn;

	[SerializeField]
	private DxxText maskTip;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose()
	{
	}

	private void EnableAnim(bool enable)
	{
	}

	protected void RefreshUI(List<int> skilllist)
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	private void OnSkillActionEnd()
	{
	}

	public override void OnLanguageChange()
	{
	}

	private void UpdateTipsContent(bool show, int id, Vector3 pos)
	{
	}

	[IteratorStateMachine(typeof(_003CShowTips_003Ed__39))]
	private IEnumerator ShowTips(Vector3 pos)
	{
		return null;
	}

	private void ClickMaskBtn()
	{
	}
}
