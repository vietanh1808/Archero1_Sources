using UnityEngine;
using UnityEngine.UI;

public class Act5thHuntingGameResultAnimalItem : MonoBehaviour
{
	[SerializeField]
	private Image headIcon;

	[SerializeField]
	private Image headQualityIcon;

	[SerializeField]
	private GameObject kingIcon;

	private Act5thHuntingManager HuntingManager => null;

	private Act5thHuntingConfigData HuntingConfigData => null;

	public void Refresh(int id)
	{
	}
}
