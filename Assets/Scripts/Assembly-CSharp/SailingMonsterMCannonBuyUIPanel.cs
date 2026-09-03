using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class SailingMonsterMCannonBuyUIPanel : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CCountDown_003Ed__45 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SailingMonsterMCannonBuyUIPanel _003C_003E4__this;

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
		public _003CCountDown_003Ed__45(int _003C_003E1__state)
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
	private DxxText title;

	[SerializeField]
	private DxxText countDown;

	[SerializeField]
	private DxxText priceOne;

	[SerializeField]
	private DxxText leftCount;

	[SerializeField]
	private DxxText txtDesc;

	[SerializeField]
	private ButtonCtrl buyBtn;

	[SerializeField]
	private ButtonCtrl btnAdd;

	[SerializeField]
	private ButtonCtrl btnReduce;

	[SerializeField]
	private ButtonCtrl close;

	[SerializeField]
	private PropOneEquip prop;

	[SerializeField]
	private Slider sliderBuy;

	[SerializeField]
	private DxxText txtCount;

	private long CurLeftTime;

	private Coroutine coroutineCountDown;

	private WaitForSeconds wait;

	private SailingMCannonType type;

	private int selectCount;

	private SailingMonsterCommingMgr SmMgr => null;

	private CurrencyType CurCurrencyType => CurrencyType.None;

	private float BuyOnePrice => 0f;

	private int CurLeftBuyCount => 0;

	private float PriceOne => 0f;

	private float PriceMore => 0f;

	private int HaveBuyCount => 0;

	public void Init()
	{
	}

	public void Open(SailingMCannonType type)
	{
	}

	public void Close()
	{
	}

	public void OnLanguageChange()
	{
	}

	public void Refresh()
	{
	}

	public void RefreshSlider()
	{
	}

	private void onButtonAdd()
	{
	}

	private void onButtonReduce()
	{
	}

	public void OnSliderValueChanged()
	{
	}

	public void RefreshItem()
	{
	}

	public void RefreshStatus()
	{
	}

	public void RefreshText()
	{
	}

	public void BuyArrow()
	{
	}

	public void InfoClick()
	{
	}

	[IteratorStateMachine(typeof(_003CCountDown_003Ed__45))]
	private IEnumerator CountDown()
	{
		return null;
	}

	public void RefreshTime()
	{
	}

	public bool CheckSameDay()
	{
		return false;
	}

	public void ReStartCountDown()
	{
	}

	public void OneDisable()
	{
	}
}
