using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComponentUtil {

    /// <summary>
    /// 获取指定脚本集合
    /// </summary>
    /// <param name="go"></param>
    /// <param name="componentName"></param>
    /// <returns></returns>
    public static List<LuaComponent> GetLuaComponents(GameObject go,string componentName) {
        LuaComponent[] luas = go.transform.GetComponents<LuaComponent>();
        List<LuaComponent> result = new List<LuaComponent>();
        if (luas!=null && luas.Length>0) {
            for (int i=0;i<luas.Length;i++) {
                if (luas[i].ComponentName.Equals(componentName)) {
                    result.Add(luas[i]);
                }
            }
        }
        return result;
    }

    /// <summary>
    /// 获取在自己身上的脚本集合
    /// </summary>
    /// <param name="go"></param>
    /// <returns></returns>
    public static LuaComponent[] GetLuaComponents(GameObject go) {
        LuaComponent[] luas = go.transform.GetComponents<LuaComponent>();
        return luas;
    }

    /// <summary>
    /// 获取在子对象身上的脚本集合
    /// </summary>
    /// <param name="go"></param>
    /// <returns></returns>
    public static LuaComponent[] GetLuaComponentsInChildren(GameObject go)
    {
        LuaComponent[] luas = go.transform.GetComponentsInChildren<LuaComponent>();
        return luas;
    }

    /// <summary>
    /// 获取在子对象身上的脚本集合
    /// </summary>
    /// <param name="go"></param>
    /// <param name="componentName"></param>
    /// <returns></returns>
    public static List<LuaComponent> GetLuaComponentsInChildren(GameObject go,string componentName)
    {
        LuaComponent[] luas = go.transform.GetComponentsInChildren<LuaComponent>();
        List<LuaComponent> result = new List<LuaComponent>();
        if (luas != null && luas.Length > 0)
        {
            for (int i = 0; i < luas.Length; i++)
            {
                if (luas[i].ComponentName.Equals(componentName))
                {
                    result.Add(luas[i]);
                }
            }
        }
        return result;
    }

    /// <summary>
    /// 获取在父对象身上的脚本集合
    /// </summary>
    /// <param name="go"></param>
    /// <returns></returns>
    public static LuaComponent[] GetLuaComponentsInParen(GameObject go)
    {
        LuaComponent[] luas = go.transform.GetComponentsInParent<LuaComponent>();
        return luas;
    }

    /// <summary>
    ///  获取在父对象身上的脚本集合
    /// </summary>
    /// <param name="go"></param>
    /// <param name="componentName"></param>
    /// <returns></returns>
    public static List<LuaComponent> GetLuaComponentsInParen(GameObject go,string componentName)
    {
        LuaComponent[] luas = go.transform.GetComponentsInParent<LuaComponent>();
        List<LuaComponent> result = new List<LuaComponent>();
        if (luas != null && luas.Length > 0)
        {
            for (int i = 0; i < luas.Length; i++)
            {
                if (luas[i].ComponentName.Equals(componentName))
                {
                    result.Add(luas[i]);
                }
            }
        }
        return result;
    }

}
