using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace HabbyUtils.UI
{
	public class ButtonBase : Button
	{
		private string btnAudioName;

		private static Material _gray;

		public AudioClip clickSound;

		private Image[] images;

		private Text[] texts;

		private Color[] textsColor;

		public static Material GrayMaterial => null;

		protected override void Awake()
		{
		}

		public void SetClickAudio(string clipName)
		{
		}

		public void SetClickAudio(AudioClip clip)
		{
		}

		public sealed override void OnPointerDown(PointerEventData eventData)
		{
		}

		public sealed override void OnPointerUp(PointerEventData eventData)
		{
		}

		public sealed override void OnPointerClick(PointerEventData eventData)
		{
		}

		private void OnBtnClickDown()
		{
		}

		private void PlayAudio()
		{
		}

		protected virtual void OnBtnClick()
		{
		}

		protected virtual void OnPointerPress(bool pDown)
		{
		}

		public void SetGray(bool gray)
		{
		}

		private void SetImageMaterial(Material mat)
		{
		}

		private void SetTextsColor(bool disable)
		{
		}
	}
}
