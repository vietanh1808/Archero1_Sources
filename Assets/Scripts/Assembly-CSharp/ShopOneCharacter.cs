using UnityEngine;
using UnityEngine.UI;

public class ShopOneCharacter : ShopOneBase
{
	public class HeroSetting
	{
		public int charid;

		public Vector3 position;

		public Vector3 scale;
	}

	public int CharacterID;

	public DxxText content_one;

	public DxxText content_two;

	public DxxText button_text;

	public DxxText title;

	public ButtonCtrl button;

	public DxxImage Image_Icon;

	public Image charbg;

	public Image charImage;

	private LocalSave.CharacterOne mCharacter;

	private int[] idx;

	private int currentIdx;

	public override void OnLanguageChange()
	{
	}

	private void update_price()
	{
	}

	private void update_button_text()
	{
	}

	public override void UpdateNet()
	{
	}

	protected override void OnDeinit()
	{
	}

	protected override void OnInit()
	{
	}

	public void OnButtonTestHero()
	{
	}
}
