using System;
using UnityEngine;
using UnityEngine.UI;

public class ArtifactAppraisaAutoPanel : MonoBehaviour
{
	public DxxText titleTex;

	public DxxText targetText;

	public DxxText gear3Text;

	public DxxText gear4Text;

	public DxxText gear5Text;

	public DxxText stopText;

	public DxxText onceText;

	public DxxText loopText;

	public DxxText descText;

	public DxxText okBtnText;

	public ButtonCtrl closeBtn;

	public ButtonCtrl okBtn;

	public GameObject gear3SelectObj;

	public GameObject gear4SelectObj;

	public GameObject gear5SelectObj;

	public GameObject onceSelectObj;

	public GameObject LoopSelectObj;

	public Button gear3SelectBtn;

	public Button gear4SelectBtn;

	public Button gear5SelectBtn;

	public Button onceSelectBtn;

	public Button LoopSelectBtn;

	private int gear;

	private bool isLoop;

	public Action<int, bool> onClickDo;

	public void Init(Action<int, bool> clickCallBack)
	{
	}

	public void Open()
	{
	}

	public void Close()
	{
	}

	private void ClickOk()
	{
	}

	private void RefreshSate()
	{
	}

	private void ClickGear3()
	{
	}

	private void ClickGear4()
	{
	}

	private void ClickGear5()
	{
	}

	private void ClickOnce()
	{
	}

	private void ClickLoop()
	{
	}

	public void OnLanguageChange()
	{
	}
}
