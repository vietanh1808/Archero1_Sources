using System;
using System.Collections.Generic;
using UnityEngine;

namespace Dxx
{
	public class UnityObjectPool<T> where T : UnityEngine.Object
	{
		protected Stack<T> m_Stack;

		protected Func<T> m_actionCreate;

		protected Action<T> m_ActionOnGet;

		protected Action<T> m_ActionOnRelease;

		private T origin;

		public int countAll { get; private set; }

		public int countActive => 0;

		public int countInactive => 0;

		public UnityObjectPool(Func<T> actionCreate, Action<T> actionOnGet, Action<T> actionOnRelease)
		{
		}

		public T Get()
		{
			return null;
		}

		public void Release(T element)
		{
		}
	}
}
