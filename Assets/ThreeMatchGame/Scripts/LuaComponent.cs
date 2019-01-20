using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LuaFramework;
using LuaInterface;

public class LuaComponent : MonoBehaviour {

    private LuaTable luaTable;

    private string componentName;

    public string ComponentName
    {
        get
        {
            return componentName;
        }

        set
        {
            componentName = value;
        }
    }

    public static LuaComponent AddLuaComponent(GameObject go,LuaTable luaTable) {
        LuaComponent component = go.AddComponent<LuaComponent>();
        component.ComponentName = luaTable["componentName"] as string;
        component.SetLuaTable(luaTable);
        component.CallAwake();
        return component;
    }

    public void SetLuaTable(LuaTable luaTable) {
        this.luaTable = luaTable;
    }

    public void CallAwake() {
        if (luaTable != null)
        {
            luaTable.Call("Awake",luaTable);
        }
    }

    private void Awake()
    {
        if (luaTable!=null) {
            luaTable.Call("Awake", luaTable);
        }
    }

    private void OnEnable()
    {
        if (luaTable != null)
        {
            luaTable.Call("OnEnable",luaTable);
        }
    }

    // Use this for initialization
    void Start () {
        if (luaTable != null)
        {
            luaTable.Call("Start", luaTable);
        }
    }

    private void OnBecameInvisible()
    {
        if (luaTable != null)
        {
            luaTable.Call("OnBecameInvisible", luaTable);
        }
    }

    private void OnBecameVisible()
    {
        if (luaTable != null)
        {
            luaTable.Call("OnBecameVisible",luaTable);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (luaTable != null)
        {
            luaTable.Call("OnCollisionEnter", luaTable, collision);
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (luaTable != null)
        {
            luaTable.Call("OnCollisionStay", luaTable,collision);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (luaTable != null)
        {
            luaTable.Call("OnCollisionExit", luaTable,collision);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (luaTable != null)
        {
            luaTable.Call("OnCollisionEnter2D", luaTable, collision);
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (luaTable != null)
        {
            luaTable.Call("OnCollisionStay2D", luaTable, collision);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (luaTable != null)
        {
            luaTable.Call("OnCollisionExit2D", luaTable,collision);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (luaTable != null)
        {
            luaTable.Call("OnTriggerEnter", luaTable,other);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (luaTable != null)
        {
            luaTable.Call("OnTriggerStay", luaTable, other);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (luaTable != null)
        {
            luaTable.Call("OnTriggerExit", luaTable,other);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (luaTable != null)
        {
            luaTable.Call("OnTriggerEnter2D", luaTable, collision);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (luaTable != null)
        {
            luaTable.Call("OnTriggerStay2D", luaTable, collision);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (luaTable != null)
        {
            luaTable.Call("OnTriggerExit2D", luaTable, collision);
        }
    }

    private void OnLevelWasLoaded(int level)
    {
        if (luaTable != null)
        {
            luaTable.Call("OnLevelWasLoaded", luaTable, level);
        }
    }

    private void OnApplicationFocus(bool focus)
    {
        if (luaTable != null)
        {
            luaTable.Call("OnApplicationFocus", luaTable, focus);
        }
    }

    private void OnApplicationQuit()
    {
        if (luaTable != null)
        {
            luaTable.Call("OnApplicationQuit", luaTable);
        }
    }

    private void OnDestroy()
    {
        if (luaTable != null)
        {
            luaTable.Call("OnDestroy",luaTable);
        }
        luaTable.Dispose();
        luaTable = null;
    }

    private void OnDisable()
    {
        if (luaTable != null)
        {
            luaTable.Call("OnDisable", luaTable);
        }
    }

}
