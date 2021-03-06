﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class PuppetBehaviorWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(PuppetBehavior), typeof(EntityBehavior));
		L.RegFunction("SetPosition", SetPosition);
		L.RegFunction("GetAnimationLength", GetAnimationLength);
		L.RegFunction("GetAnimationWrapMode", GetAnimationWrapMode);
		L.RegFunction("HasAnimation", HasAnimation);
		L.RegFunction("PlayAnimation", PlayAnimation);
		L.RegFunction("UpdateLogic", UpdateLogic);
		L.RegFunction("SetLogicSpeed", SetLogicSpeed);
		L.RegFunction("SetAnimationSpeed", SetAnimationSpeed);
		L.RegFunction("SetCurrentAnimationSpeed", SetCurrentAnimationSpeed);
		L.RegFunction("StopAnimation", StopAnimation);
		L.RegFunction("SetRotation", SetRotation);
		L.RegFunction("GetRotation", GetRotation);
		L.RegFunction("SetLookAt", SetLookAt);
		L.RegFunction("SetModel", SetModel);
		L.RegFunction("SetScale", SetScale);
		L.RegFunction("Moveto", Moveto);
		L.RegFunction("MoveDir", MoveDir);
		L.RegFunction("UpdateMoveto", UpdateMoveto);
		L.RegFunction("StopAt", StopAt);
		L.RegFunction("StopMove", StopMove);
		L.RegFunction("OnKnockBarrier", OnKnockBarrier);
		L.RegFunction("PlayShake", PlayShake);
		L.RegFunction("SpurtTo", SpurtTo);
		L.RegFunction("AddSoundEvent", AddSoundEvent);
		L.RegFunction("AddEffectEvent", AddEffectEvent);
		L.RegFunction("AddSpurtEvent", AddSpurtEvent);
		L.RegFunction("OnNewObject", OnNewObject);
		L.RegFunction("OnRecycle", OnRecycle);
		L.RegFunction("DestroyComponent", DestroyComponent);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", Lua_ToString);
		L.RegVar("OnPlayAnimation", get_OnPlayAnimation, set_OnPlayAnimation);
		L.RegVar("currentAnim", get_currentAnim, set_currentAnim);
		L.RegVar("defaultAnimation", get_defaultAnimation, set_defaultAnimation);
		L.RegVar("runAnimation", get_runAnimation, set_runAnimation);
		L.RegVar("navigationComp", get_navigationComp, null);
		L.RegVar("spurtComp", get_spurtComp, null);
		L.RegVar("rotateComp", get_rotateComp, null);
		L.RegVar("updatePosComp", get_updatePosComp, null);
		L.RegVar("animationEvt", get_animationEvt, null);
		L.RegVar("synComp", get_synComp, null);
		L.RegVar("audioSource", get_audioSource, null);
		L.RegVar("Visible", get_Visible, set_Visible);
		L.RegVar("AutoSwitchNextAnimation", get_AutoSwitchNextAnimation, set_AutoSwitchNextAnimation);
		L.RegVar("Speed", get_Speed, set_Speed);
		L.RegVar("RotateSpeed", get_RotateSpeed, set_RotateSpeed);
		L.RegVar("Radius", get_Radius, set_Radius);
		L.RegVar("StoppingDistance", get_StoppingDistance, set_StoppingDistance);
		L.RegVar("IsDied", get_IsDied, set_IsDied);
		L.RegVar("IsBodyActive", get_IsBodyActive, set_IsBodyActive);
		L.RegVar("IsPlayEffect", get_IsPlayEffect, set_IsPlayEffect);
		L.RegVar("IsMoving", get_IsMoving, null);
		L.RegVar("IsSyncPosition", get_IsSyncPosition, set_IsSyncPosition);
		L.RegVar("IsNavMesh", get_IsNavMesh, set_IsNavMesh);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetPosition(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			PuppetBehavior obj = (PuppetBehavior)ToLua.CheckObject(L, 1, typeof(PuppetBehavior));
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
			obj.SetPosition(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetAnimationLength(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			PuppetBehavior obj = (PuppetBehavior)ToLua.CheckObject(L, 1, typeof(PuppetBehavior));
			string arg0 = ToLua.CheckString(L, 2);
			float o = obj.GetAnimationLength(arg0);
			LuaDLL.lua_pushnumber(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetAnimationWrapMode(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			PuppetBehavior obj = (PuppetBehavior)ToLua.CheckObject(L, 1, typeof(PuppetBehavior));
			string arg0 = ToLua.CheckString(L, 2);
			int o = obj.GetAnimationWrapMode(arg0);
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int HasAnimation(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			PuppetBehavior obj = (PuppetBehavior)ToLua.CheckObject(L, 1, typeof(PuppetBehavior));
			string arg0 = ToLua.CheckString(L, 2);
			bool o = obj.HasAnimation(arg0);
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int PlayAnimation(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			PuppetBehavior obj = (PuppetBehavior)ToLua.CheckObject(L, 1, typeof(PuppetBehavior));
			string arg0 = ToLua.CheckString(L, 2);
			float o = obj.PlayAnimation(arg0);
			LuaDLL.lua_pushnumber(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UpdateLogic(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			PuppetBehavior obj = (PuppetBehavior)ToLua.CheckObject(L, 1, typeof(PuppetBehavior));
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.UpdateLogic(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetLogicSpeed(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			PuppetBehavior obj = (PuppetBehavior)ToLua.CheckObject(L, 1, typeof(PuppetBehavior));
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.SetLogicSpeed(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetAnimationSpeed(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			PuppetBehavior obj = (PuppetBehavior)ToLua.CheckObject(L, 1, typeof(PuppetBehavior));
			string arg0 = ToLua.CheckString(L, 2);
			float arg1 = (float)LuaDLL.luaL_checknumber(L, 3);
			obj.SetAnimationSpeed(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetCurrentAnimationSpeed(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			PuppetBehavior obj = (PuppetBehavior)ToLua.CheckObject(L, 1, typeof(PuppetBehavior));
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.SetCurrentAnimationSpeed(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int StopAnimation(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			PuppetBehavior obj = (PuppetBehavior)ToLua.CheckObject(L, 1, typeof(PuppetBehavior));
			string arg0 = ToLua.CheckString(L, 2);
			obj.StopAnimation(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetRotation(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			PuppetBehavior obj = (PuppetBehavior)ToLua.CheckObject(L, 1, typeof(PuppetBehavior));
			UnityEngine.Quaternion arg0 = ToLua.ToQuaternion(L, 2);
			obj.SetRotation(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetRotation(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			PuppetBehavior obj = (PuppetBehavior)ToLua.CheckObject(L, 1, typeof(PuppetBehavior));
			UnityEngine.Quaternion o = obj.GetRotation();
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetLookAt(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			PuppetBehavior obj = (PuppetBehavior)ToLua.CheckObject(L, 1, typeof(PuppetBehavior));
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
			obj.SetLookAt(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetModel(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			PuppetBehavior obj = (PuppetBehavior)ToLua.CheckObject(L, 1, typeof(PuppetBehavior));
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckUnityObject(L, 2, typeof(UnityEngine.GameObject));
			float arg1 = (float)LuaDLL.luaL_checknumber(L, 3);
			obj.SetModel(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetScale(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			PuppetBehavior obj = (PuppetBehavior)ToLua.CheckObject(L, 1, typeof(PuppetBehavior));
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.SetScale(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Moveto(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			PuppetBehavior obj = (PuppetBehavior)ToLua.CheckObject(L, 1, typeof(PuppetBehavior));
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
			obj.Moveto(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int MoveDir(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			PuppetBehavior obj = (PuppetBehavior)ToLua.CheckObject(L, 1, typeof(PuppetBehavior));
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
			obj.MoveDir(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UpdateMoveto(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 5);
			PuppetBehavior obj = (PuppetBehavior)ToLua.CheckObject(L, 1, typeof(PuppetBehavior));
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
			float arg1 = (float)LuaDLL.luaL_checknumber(L, 3);
			float arg2 = (float)LuaDLL.luaL_checknumber(L, 4);
			float arg3 = (float)LuaDLL.luaL_checknumber(L, 5);
			obj.UpdateMoveto(arg0, arg1, arg2, arg3);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int StopAt(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			PuppetBehavior obj = (PuppetBehavior)ToLua.CheckObject(L, 1, typeof(PuppetBehavior));
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
			float arg1 = (float)LuaDLL.luaL_checknumber(L, 3);
			obj.StopAt(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int StopMove(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			PuppetBehavior obj = (PuppetBehavior)ToLua.CheckObject(L, 1, typeof(PuppetBehavior));
			obj.StopMove();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnKnockBarrier(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			PuppetBehavior obj = (PuppetBehavior)ToLua.CheckObject(L, 1, typeof(PuppetBehavior));
			UnityEngine.BoxCollider arg0 = (UnityEngine.BoxCollider)ToLua.CheckUnityObject(L, 2, typeof(UnityEngine.BoxCollider));
			obj.OnKnockBarrier(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int PlayShake(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			PuppetBehavior obj = (PuppetBehavior)ToLua.CheckObject(L, 1, typeof(PuppetBehavior));
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			float arg1 = (float)LuaDLL.luaL_checknumber(L, 3);
			obj.PlayShake(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SpurtTo(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 10);
			PuppetBehavior obj = (PuppetBehavior)ToLua.CheckObject(L, 1, typeof(PuppetBehavior));
			UnityEngine.Vector3 arg0 = ToLua.ToVector3(L, 2);
			float arg1 = (float)LuaDLL.luaL_checknumber(L, 3);
			float arg2 = (float)LuaDLL.luaL_checknumber(L, 4);
			float arg3 = (float)LuaDLL.luaL_checknumber(L, 5);
			float arg4 = (float)LuaDLL.luaL_checknumber(L, 6);
			bool arg5 = LuaDLL.luaL_checkboolean(L, 7);
			float arg6 = (float)LuaDLL.luaL_checknumber(L, 8);
			float arg7 = (float)LuaDLL.luaL_checknumber(L, 9);
			bool arg8 = LuaDLL.luaL_checkboolean(L, 10);
			obj.SpurtTo(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddSoundEvent(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 4);
			PuppetBehavior obj = (PuppetBehavior)ToLua.CheckObject(L, 1, typeof(PuppetBehavior));
			string arg0 = ToLua.CheckString(L, 2);
			float arg1 = (float)LuaDLL.luaL_checknumber(L, 3);
			string arg2 = ToLua.CheckString(L, 4);
			obj.AddSoundEvent(arg0, arg1, arg2);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddEffectEvent(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 11);
			PuppetBehavior obj = (PuppetBehavior)ToLua.CheckObject(L, 1, typeof(PuppetBehavior));
			string arg0 = ToLua.CheckString(L, 2);
			float arg1 = (float)LuaDLL.luaL_checknumber(L, 3);
			string arg2 = ToLua.CheckString(L, 4);
			string arg3 = ToLua.CheckString(L, 5);
			bool arg4 = LuaDLL.luaL_checkboolean(L, 6);
			float arg5 = (float)LuaDLL.luaL_checknumber(L, 7);
			float arg6 = (float)LuaDLL.luaL_checknumber(L, 8);
			UnityEngine.Vector3 arg7 = ToLua.ToVector3(L, 9);
			UnityEngine.Vector3 arg8 = ToLua.ToVector3(L, 10);
			UnityEngine.Vector3 arg9 = ToLua.ToVector3(L, 11);
			obj.AddEffectEvent(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddSpurtEvent(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 11);
			PuppetBehavior obj = (PuppetBehavior)ToLua.CheckObject(L, 1, typeof(PuppetBehavior));
			string arg0 = ToLua.CheckString(L, 2);
			float arg1 = (float)LuaDLL.luaL_checknumber(L, 3);
			float arg2 = (float)LuaDLL.luaL_checknumber(L, 4);
			float arg3 = (float)LuaDLL.luaL_checknumber(L, 5);
			float arg4 = (float)LuaDLL.luaL_checknumber(L, 6);
			float arg5 = (float)LuaDLL.luaL_checknumber(L, 7);
			bool arg6 = LuaDLL.luaL_checkboolean(L, 8);
			float arg7 = (float)LuaDLL.luaL_checknumber(L, 9);
			float arg8 = (float)LuaDLL.luaL_checknumber(L, 10);
			bool arg9 = LuaDLL.luaL_checkboolean(L, 11);
			obj.AddSpurtEvent(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnNewObject(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			PuppetBehavior obj = (PuppetBehavior)ToLua.CheckObject(L, 1, typeof(PuppetBehavior));
			obj.OnNewObject();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnRecycle(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			PuppetBehavior obj = (PuppetBehavior)ToLua.CheckObject(L, 1, typeof(PuppetBehavior));
			obj.OnRecycle();
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DestroyComponent(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			PuppetBehavior obj = (PuppetBehavior)ToLua.CheckObject(L, 1, typeof(PuppetBehavior));
			UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.CheckUnityObject(L, 2, typeof(UnityEngine.Object));
			obj.DestroyComponent(arg0);
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
	static int get_OnPlayAnimation(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PuppetBehavior obj = (PuppetBehavior)o;
			System.Action<string> ret = obj.OnPlayAnimation;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index OnPlayAnimation on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_currentAnim(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PuppetBehavior obj = (PuppetBehavior)o;
			string ret = obj.currentAnim;
			LuaDLL.lua_pushstring(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index currentAnim on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_defaultAnimation(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PuppetBehavior obj = (PuppetBehavior)o;
			string ret = obj.defaultAnimation;
			LuaDLL.lua_pushstring(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index defaultAnimation on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_runAnimation(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PuppetBehavior obj = (PuppetBehavior)o;
			string ret = obj.runAnimation;
			LuaDLL.lua_pushstring(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index runAnimation on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_navigationComp(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PuppetBehavior obj = (PuppetBehavior)o;
			NavigationComp ret = obj.navigationComp;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index navigationComp on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_spurtComp(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PuppetBehavior obj = (PuppetBehavior)o;
			SpurtComp ret = obj.spurtComp;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index spurtComp on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_rotateComp(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PuppetBehavior obj = (PuppetBehavior)o;
			RotateComp ret = obj.rotateComp;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index rotateComp on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_updatePosComp(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PuppetBehavior obj = (PuppetBehavior)o;
			UpdatePosComp ret = obj.updatePosComp;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index updatePosComp on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_animationEvt(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PuppetBehavior obj = (PuppetBehavior)o;
			AnimationEventSimulator ret = obj.animationEvt;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index animationEvt on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_synComp(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PuppetBehavior obj = (PuppetBehavior)o;
			SynComp ret = obj.synComp;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index synComp on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_audioSource(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PuppetBehavior obj = (PuppetBehavior)o;
			UnityEngine.AudioSource ret = obj.audioSource;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index audioSource on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Visible(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PuppetBehavior obj = (PuppetBehavior)o;
			bool ret = obj.Visible;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index Visible on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_AutoSwitchNextAnimation(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PuppetBehavior obj = (PuppetBehavior)o;
			bool ret = obj.AutoSwitchNextAnimation;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index AutoSwitchNextAnimation on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Speed(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PuppetBehavior obj = (PuppetBehavior)o;
			float ret = obj.Speed;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index Speed on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_RotateSpeed(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PuppetBehavior obj = (PuppetBehavior)o;
			float ret = obj.RotateSpeed;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index RotateSpeed on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Radius(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PuppetBehavior obj = (PuppetBehavior)o;
			float ret = obj.Radius;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index Radius on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_StoppingDistance(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PuppetBehavior obj = (PuppetBehavior)o;
			float ret = obj.StoppingDistance;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index StoppingDistance on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_IsDied(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PuppetBehavior obj = (PuppetBehavior)o;
			bool ret = obj.IsDied;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index IsDied on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_IsBodyActive(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PuppetBehavior obj = (PuppetBehavior)o;
			bool ret = obj.IsBodyActive;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index IsBodyActive on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_IsPlayEffect(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PuppetBehavior obj = (PuppetBehavior)o;
			bool ret = obj.IsPlayEffect;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index IsPlayEffect on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_IsMoving(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PuppetBehavior obj = (PuppetBehavior)o;
			bool ret = obj.IsMoving;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index IsMoving on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_IsSyncPosition(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PuppetBehavior obj = (PuppetBehavior)o;
			bool ret = obj.IsSyncPosition;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index IsSyncPosition on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_IsNavMesh(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PuppetBehavior obj = (PuppetBehavior)o;
			bool ret = obj.IsNavMesh;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index IsNavMesh on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_OnPlayAnimation(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PuppetBehavior obj = (PuppetBehavior)o;
			System.Action<string> arg0 = null;
			LuaTypes funcType2 = LuaDLL.lua_type(L, 2);

			if (funcType2 != LuaTypes.LUA_TFUNCTION)
			{
				 arg0 = (System.Action<string>)ToLua.CheckObject(L, 2, typeof(System.Action<string>));
			}
			else
			{
				LuaFunction func = ToLua.ToLuaFunction(L, 2);
				arg0 = DelegateFactory.CreateDelegate(typeof(System.Action<string>), func) as System.Action<string>;
			}

			obj.OnPlayAnimation = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index OnPlayAnimation on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_currentAnim(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PuppetBehavior obj = (PuppetBehavior)o;
			string arg0 = ToLua.CheckString(L, 2);
			obj.currentAnim = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index currentAnim on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_defaultAnimation(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PuppetBehavior obj = (PuppetBehavior)o;
			string arg0 = ToLua.CheckString(L, 2);
			obj.defaultAnimation = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index defaultAnimation on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_runAnimation(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PuppetBehavior obj = (PuppetBehavior)o;
			string arg0 = ToLua.CheckString(L, 2);
			obj.runAnimation = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index runAnimation on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Visible(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PuppetBehavior obj = (PuppetBehavior)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.Visible = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index Visible on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_AutoSwitchNextAnimation(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PuppetBehavior obj = (PuppetBehavior)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.AutoSwitchNextAnimation = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index AutoSwitchNextAnimation on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Speed(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PuppetBehavior obj = (PuppetBehavior)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.Speed = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index Speed on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_RotateSpeed(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PuppetBehavior obj = (PuppetBehavior)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.RotateSpeed = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index RotateSpeed on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Radius(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PuppetBehavior obj = (PuppetBehavior)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.Radius = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index Radius on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_StoppingDistance(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PuppetBehavior obj = (PuppetBehavior)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.StoppingDistance = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index StoppingDistance on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_IsDied(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PuppetBehavior obj = (PuppetBehavior)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.IsDied = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index IsDied on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_IsBodyActive(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PuppetBehavior obj = (PuppetBehavior)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.IsBodyActive = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index IsBodyActive on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_IsPlayEffect(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PuppetBehavior obj = (PuppetBehavior)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.IsPlayEffect = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index IsPlayEffect on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_IsSyncPosition(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PuppetBehavior obj = (PuppetBehavior)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.IsSyncPosition = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index IsSyncPosition on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_IsNavMesh(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			PuppetBehavior obj = (PuppetBehavior)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.IsNavMesh = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index IsNavMesh on a nil value" : e.Message);
		}
	}
}

