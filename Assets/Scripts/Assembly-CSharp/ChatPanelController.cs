using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.UI;

public class ChatPanelController : GuildPanelBase
{
	[CompilerGenerated]
	private sealed class _003CsetButtonState_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public int index;

		public ChatPanelController _003C_003E4__this;

		private Image _003Cicon_003E5__2;

		private ButtonCtrl _003Cbutton_003E5__3;

		private float _003Cstart_003E5__4;

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
		public _003CsetButtonState_003Ed__33(int _003C_003E1__state)
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

	public DxxText Text_Title;

	public ButtonCtrl Button_Assist;

	public ButtonCtrl Button_Gift;

	public ButtonCtrl Button_Smile;

	public ButtonCtrl Button_Text;

	public Image Icon_Smile;

	public Image Icon_Text;

	public DxxText Text_Assist;

	public DxxText Text_Gift;

	public DxxText Text_Smile;

	public DxxText Text_Text;

	public Text text_Chat;

	public Text text_Gift;

	public Text text_Achievement;

	public ChatTableView chatTableView;

	private float LimitSecond;

	private float[] input_progress;

	private float[] input_time;

	public ChatPanelSmile smilePanel;

	public ChatPanelText textPanel;

	public ChatPopWindow popWindow;

	public RedNodeCtrl helpRedNode;

	public RedNodeCtrl giftRedNode;

	public void Awake()
	{
	}

	private void onButtonAssist()
	{
	}

	public void onButtonGift()
	{
	}

	public void onButtonSmile()
	{
	}

	public void onButtonText()
	{
	}

	public override void onLanguageChanged()
	{
	}

	public override void OnInit()
	{
	}

	public override void showPanel()
	{
	}

	public override void hidePanel()
	{
	}

	public override void onNote(string key, object value)
	{
	}

	[IteratorStateMachine(typeof(_003CsetButtonState_003Ed__33))]
	private IEnumerator setButtonState(int index)
	{
		return null;
	}
}
