using PureMVC.Interfaces;
using UnityEngine.UI;

public class RuneInfoUICtrl : MediatorCtrlBase
{
	public static readonly float RuneBlockHeight;

	public UILineCtrl TitleLine;

	public Text DescContent1;

	public Text DescContent2;

	public RuneBlockCtrl RuneBlockCopy;

	public ButtonCtrl ButtonClose;

	public RuneTabCtrl RuneTab;

	public RuneTotalBlockCtrl RuneTotalBlock;

	public RuneDexBlockCtrl RuneDexBlock;

	public GridLayoutGroup BlockRoot;

	public bool IfAutoLayout;

	public ScrollRect ScrollView;

	private float totalHeight;

	private int currentRuneIndex;

	private RuneGroup currentRuneGroup;

	protected override void OnInit()
	{
	}

	protected override void OnOpen()
	{
	}

	private void android_escape()
	{
	}

	protected override void OnClose()
	{
	}

	public override void OnLanguageChange()
	{
	}

	public void OnSwitchTab(int index, RuneGroup data)
	{
	}

	public override void OnHandleNotification(INotification notification)
	{
	}
}
