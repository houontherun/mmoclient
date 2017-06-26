﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class GameManagerWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(GameManager), typeof(Manager));
		L.RegFunction("StartGame", StartGame);
		L.RegFunction("GetLuaModule", GetLuaModule);
		L.RegFunction("GetAOIModule", GetAOIModule);
		L.RegFunction("Destroy", Destroy);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", Lua_ToString);
		L.RegVar("IsGameStart", get_IsGameStart, set_IsGameStart);
		L.RegVar("CullGroup", get_CullGroup, set_CullGroup);
		L.RegVar("CanSyncMsg", get_CanSyncMsg, set_CanSyncMsg);
		L.RegVar("GameSpeed", get_GameSpeed, set_GameSpeed);
		L.RegVar("IsCreated", get_IsCreated, set_IsCreated);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int StartGame(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			GameManager obj = (GameManager)ToLua.CheckObject(L, 1, typeof(GameManager));
			obj.StartGame();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetLuaModule(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			GameManager obj = (GameManager)ToLua.CheckObject(L, 1, typeof(GameManager));
			LuaModule o = obj.GetLuaModule();
			ToLua.PushObject(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetAOIModule(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			GameManager obj = (GameManager)ToLua.CheckObject(L, 1, typeof(GameManager));
			AOIModule o = obj.GetAOIModule();
			ToLua.PushObject(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Destroy(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			GameManager obj = (GameManager)ToLua.CheckObject(L, 1, typeof(GameManager));
			obj.Destroy();
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
	static int get_IsGameStart(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			GameManager obj = (GameManager)o;
			bool ret = obj.IsGameStart;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index IsGameStart on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_CullGroup(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			GameManager obj = (GameManager)o;
			CullingGroupLoadRes ret = obj.CullGroup;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index CullGroup on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_CanSyncMsg(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			GameManager obj = (GameManager)o;
			bool ret = obj.CanSyncMsg;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index CanSyncMsg on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_GameSpeed(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			GameManager obj = (GameManager)o;
			float ret = obj.GameSpeed;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index GameSpeed on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_IsCreated(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			GameManager obj = (GameManager)o;
			bool ret = obj.IsCreated;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index IsCreated on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_IsGameStart(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			GameManager obj = (GameManager)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.IsGameStart = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index IsGameStart on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_CullGroup(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			GameManager obj = (GameManager)o;
			CullingGroupLoadRes arg0 = (CullingGroupLoadRes)ToLua.CheckUnityObject(L, 2, typeof(CullingGroupLoadRes));
			obj.CullGroup = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index CullGroup on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_CanSyncMsg(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			GameManager obj = (GameManager)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.CanSyncMsg = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index CanSyncMsg on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_GameSpeed(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			GameManager obj = (GameManager)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.GameSpeed = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index GameSpeed on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_IsCreated(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			GameManager obj = (GameManager)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.IsCreated = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index IsCreated on a nil value" : e.Message);
		}
	}
}

