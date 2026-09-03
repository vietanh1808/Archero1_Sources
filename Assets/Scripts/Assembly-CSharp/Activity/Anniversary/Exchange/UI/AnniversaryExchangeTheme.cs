using Activity.Anniversary.Exchange.Data;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Activity.Anniversary.Exchange.UI
{
	public class AnniversaryExchangeTheme : MonoBehaviour
	{
		[SerializeField]
		private Image bg;

		[SerializeField]
		private Image subBg1;

		[SerializeField]
		private Image subBg2;

		[SerializeField]
		private Image bgLight;

		[SerializeField]
		private Image[] stars;

		[SerializeField]
		private Image sphereBg;

		[SerializeField]
		private AnniversaryExchangeWater water;

		private ExchangeThemeType type;

		private static DelegateBridge __Hotfix0_Refresh;

		private static DelegateBridge __Hotfix0_RefreshWaveColor;

		private static DelegateBridge __Hotfix0_RefreshImage;

		private static DelegateBridge _c__Hotfix0_ctor;

		public void Refresh(ExchangeThemeType type)
		{
		}

		private void RefreshWaveColor()
		{
		}

		private void RefreshImage()
		{
		}
	}
}
