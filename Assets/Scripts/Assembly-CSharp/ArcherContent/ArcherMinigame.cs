using System;
using Habby.ContentBox;

namespace ArcherContent
{
	public class ArcherMinigame : ContentMinigameBase
	{
		public delegate bool ChangeSoundDelegate();

		public delegate bool GetSoundDelegate();

		public Action<string, bool, int> OnGameEnd;

		public ChangeSoundDelegate OnChangeSound;

		public Action<bool> OnSetSound;

		public GetSoundDelegate OnGetSound;

		public Action<int> OnPlaySound;

		protected override string _ilrName => null;

		public void OnLanguageChange(string lang)
		{
		}

		public void OnAndroidEscape()
		{
		}

		public void GameEnd(bool win, int score)
		{
		}

		public bool ChangeSound()
		{
			return false;
		}

		public void SetSound(bool sound)
		{
		}

		public bool GetSound()
		{
			return false;
		}

		public void PlaySound(int id)
		{
		}
	}
}
