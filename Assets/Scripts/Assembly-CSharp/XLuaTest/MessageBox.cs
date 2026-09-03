using System;
using UnityEngine;

namespace XLuaTest
{
	public class MessageBox : MonoBehaviour
	{
		public static void ShowAlertBox(string message, string title, Action onFinished = null)
		{
		}

		public static void ShowConfirmBox(string message, string title, Action<bool> onFinished = null)
		{
		}
	}
}
