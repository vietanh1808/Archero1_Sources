using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Spine.Unity;
using TableTool;
using UnityEngine;
using UnityEngine.UI;

public class MonopolyAchievementPart : MonoBehaviour
{
	public class RewardShowItem
	{
		public bool isUsing;

		public GameObject obj;

		public Image rewardIcon;

		public DxxText rewardNameTex;

		public RectTransform Image_BG;
	}

	[CompilerGenerated]
	private sealed class _003COnAddSorce_003Ed__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MonopolyAchievementPart _003C_003E4__this;

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
		public _003COnAddSorce_003Ed__26(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003COnGiftGet_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MonopolyAchievementPart _003C_003E4__this;

		public List<Drop_DropModel.DropData> list;

		public bool isLast;

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
		public _003COnGiftGet_003Ed__24(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003COnReduceHp_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MonopolyAchievementPart _003C_003E4__this;

		public int arg;

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
		public _003COnReduceHp_003Ed__27(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003COnRequsetReward_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MonopolyAchRewardItemData data;

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
		public _003COnRequsetReward_003Ed__22(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003COnTriggerNianBeast_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MonopolySaveData data;

		public MonopolyAchievementPart _003C_003E4__this;

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
		public _003COnTriggerNianBeast_003Ed__23(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003COnTriggerReward_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MonopolySaveData data;

		public MonopolyAchievementPart _003C_003E4__this;

		private int _003Ci_003E5__2;

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
		public _003COnTriggerReward_003Ed__30(int _003C_003E1__state)
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

	private string[] sliderName;

	public Slider bloodSlider;

	public MonopolyAchRewardItem monopolyAchRewardItem;

	public ButtonCtrl tipsBtn;

	public Image sliderAni;

	public Image sliderImg;

	public GameObject receiveEffect;

	public GameObject chestObj;

	public GameObject nianObj;

	public GameObject rewardObj;

	public GameObject boom;

	public SkeletonGraphic chest;

	public SkeletonGraphic nianBeast;

	public GameObject[] bianpaoObjs;

	public DxxText nianBeastHp;

	public CanvasGroup nianBeastHpCanvans;

	private List<RewardShowItem> rewardShowItems;

	private float sliderDuration;

	public void Init()
	{
	}

	public void Open()
	{
	}

	private void Refresh(bool isAftenGet = false)
	{
	}

	private void RegistEvent()
	{
	}

	[IteratorStateMachine(typeof(_003COnRequsetReward_003Ed__22))]
	private IEnumerator OnRequsetReward(MonopolyAchRewardItemData data)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003COnTriggerNianBeast_003Ed__23))]
	private IEnumerator OnTriggerNianBeast(MonopolySaveData data)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003COnGiftGet_003Ed__24))]
	private IEnumerator OnGiftGet(List<Drop_DropModel.DropData> list, bool isLast)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003COnAddSorce_003Ed__26))]
	private IEnumerator OnAddSorce(int arg)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003COnReduceHp_003Ed__27))]
	private IEnumerator OnReduceHp(int arg)
	{
		return null;
	}

	private void UnRegistEvent()
	{
	}

	public void Close()
	{
	}

	[IteratorStateMachine(typeof(_003COnTriggerReward_003Ed__30))]
	private IEnumerator OnTriggerReward(MonopolySaveData data)
	{
		return null;
	}

	private void ShowRewardItem(Drop_DropModel.DropData dropData)
	{
	}

	public RewardShowItem GetRewardShowItem()
	{
		return null;
	}
}
