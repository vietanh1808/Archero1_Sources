using UnityEngine;
using UnityEngine.UI;

namespace Activity.WorldCup
{
	public class WorldCupChampBetItem : MonoBehaviour
	{
		[SerializeField]
		private GameObject goTagHot;

		[SerializeField]
		private GameObject goMyBet;

		[SerializeField]
		private DxxText txtName;

		[SerializeField]
		private DxxText txtValue;

		[SerializeField]
		private DxxText txtMyBetValue;

		[SerializeField]
		private Slider slider;

		[SerializeField]
		private ButtonCtrl btn;

		private BetMakingChampPanel panel;

		private uint id;

		private ChampionPage page;

		private void Awake()
		{
		}

		public void SetData(ChampionPage championPage, BetMakingChampPanel panel, uint id)
		{
		}

		private void Refresh()
		{
		}
	}
}
