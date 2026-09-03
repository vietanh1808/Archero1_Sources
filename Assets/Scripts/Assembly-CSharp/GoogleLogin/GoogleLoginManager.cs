using System;
using UnityEngine;

namespace GoogleLogin
{
	public class GoogleLoginManager : MonoBehaviour
	{
		public class LoginResult
		{
			public int code;

			public string userid;

			public string username;
		}

		private const string Tag = "GoogleLoginManager";

		private Action<int, string, string> _callback;

		private static GoogleLoginManager _instance;

		private AndroidJavaClass jc;

		private AndroidJavaObject act;

		private AndroidJavaObject bridge;

		public void Login(Action<int, string, string> callback)
		{
		}

		public void OnLoginResult(string result)
		{
		}

		private void Call(string methodName, params object[] args)
		{
		}

		public static GoogleLoginManager Instance()
		{
			return null;
		}
	}
}
