namespace TableTool
{
	public class UI_uiModel : LocalModel<UI_ui, int>
	{
		private const string _Filename = "UI_ui";

		protected override string Filename => null;

		protected override int GetBeanKey(UI_ui bean)
		{
			return 0;
		}

		public void Init()
		{
		}

		public UI_ui GetBeanById(WindowID id)
		{
			return null;
		}

		public UI_ui GetBeanByClassName(string classname)
		{
			return null;
		}

		public bool IsPop(WindowID id)
		{
			return false;
		}

		public bool IsPop(string classname)
		{
			return false;
		}

		public bool IsPopMain(WindowID id)
		{
			return false;
		}

		public string GetClassName(WindowID id)
		{
			return null;
		}

		public string GetNote(WindowID id)
		{
			return null;
		}

		public string GetNote(string classname)
		{
			return null;
		}

		public int GetState(WindowID id)
		{
			return 0;
		}

		public bool IsMainUI(WindowID id)
		{
			return false;
		}

		public bool IsBattleUI(WindowID id)
		{
			return false;
		}

		public int GetOrder(WindowID id)
		{
			return 0;
		}

		public bool IsLockOrder(WindowID id)
		{
			return false;
		}
	}
}
