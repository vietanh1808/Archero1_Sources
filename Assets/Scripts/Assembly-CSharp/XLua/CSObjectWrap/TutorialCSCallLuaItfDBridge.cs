using Tutorial;

namespace XLua.CSObjectWrap
{
	public class TutorialCSCallLuaItfDBridge : LuaBase, CSCallLua.ItfD
	{
		int CSCallLua.ItfD.f1
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		int CSCallLua.ItfD.f2
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public static LuaBase __Create(int reference, LuaEnv luaenv)
		{
			return null;
		}

		public TutorialCSCallLuaItfDBridge(int reference, LuaEnv luaenv)
			: base(0, null)
		{
		}

		int CSCallLua.ItfD.add(int a, int b)
		{
			return 0;
		}
	}
}
