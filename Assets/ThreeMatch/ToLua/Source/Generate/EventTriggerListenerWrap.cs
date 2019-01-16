﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class EventTriggerListenerWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(EventTriggerListener), typeof(UnityEngine.EventSystems.EventTrigger));
		L.RegFunction("GetListener", GetListener);
		L.RegFunction("SetLuaTable", SetLuaTable);
		L.RegFunction("OnBeginDrag", OnBeginDrag);
		L.RegFunction("OnDrag", OnDrag);
		L.RegFunction("OnDrop", OnDrop);
		L.RegFunction("OnEndDrag", OnEndDrag);
		L.RegFunction("OnInitializePotentialDrag", OnInitializePotentialDrag);
		L.RegFunction("OnPointerClick", OnPointerClick);
		L.RegFunction("OnPointerDown", OnPointerDown);
		L.RegFunction("OnPointerEnter", OnPointerEnter);
		L.RegFunction("OnPointerExit", OnPointerExit);
		L.RegFunction("OnPointerUp", OnPointerUp);
		L.RegFunction("OnScroll", OnScroll);
		L.RegFunction("OnCancel", OnCancel);
		L.RegFunction("OnDeselect", OnDeselect);
		L.RegFunction("OnSelect", OnSelect);
		L.RegFunction("OnSubmit", OnSubmit);
		L.RegFunction("OnUpdateSelected", OnUpdateSelected);
		L.RegFunction("OnMove", OnMove);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("onBeginDrag", get_onBeginDrag, set_onBeginDrag);
		L.RegVar("onDrag", get_onDrag, set_onDrag);
		L.RegVar("onDrop", get_onDrop, set_onDrop);
		L.RegVar("onEndDrag", get_onEndDrag, set_onEndDrag);
		L.RegVar("onInitializePotentialDrag", get_onInitializePotentialDrag, set_onInitializePotentialDrag);
		L.RegVar("onPointerClick", get_onPointerClick, set_onPointerClick);
		L.RegVar("onPointerDown", get_onPointerDown, set_onPointerDown);
		L.RegVar("onPointerEnter", get_onPointerEnter, set_onPointerEnter);
		L.RegVar("onPointerExit", get_onPointerExit, set_onPointerExit);
		L.RegVar("onPointerUp", get_onPointerUp, set_onPointerUp);
		L.RegVar("onScroll", get_onScroll, set_onScroll);
		L.RegVar("onCancel", get_onCancel, set_onCancel);
		L.RegVar("onDeselect", get_onDeselect, set_onDeselect);
		L.RegVar("onSelect", get_onSelect, set_onSelect);
		L.RegVar("onSubmit", get_onSubmit, set_onSubmit);
		L.RegVar("onUpdateSelected", get_onUpdateSelected, set_onUpdateSelected);
		L.RegVar("onMove", get_onMove, set_onMove);
		L.RegFunction("AxisEventDelegate", EventTriggerListener_AxisEventDelegate);
		L.RegFunction("BaseEventDelegate", EventTriggerListener_BaseEventDelegate);
		L.RegFunction("PointerEventDelegate", EventTriggerListener_PointerEventDelegate);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetListener(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckObject(L, 1, typeof(UnityEngine.GameObject));
			EventTriggerListener o = EventTriggerListener.GetListener(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetLuaTable(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			EventTriggerListener obj = (EventTriggerListener)ToLua.CheckObject<EventTriggerListener>(L, 1);
			LuaTable arg0 = ToLua.CheckLuaTable(L, 2);
			obj.SetLuaTable(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnBeginDrag(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			EventTriggerListener obj = (EventTriggerListener)ToLua.CheckObject<EventTriggerListener>(L, 1);
			UnityEngine.EventSystems.PointerEventData arg0 = (UnityEngine.EventSystems.PointerEventData)ToLua.CheckObject<UnityEngine.EventSystems.PointerEventData>(L, 2);
			obj.OnBeginDrag(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnDrag(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			EventTriggerListener obj = (EventTriggerListener)ToLua.CheckObject<EventTriggerListener>(L, 1);
			UnityEngine.EventSystems.PointerEventData arg0 = (UnityEngine.EventSystems.PointerEventData)ToLua.CheckObject<UnityEngine.EventSystems.PointerEventData>(L, 2);
			obj.OnDrag(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnDrop(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			EventTriggerListener obj = (EventTriggerListener)ToLua.CheckObject<EventTriggerListener>(L, 1);
			UnityEngine.EventSystems.PointerEventData arg0 = (UnityEngine.EventSystems.PointerEventData)ToLua.CheckObject<UnityEngine.EventSystems.PointerEventData>(L, 2);
			obj.OnDrop(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnEndDrag(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			EventTriggerListener obj = (EventTriggerListener)ToLua.CheckObject<EventTriggerListener>(L, 1);
			UnityEngine.EventSystems.PointerEventData arg0 = (UnityEngine.EventSystems.PointerEventData)ToLua.CheckObject<UnityEngine.EventSystems.PointerEventData>(L, 2);
			obj.OnEndDrag(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnInitializePotentialDrag(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			EventTriggerListener obj = (EventTriggerListener)ToLua.CheckObject<EventTriggerListener>(L, 1);
			UnityEngine.EventSystems.PointerEventData arg0 = (UnityEngine.EventSystems.PointerEventData)ToLua.CheckObject<UnityEngine.EventSystems.PointerEventData>(L, 2);
			obj.OnInitializePotentialDrag(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnPointerClick(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			EventTriggerListener obj = (EventTriggerListener)ToLua.CheckObject<EventTriggerListener>(L, 1);
			UnityEngine.EventSystems.PointerEventData arg0 = (UnityEngine.EventSystems.PointerEventData)ToLua.CheckObject<UnityEngine.EventSystems.PointerEventData>(L, 2);
			obj.OnPointerClick(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnPointerDown(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			EventTriggerListener obj = (EventTriggerListener)ToLua.CheckObject<EventTriggerListener>(L, 1);
			UnityEngine.EventSystems.PointerEventData arg0 = (UnityEngine.EventSystems.PointerEventData)ToLua.CheckObject<UnityEngine.EventSystems.PointerEventData>(L, 2);
			obj.OnPointerDown(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnPointerEnter(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			EventTriggerListener obj = (EventTriggerListener)ToLua.CheckObject<EventTriggerListener>(L, 1);
			UnityEngine.EventSystems.PointerEventData arg0 = (UnityEngine.EventSystems.PointerEventData)ToLua.CheckObject<UnityEngine.EventSystems.PointerEventData>(L, 2);
			obj.OnPointerEnter(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnPointerExit(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			EventTriggerListener obj = (EventTriggerListener)ToLua.CheckObject<EventTriggerListener>(L, 1);
			UnityEngine.EventSystems.PointerEventData arg0 = (UnityEngine.EventSystems.PointerEventData)ToLua.CheckObject<UnityEngine.EventSystems.PointerEventData>(L, 2);
			obj.OnPointerExit(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnPointerUp(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			EventTriggerListener obj = (EventTriggerListener)ToLua.CheckObject<EventTriggerListener>(L, 1);
			UnityEngine.EventSystems.PointerEventData arg0 = (UnityEngine.EventSystems.PointerEventData)ToLua.CheckObject<UnityEngine.EventSystems.PointerEventData>(L, 2);
			obj.OnPointerUp(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnScroll(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			EventTriggerListener obj = (EventTriggerListener)ToLua.CheckObject<EventTriggerListener>(L, 1);
			UnityEngine.EventSystems.PointerEventData arg0 = (UnityEngine.EventSystems.PointerEventData)ToLua.CheckObject<UnityEngine.EventSystems.PointerEventData>(L, 2);
			obj.OnScroll(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnCancel(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			EventTriggerListener obj = (EventTriggerListener)ToLua.CheckObject<EventTriggerListener>(L, 1);
			UnityEngine.EventSystems.BaseEventData arg0 = (UnityEngine.EventSystems.BaseEventData)ToLua.CheckObject<UnityEngine.EventSystems.BaseEventData>(L, 2);
			obj.OnCancel(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnDeselect(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			EventTriggerListener obj = (EventTriggerListener)ToLua.CheckObject<EventTriggerListener>(L, 1);
			UnityEngine.EventSystems.BaseEventData arg0 = (UnityEngine.EventSystems.BaseEventData)ToLua.CheckObject<UnityEngine.EventSystems.BaseEventData>(L, 2);
			obj.OnDeselect(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnSelect(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			EventTriggerListener obj = (EventTriggerListener)ToLua.CheckObject<EventTriggerListener>(L, 1);
			UnityEngine.EventSystems.BaseEventData arg0 = (UnityEngine.EventSystems.BaseEventData)ToLua.CheckObject<UnityEngine.EventSystems.BaseEventData>(L, 2);
			obj.OnSelect(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnSubmit(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			EventTriggerListener obj = (EventTriggerListener)ToLua.CheckObject<EventTriggerListener>(L, 1);
			UnityEngine.EventSystems.BaseEventData arg0 = (UnityEngine.EventSystems.BaseEventData)ToLua.CheckObject<UnityEngine.EventSystems.BaseEventData>(L, 2);
			obj.OnSubmit(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnUpdateSelected(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			EventTriggerListener obj = (EventTriggerListener)ToLua.CheckObject<EventTriggerListener>(L, 1);
			UnityEngine.EventSystems.BaseEventData arg0 = (UnityEngine.EventSystems.BaseEventData)ToLua.CheckObject<UnityEngine.EventSystems.BaseEventData>(L, 2);
			obj.OnUpdateSelected(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnMove(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			EventTriggerListener obj = (EventTriggerListener)ToLua.CheckObject<EventTriggerListener>(L, 1);
			UnityEngine.EventSystems.AxisEventData arg0 = (UnityEngine.EventSystems.AxisEventData)ToLua.CheckObject<UnityEngine.EventSystems.AxisEventData>(L, 2);
			obj.OnMove(arg0);
			return 0;
		}
		catch (Exception e)
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
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onBeginDrag(IntPtr L)
	{
		ToLua.Push(L, new EventObject(typeof(EventTriggerListener.PointerEventDelegate)));
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onDrag(IntPtr L)
	{
		ToLua.Push(L, new EventObject(typeof(EventTriggerListener.PointerEventDelegate)));
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onDrop(IntPtr L)
	{
		ToLua.Push(L, new EventObject(typeof(EventTriggerListener.PointerEventDelegate)));
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onEndDrag(IntPtr L)
	{
		ToLua.Push(L, new EventObject(typeof(EventTriggerListener.PointerEventDelegate)));
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onInitializePotentialDrag(IntPtr L)
	{
		ToLua.Push(L, new EventObject(typeof(EventTriggerListener.PointerEventDelegate)));
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onPointerClick(IntPtr L)
	{
		ToLua.Push(L, new EventObject(typeof(EventTriggerListener.PointerEventDelegate)));
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onPointerDown(IntPtr L)
	{
		ToLua.Push(L, new EventObject(typeof(EventTriggerListener.PointerEventDelegate)));
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onPointerEnter(IntPtr L)
	{
		ToLua.Push(L, new EventObject(typeof(EventTriggerListener.PointerEventDelegate)));
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onPointerExit(IntPtr L)
	{
		ToLua.Push(L, new EventObject(typeof(EventTriggerListener.PointerEventDelegate)));
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onPointerUp(IntPtr L)
	{
		ToLua.Push(L, new EventObject(typeof(EventTriggerListener.PointerEventDelegate)));
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onScroll(IntPtr L)
	{
		ToLua.Push(L, new EventObject(typeof(EventTriggerListener.PointerEventDelegate)));
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onCancel(IntPtr L)
	{
		ToLua.Push(L, new EventObject(typeof(EventTriggerListener.BaseEventDelegate)));
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onDeselect(IntPtr L)
	{
		ToLua.Push(L, new EventObject(typeof(EventTriggerListener.BaseEventDelegate)));
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onSelect(IntPtr L)
	{
		ToLua.Push(L, new EventObject(typeof(EventTriggerListener.BaseEventDelegate)));
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onSubmit(IntPtr L)
	{
		ToLua.Push(L, new EventObject(typeof(EventTriggerListener.BaseEventDelegate)));
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onUpdateSelected(IntPtr L)
	{
		ToLua.Push(L, new EventObject(typeof(EventTriggerListener.BaseEventDelegate)));
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onMove(IntPtr L)
	{
		ToLua.Push(L, new EventObject(typeof(EventTriggerListener.AxisEventDelegate)));
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onBeginDrag(IntPtr L)
	{
		try
		{
			EventTriggerListener obj = (EventTriggerListener)ToLua.CheckObject(L, 1, typeof(EventTriggerListener));
			EventObject arg0 = null;

			if (LuaDLL.lua_isuserdata(L, 2) != 0)
			{
				arg0 = (EventObject)ToLua.ToObject(L, 2);
			}
			else
			{
				return LuaDLL.luaL_throw(L, "The event 'EventTriggerListener.onBeginDrag' can only appear on the left hand side of += or -= when used outside of the type 'EventTriggerListener'");
			}

			if (arg0.op == EventOp.Add)
			{
				EventTriggerListener.PointerEventDelegate ev = (EventTriggerListener.PointerEventDelegate)arg0.func;
				obj.onBeginDrag += ev;
			}
			else if (arg0.op == EventOp.Sub)
			{
				EventTriggerListener.PointerEventDelegate ev = (EventTriggerListener.PointerEventDelegate)arg0.func;
				obj.onBeginDrag -= ev;
			}

			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onDrag(IntPtr L)
	{
		try
		{
			EventTriggerListener obj = (EventTriggerListener)ToLua.CheckObject(L, 1, typeof(EventTriggerListener));
			EventObject arg0 = null;

			if (LuaDLL.lua_isuserdata(L, 2) != 0)
			{
				arg0 = (EventObject)ToLua.ToObject(L, 2);
			}
			else
			{
				return LuaDLL.luaL_throw(L, "The event 'EventTriggerListener.onDrag' can only appear on the left hand side of += or -= when used outside of the type 'EventTriggerListener'");
			}

			if (arg0.op == EventOp.Add)
			{
				EventTriggerListener.PointerEventDelegate ev = (EventTriggerListener.PointerEventDelegate)arg0.func;
				obj.onDrag += ev;
			}
			else if (arg0.op == EventOp.Sub)
			{
				EventTriggerListener.PointerEventDelegate ev = (EventTriggerListener.PointerEventDelegate)arg0.func;
				obj.onDrag -= ev;
			}

			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onDrop(IntPtr L)
	{
		try
		{
			EventTriggerListener obj = (EventTriggerListener)ToLua.CheckObject(L, 1, typeof(EventTriggerListener));
			EventObject arg0 = null;

			if (LuaDLL.lua_isuserdata(L, 2) != 0)
			{
				arg0 = (EventObject)ToLua.ToObject(L, 2);
			}
			else
			{
				return LuaDLL.luaL_throw(L, "The event 'EventTriggerListener.onDrop' can only appear on the left hand side of += or -= when used outside of the type 'EventTriggerListener'");
			}

			if (arg0.op == EventOp.Add)
			{
				EventTriggerListener.PointerEventDelegate ev = (EventTriggerListener.PointerEventDelegate)arg0.func;
				obj.onDrop += ev;
			}
			else if (arg0.op == EventOp.Sub)
			{
				EventTriggerListener.PointerEventDelegate ev = (EventTriggerListener.PointerEventDelegate)arg0.func;
				obj.onDrop -= ev;
			}

			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onEndDrag(IntPtr L)
	{
		try
		{
			EventTriggerListener obj = (EventTriggerListener)ToLua.CheckObject(L, 1, typeof(EventTriggerListener));
			EventObject arg0 = null;

			if (LuaDLL.lua_isuserdata(L, 2) != 0)
			{
				arg0 = (EventObject)ToLua.ToObject(L, 2);
			}
			else
			{
				return LuaDLL.luaL_throw(L, "The event 'EventTriggerListener.onEndDrag' can only appear on the left hand side of += or -= when used outside of the type 'EventTriggerListener'");
			}

			if (arg0.op == EventOp.Add)
			{
				EventTriggerListener.PointerEventDelegate ev = (EventTriggerListener.PointerEventDelegate)arg0.func;
				obj.onEndDrag += ev;
			}
			else if (arg0.op == EventOp.Sub)
			{
				EventTriggerListener.PointerEventDelegate ev = (EventTriggerListener.PointerEventDelegate)arg0.func;
				obj.onEndDrag -= ev;
			}

			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onInitializePotentialDrag(IntPtr L)
	{
		try
		{
			EventTriggerListener obj = (EventTriggerListener)ToLua.CheckObject(L, 1, typeof(EventTriggerListener));
			EventObject arg0 = null;

			if (LuaDLL.lua_isuserdata(L, 2) != 0)
			{
				arg0 = (EventObject)ToLua.ToObject(L, 2);
			}
			else
			{
				return LuaDLL.luaL_throw(L, "The event 'EventTriggerListener.onInitializePotentialDrag' can only appear on the left hand side of += or -= when used outside of the type 'EventTriggerListener'");
			}

			if (arg0.op == EventOp.Add)
			{
				EventTriggerListener.PointerEventDelegate ev = (EventTriggerListener.PointerEventDelegate)arg0.func;
				obj.onInitializePotentialDrag += ev;
			}
			else if (arg0.op == EventOp.Sub)
			{
				EventTriggerListener.PointerEventDelegate ev = (EventTriggerListener.PointerEventDelegate)arg0.func;
				obj.onInitializePotentialDrag -= ev;
			}

			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onPointerClick(IntPtr L)
	{
		try
		{
			EventTriggerListener obj = (EventTriggerListener)ToLua.CheckObject(L, 1, typeof(EventTriggerListener));
			EventObject arg0 = null;

			if (LuaDLL.lua_isuserdata(L, 2) != 0)
			{
				arg0 = (EventObject)ToLua.ToObject(L, 2);
			}
			else
			{
				return LuaDLL.luaL_throw(L, "The event 'EventTriggerListener.onPointerClick' can only appear on the left hand side of += or -= when used outside of the type 'EventTriggerListener'");
			}

			if (arg0.op == EventOp.Add)
			{
				EventTriggerListener.PointerEventDelegate ev = (EventTriggerListener.PointerEventDelegate)arg0.func;
				obj.onPointerClick += ev;
			}
			else if (arg0.op == EventOp.Sub)
			{
				EventTriggerListener.PointerEventDelegate ev = (EventTriggerListener.PointerEventDelegate)arg0.func;
				obj.onPointerClick -= ev;
			}

			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onPointerDown(IntPtr L)
	{
		try
		{
			EventTriggerListener obj = (EventTriggerListener)ToLua.CheckObject(L, 1, typeof(EventTriggerListener));
			EventObject arg0 = null;

			if (LuaDLL.lua_isuserdata(L, 2) != 0)
			{
				arg0 = (EventObject)ToLua.ToObject(L, 2);
			}
			else
			{
				return LuaDLL.luaL_throw(L, "The event 'EventTriggerListener.onPointerDown' can only appear on the left hand side of += or -= when used outside of the type 'EventTriggerListener'");
			}

			if (arg0.op == EventOp.Add)
			{
				EventTriggerListener.PointerEventDelegate ev = (EventTriggerListener.PointerEventDelegate)arg0.func;
				obj.onPointerDown += ev;
			}
			else if (arg0.op == EventOp.Sub)
			{
				EventTriggerListener.PointerEventDelegate ev = (EventTriggerListener.PointerEventDelegate)arg0.func;
				obj.onPointerDown -= ev;
			}

			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onPointerEnter(IntPtr L)
	{
		try
		{
			EventTriggerListener obj = (EventTriggerListener)ToLua.CheckObject(L, 1, typeof(EventTriggerListener));
			EventObject arg0 = null;

			if (LuaDLL.lua_isuserdata(L, 2) != 0)
			{
				arg0 = (EventObject)ToLua.ToObject(L, 2);
			}
			else
			{
				return LuaDLL.luaL_throw(L, "The event 'EventTriggerListener.onPointerEnter' can only appear on the left hand side of += or -= when used outside of the type 'EventTriggerListener'");
			}

			if (arg0.op == EventOp.Add)
			{
				EventTriggerListener.PointerEventDelegate ev = (EventTriggerListener.PointerEventDelegate)arg0.func;
				obj.onPointerEnter += ev;
			}
			else if (arg0.op == EventOp.Sub)
			{
				EventTriggerListener.PointerEventDelegate ev = (EventTriggerListener.PointerEventDelegate)arg0.func;
				obj.onPointerEnter -= ev;
			}

			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onPointerExit(IntPtr L)
	{
		try
		{
			EventTriggerListener obj = (EventTriggerListener)ToLua.CheckObject(L, 1, typeof(EventTriggerListener));
			EventObject arg0 = null;

			if (LuaDLL.lua_isuserdata(L, 2) != 0)
			{
				arg0 = (EventObject)ToLua.ToObject(L, 2);
			}
			else
			{
				return LuaDLL.luaL_throw(L, "The event 'EventTriggerListener.onPointerExit' can only appear on the left hand side of += or -= when used outside of the type 'EventTriggerListener'");
			}

			if (arg0.op == EventOp.Add)
			{
				EventTriggerListener.PointerEventDelegate ev = (EventTriggerListener.PointerEventDelegate)arg0.func;
				obj.onPointerExit += ev;
			}
			else if (arg0.op == EventOp.Sub)
			{
				EventTriggerListener.PointerEventDelegate ev = (EventTriggerListener.PointerEventDelegate)arg0.func;
				obj.onPointerExit -= ev;
			}

			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onPointerUp(IntPtr L)
	{
		try
		{
			EventTriggerListener obj = (EventTriggerListener)ToLua.CheckObject(L, 1, typeof(EventTriggerListener));
			EventObject arg0 = null;

			if (LuaDLL.lua_isuserdata(L, 2) != 0)
			{
				arg0 = (EventObject)ToLua.ToObject(L, 2);
			}
			else
			{
				return LuaDLL.luaL_throw(L, "The event 'EventTriggerListener.onPointerUp' can only appear on the left hand side of += or -= when used outside of the type 'EventTriggerListener'");
			}

			if (arg0.op == EventOp.Add)
			{
				EventTriggerListener.PointerEventDelegate ev = (EventTriggerListener.PointerEventDelegate)arg0.func;
				obj.onPointerUp += ev;
			}
			else if (arg0.op == EventOp.Sub)
			{
				EventTriggerListener.PointerEventDelegate ev = (EventTriggerListener.PointerEventDelegate)arg0.func;
				obj.onPointerUp -= ev;
			}

			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onScroll(IntPtr L)
	{
		try
		{
			EventTriggerListener obj = (EventTriggerListener)ToLua.CheckObject(L, 1, typeof(EventTriggerListener));
			EventObject arg0 = null;

			if (LuaDLL.lua_isuserdata(L, 2) != 0)
			{
				arg0 = (EventObject)ToLua.ToObject(L, 2);
			}
			else
			{
				return LuaDLL.luaL_throw(L, "The event 'EventTriggerListener.onScroll' can only appear on the left hand side of += or -= when used outside of the type 'EventTriggerListener'");
			}

			if (arg0.op == EventOp.Add)
			{
				EventTriggerListener.PointerEventDelegate ev = (EventTriggerListener.PointerEventDelegate)arg0.func;
				obj.onScroll += ev;
			}
			else if (arg0.op == EventOp.Sub)
			{
				EventTriggerListener.PointerEventDelegate ev = (EventTriggerListener.PointerEventDelegate)arg0.func;
				obj.onScroll -= ev;
			}

			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onCancel(IntPtr L)
	{
		try
		{
			EventTriggerListener obj = (EventTriggerListener)ToLua.CheckObject(L, 1, typeof(EventTriggerListener));
			EventObject arg0 = null;

			if (LuaDLL.lua_isuserdata(L, 2) != 0)
			{
				arg0 = (EventObject)ToLua.ToObject(L, 2);
			}
			else
			{
				return LuaDLL.luaL_throw(L, "The event 'EventTriggerListener.onCancel' can only appear on the left hand side of += or -= when used outside of the type 'EventTriggerListener'");
			}

			if (arg0.op == EventOp.Add)
			{
				EventTriggerListener.BaseEventDelegate ev = (EventTriggerListener.BaseEventDelegate)arg0.func;
				obj.onCancel += ev;
			}
			else if (arg0.op == EventOp.Sub)
			{
				EventTriggerListener.BaseEventDelegate ev = (EventTriggerListener.BaseEventDelegate)arg0.func;
				obj.onCancel -= ev;
			}

			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onDeselect(IntPtr L)
	{
		try
		{
			EventTriggerListener obj = (EventTriggerListener)ToLua.CheckObject(L, 1, typeof(EventTriggerListener));
			EventObject arg0 = null;

			if (LuaDLL.lua_isuserdata(L, 2) != 0)
			{
				arg0 = (EventObject)ToLua.ToObject(L, 2);
			}
			else
			{
				return LuaDLL.luaL_throw(L, "The event 'EventTriggerListener.onDeselect' can only appear on the left hand side of += or -= when used outside of the type 'EventTriggerListener'");
			}

			if (arg0.op == EventOp.Add)
			{
				EventTriggerListener.BaseEventDelegate ev = (EventTriggerListener.BaseEventDelegate)arg0.func;
				obj.onDeselect += ev;
			}
			else if (arg0.op == EventOp.Sub)
			{
				EventTriggerListener.BaseEventDelegate ev = (EventTriggerListener.BaseEventDelegate)arg0.func;
				obj.onDeselect -= ev;
			}

			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onSelect(IntPtr L)
	{
		try
		{
			EventTriggerListener obj = (EventTriggerListener)ToLua.CheckObject(L, 1, typeof(EventTriggerListener));
			EventObject arg0 = null;

			if (LuaDLL.lua_isuserdata(L, 2) != 0)
			{
				arg0 = (EventObject)ToLua.ToObject(L, 2);
			}
			else
			{
				return LuaDLL.luaL_throw(L, "The event 'EventTriggerListener.onSelect' can only appear on the left hand side of += or -= when used outside of the type 'EventTriggerListener'");
			}

			if (arg0.op == EventOp.Add)
			{
				EventTriggerListener.BaseEventDelegate ev = (EventTriggerListener.BaseEventDelegate)arg0.func;
				obj.onSelect += ev;
			}
			else if (arg0.op == EventOp.Sub)
			{
				EventTriggerListener.BaseEventDelegate ev = (EventTriggerListener.BaseEventDelegate)arg0.func;
				obj.onSelect -= ev;
			}

			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onSubmit(IntPtr L)
	{
		try
		{
			EventTriggerListener obj = (EventTriggerListener)ToLua.CheckObject(L, 1, typeof(EventTriggerListener));
			EventObject arg0 = null;

			if (LuaDLL.lua_isuserdata(L, 2) != 0)
			{
				arg0 = (EventObject)ToLua.ToObject(L, 2);
			}
			else
			{
				return LuaDLL.luaL_throw(L, "The event 'EventTriggerListener.onSubmit' can only appear on the left hand side of += or -= when used outside of the type 'EventTriggerListener'");
			}

			if (arg0.op == EventOp.Add)
			{
				EventTriggerListener.BaseEventDelegate ev = (EventTriggerListener.BaseEventDelegate)arg0.func;
				obj.onSubmit += ev;
			}
			else if (arg0.op == EventOp.Sub)
			{
				EventTriggerListener.BaseEventDelegate ev = (EventTriggerListener.BaseEventDelegate)arg0.func;
				obj.onSubmit -= ev;
			}

			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onUpdateSelected(IntPtr L)
	{
		try
		{
			EventTriggerListener obj = (EventTriggerListener)ToLua.CheckObject(L, 1, typeof(EventTriggerListener));
			EventObject arg0 = null;

			if (LuaDLL.lua_isuserdata(L, 2) != 0)
			{
				arg0 = (EventObject)ToLua.ToObject(L, 2);
			}
			else
			{
				return LuaDLL.luaL_throw(L, "The event 'EventTriggerListener.onUpdateSelected' can only appear on the left hand side of += or -= when used outside of the type 'EventTriggerListener'");
			}

			if (arg0.op == EventOp.Add)
			{
				EventTriggerListener.BaseEventDelegate ev = (EventTriggerListener.BaseEventDelegate)arg0.func;
				obj.onUpdateSelected += ev;
			}
			else if (arg0.op == EventOp.Sub)
			{
				EventTriggerListener.BaseEventDelegate ev = (EventTriggerListener.BaseEventDelegate)arg0.func;
				obj.onUpdateSelected -= ev;
			}

			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onMove(IntPtr L)
	{
		try
		{
			EventTriggerListener obj = (EventTriggerListener)ToLua.CheckObject(L, 1, typeof(EventTriggerListener));
			EventObject arg0 = null;

			if (LuaDLL.lua_isuserdata(L, 2) != 0)
			{
				arg0 = (EventObject)ToLua.ToObject(L, 2);
			}
			else
			{
				return LuaDLL.luaL_throw(L, "The event 'EventTriggerListener.onMove' can only appear on the left hand side of += or -= when used outside of the type 'EventTriggerListener'");
			}

			if (arg0.op == EventOp.Add)
			{
				EventTriggerListener.AxisEventDelegate ev = (EventTriggerListener.AxisEventDelegate)arg0.func;
				obj.onMove += ev;
			}
			else if (arg0.op == EventOp.Sub)
			{
				EventTriggerListener.AxisEventDelegate ev = (EventTriggerListener.AxisEventDelegate)arg0.func;
				obj.onMove -= ev;
			}

			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int EventTriggerListener_AxisEventDelegate(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);

			if (count == 1)
			{
				Delegate arg1 = DelegateTraits<EventTriggerListener.AxisEventDelegate>.Create(func);
				ToLua.Push(L, arg1);
			}
			else
			{
				LuaTable self = ToLua.CheckLuaTable(L, 2);
				Delegate arg1 = DelegateTraits<EventTriggerListener.AxisEventDelegate>.Create(func, self);
				ToLua.Push(L, arg1);
			}
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int EventTriggerListener_BaseEventDelegate(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);

			if (count == 1)
			{
				Delegate arg1 = DelegateTraits<EventTriggerListener.BaseEventDelegate>.Create(func);
				ToLua.Push(L, arg1);
			}
			else
			{
				LuaTable self = ToLua.CheckLuaTable(L, 2);
				Delegate arg1 = DelegateTraits<EventTriggerListener.BaseEventDelegate>.Create(func, self);
				ToLua.Push(L, arg1);
			}
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int EventTriggerListener_PointerEventDelegate(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);

			if (count == 1)
			{
				Delegate arg1 = DelegateTraits<EventTriggerListener.PointerEventDelegate>.Create(func);
				ToLua.Push(L, arg1);
			}
			else
			{
				LuaTable self = ToLua.CheckLuaTable(L, 2);
				Delegate arg1 = DelegateTraits<EventTriggerListener.PointerEventDelegate>.Create(func, self);
				ToLua.Push(L, arg1);
			}
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

