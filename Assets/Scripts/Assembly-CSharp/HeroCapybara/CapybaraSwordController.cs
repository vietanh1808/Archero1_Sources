using System;
using System.Collections.Generic;

namespace HeroCapybara
{
	public class CapybaraSwordController
	{
		public string LogTag;

		private Stack<CapybaraSword> m_stack;

		public Action OnSwordChanged;

		public Stack<CapybaraSword> Stack => null;

		public void Init()
		{
		}

		public void DeInit()
		{
		}

		public void PushCapybaraSword(CapybaraSword sword)
		{
		}

		public CapybaraSword PopCapybaraSword()
		{
			return null;
		}

		public CapybaraSword PeekCapybaraSword()
		{
			return null;
		}

		public void PopAllCapybaraSword()
		{
		}

		public int GetCapybaraSwordCount()
		{
			return 0;
		}
	}
}
