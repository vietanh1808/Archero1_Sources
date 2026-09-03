using DG.Tweening;
using PureMVC.Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class PauseUIBaseCtrl : MediatorCtrlBase
{
	public ButtonCtrl Button_Sound;

	public ButtonCtrl Button_Continue;

	public ButtonCtrl Button_Home;

	public ButtonCtrl Button_Music;

	public ButtonCtrl Button_Hell_Environment;

	public Image SoundIcon;

	[SerializeField]
	private Image _imgHellEnvOff;

	public ScrollRect mScrollRect;

	public RectTransform mScrollContent;

	public DxxText Text_Title;

	public UILineCtrl mLineCtrl;

	public ButtonCtrl Button_SettingDebug;

	public Image MusicIcon;

	private Sequence seq;

	private GameObject copyitem;

	private LocalUnityObjctPool mPool;

	private bool isPause;

	private bool m_bPlayMusic;

	protected bool PlayMusic
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	protected override void OnInit()
	{
	}

	protected virtual void OnHome()
	{
	}

	private void InitSkills()
	{
	}

	protected override void OnOpen()
	{
	}

	private void InitUI()
	{
	}

	private void android_escape()
	{
	}

	private void UpdateSound()
	{
	}

	private void KillSequence()
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
}
