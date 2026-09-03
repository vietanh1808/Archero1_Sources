using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class GemsUICtrl : MediatorCtrlBase
{
	[CompilerGenerated]
	private sealed class _003CaddGuiderListener_003Ed__52 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GemsUICtrl _003C_003E4__this;

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
		public _003CaddGuiderListener_003Ed__52(int _003C_003E1__state)
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

	public RectTransform WindowRTF;

	public GameObject[] TabFocus;

	public DxxText[] TabText;

	public GameObject[] Locker;

	private List<int> canClickTabList;

	public ScrollRect scrollRect;

	public RectTransform pageRect;

	public RectTransform iconRect;

	private List<GemPageBasic> Pages;

	private List<GemIconLocation> Icons;

	public PageView pageView;

	public ButtonCtrl Button_Close;

	public ButtonCtrl Button_Up;

	public ButtonCtrl Button_Left;

	public ButtonCtrl Button_Right;

	public DxxText Text_Combine;

	public GameObject Combine_RedPoint;

	public GameObject PageOne;

	public GameObject MaskPanel;

	public GameObject Info_Desc;

	public DxxText Text_InfoDesc;

	public RectTransform RTF_GemsContainer;

	public GameObject cpPageBasic;

	public GameObject cpIconOne;

	public GameObject cpEquipOne;

	public GameObject cpPageOne_Four;

	public GameObject cpPageOne_Three;

	public GameObject Mask_Four;

	public GameObject Mask_Three;

	private float oneWidth;

	private float oneHeight;

	public int currentPageIndex;

	private int currentTab;

	public ScrollRect bottomScrollRect;

	private bool isGuiderRunning;

	private int TempChangeGemId;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose()
	{
	}

	public override object OnGetEvent(string eventName)
	{
		return null;
	}

	public override void OnHandleNotification(INotification notification)
	{
	}

	public override void OnLanguageChange()
	{
	}

	public void android_escape()
	{
	}

	public void OnButtonTab(int tab)
	{
	}

	public void onPageChanged(int index)
	{
	}

	public void onButtonIcon(int index)
	{
	}

	public void GotoPage(int index)
	{
	}

	private void addPageBasic(int index, int location)
	{
	}

	private void addPage(int index, int location)
	{
	}

	private void freshPageBasic(int index)
	{
	}

	private void addIcon(int index, int location)
	{
	}

	private void showTabGems(int type)
	{
	}

	public void onClickItemGem(object o)
	{
	}

	[IteratorStateMachine(typeof(_003CaddGuiderListener_003Ed__52))]
	private IEnumerator addGuiderListener()
	{
		return null;
	}

	private void setGuiderLister(Vector2 v2)
	{
	}

	private void putToLocation(int index, int gemid)
	{
	}

	private void RemoveToLocation(int index, int pos)
	{
	}

	private void changeToLocation(int index, int pos, int gemid)
	{
	}

	private void calcuteTabShow()
	{
	}

	public void showMaskPanel()
	{
	}

	public void hideMaskPanel()
	{
	}

	public void onClickChangeGem(int pos)
	{
	}

	public void onButtonMaskPanelOther()
	{
	}

	public void showInfoDesc(GemDescPopData data)
	{
	}

	public void onButtonClickInfoDesc()
	{
	}

	public void updateRedPoint()
	{
	}

	public void updateCombineRedPoint()
	{
	}
}
