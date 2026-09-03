using System.Collections.Generic;

namespace GameInteraction
{
	public class Controller
	{
		private BaseInteraction interaction;

		private string tag;

		private int id;

		private bool touchEnabled;

		private Stack<BaseInteraction> stack;

		public BaseInteraction Interaction
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string Tag
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int Id
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool TouchEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public void forceTouchEnd()
		{
		}

		public void popInteraction()
		{
		}

		public void pushInteraction(NormalInteraction newInteraction)
		{
		}
	}
}
