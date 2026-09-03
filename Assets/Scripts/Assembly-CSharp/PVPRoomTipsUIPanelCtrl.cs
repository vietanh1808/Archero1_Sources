using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class PVPRoomTipsUIPanelCtrl : MediatorCtrlBase
{
	[CompilerGenerated]
	private sealed class _003CWaitReBuild_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PVPRoomTipsUIPanelCtrl _003C_003E4__this;

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
		public _003CWaitReBuild_003Ed__30(int _003C_003E1__state)
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

	public ButtonCtrl Button_Shadow;

	public ButtonCtrl Button_Close;

	public Text Text_Title;

	[Header("面对面")]
	public ButtonCtrl Button_Join;

	public ButtonCtrl Button_Create;

	public Text Text_Join;

	public Text Text_Create;

	public Text f2fTitle;

	public Text Text_Content;

	public Text f2fCost;

	public Text f2fCostNum;

	[Header("体力匹配")]
	public ButtonCtrl Button_Viality;

	public Text vialityBtnNum;

	public Text vialityTitle;

	public Text vialityContext;

	public Text vialityCost;

	public Image vialityIcon;

	public Text vialityCostNum;

	[Header("buildlayer")]
	public RectTransform[] rebuildLayers;

	private PVPUIProxy.Transfer mTransfer;

	private CooperationData cooperatonData;

	private PVPDailDataSender dailData;

	protected override void OnInit()
	{
	}

	private void InitF2F()
	{
	}

	private void InitVitalityMatch()
	{
	}

	private void OnVialityBtnClick()
	{
	}

	private void android_escape()
	{
	}

	protected override void OnOpen()
	{
	}

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	[IteratorStateMachine(typeof(_003CWaitReBuild_003Ed__30))]
	private IEnumerator WaitReBuild()
	{
		return null;
	}

	protected override void OnClose()
	{
	}

	private void closeHandler()
	{
	}

	public override void OnLanguageChange()
	{
	}

	private void OnLanguageChangeF2F()
	{
	}

	private void OnLanguageChangeVailat()
	{
	}
}
