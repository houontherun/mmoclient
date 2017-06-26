﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class LuaBehaviourWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(LuaBehaviour), typeof(View));
		L.RegFunction("LoadLuaScript", LoadLuaScript);
		L.RegFunction("OnMessage", OnMessage);
		L.RegFunction("OnEnable", OnEnable);
		L.RegFunction("OnDisable", OnDisable);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", Lua_ToString);
		L.RegVar("FullPath", get_FullPath, set_FullPath);
		L.RegVar("component", get_component, set_component);
		L.RegVar("onMessage", get_onMessage, set_onMessage);
		L.RegVar("luaTable", get_luaTable, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LoadLuaScript(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			LuaBehaviour obj = (LuaBehaviour)ToLua.CheckObject(L, 1, typeof(LuaBehaviour));
			string arg0 = ToLua.CheckString(L, 2);
			obj.LoadLuaScript(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnMessage(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			LuaBehaviour obj = (LuaBehaviour)ToLua.CheckObject(L, 1, typeof(LuaBehaviour));
			IMessage arg0 = (IMessage)ToLua.CheckObject(L, 2, typeof(IMessage));
			obj.OnMessage(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnEnable(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			LuaBehaviour obj = (LuaBehaviour)ToLua.CheckObject(L, 1, typeof(LuaBehaviour));
			obj.OnEnable();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnDisable(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			LuaBehaviour obj = (LuaBehaviour)ToLua.CheckObject(L, 1, typeof(LuaBehaviour));
			obj.OnDisable();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int op_Equality(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.ToObject(L, 1);
			UnityEngine.Object arg1 = (UnityEngine.Object)ToLua.ToObject(L, 2);
			bool o = arg0 == arg1;
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Lua_ToString(IntPtr L)
	{
		object obj = ToLua.ToObject(L, 1);

		if (obj != null)
		{
			LuaDLL.lua_pushstring(L, obj.ToString());
		}
		else
		{
			LuaDLL.lua_pushnil(L);
		}

		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_FullPath(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			LuaBehaviour obj = (LuaBehaviour)o;
			string ret = obj.FullPath;
			LuaDLL.lua_pushstring(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index FullPath on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_component(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			LuaBehaviour obj = (LuaBehaviour)o;
			bool ret = obj.component;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index component on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onMessage(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			LuaBehaviour obj = (LuaBehaviour)o;
			LuaInterface.LuaFunction ret = obj.onMessage;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index onMessage on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_luaTable(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			LuaBehaviour obj = (LuaBehaviour)o;
			LuaInterface.LuaTable ret = obj.luaTable;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index luaTable on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_FullPath(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			LuaBehaviour obj = (LuaBehaviour)o;
			string arg0 = ToLua.CheckString(L, 2);
			obj.FullPath = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index FullPath on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_component(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			LuaBehaviour obj = (LuaBehaviour)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.component = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index component on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onMessage(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			LuaBehaviour obj = (LuaBehaviour)o;
			LuaFunction arg0 = ToLua.CheckLuaFunction(L, 2);
			obj.onMessage = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index onMessage on a nil value" : e.Message);
		}
	}
}

