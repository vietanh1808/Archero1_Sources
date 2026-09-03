using UnityEngine;
using XLua;

namespace Activity.Anniversary
{
	public class IntroPanel : PanelBase
	{
		[SerializeField]
		private RectTransform rtMangaContainer;

		[SerializeField]
		private CanvasGroup[] canvasGroups;

		[SerializeField]
		private RectTransform[] rts;

		[SerializeField]
		private ButtonCtrl btnClose;

		[SerializeField]
		private DxxText txtClose;

		private int step;

		private static DelegateBridge __Hotfix0_Awake;

		private static DelegateBridge __Hotfix0_OnBtnClick;

		private static DelegateBridge __Hotfix0_Open;

		private static DelegateBridge __Hotfix0_Play;

		private static DelegateBridge __Hotfix0_CheckNext;

		private static DelegateBridge __Hotfix0_Close;

		private static DelegateBridge __Hotfix0_Reset;

		private static DelegateBridge _c__Hotfix0_ctor;

		private void Awake()
		{
		}

		private void OnBtnClick()
		{
		}

		public override void Open()
		{
		}

		private void Play()
		{
		}

		private void CheckNext()
		{
		}

		public override void Close()
		{
		}

		private void Reset()
		{
		}

		private void _003C_003ExLuaBaseProxy_Open()
		{
		}

		private void _003C_003ExLuaBaseProxy_Close()
		{
		}
	}
}
