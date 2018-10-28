using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class EventTriggerListener : EventTrigger {
    /// <summary>
    /// 指针委托
    /// </summary>
    /// <param name="go"></param>
    /// <param name="eventData"></param>
    public delegate void PointerEventDelegate(GameObject go, PointerEventData eventData);
    /// <summary>
    /// 基础委托
    /// </summary>
    /// <param name="go"></param>
    /// <param name="eventData"></param>
    public delegate void BaseEventDelegate(GameObject go, BaseEventData eventData);
    /// <summary>
    /// 坐标轴委托
    /// </summary>
    /// <param name="go"></param>
    /// <param name="eventData"></param>
    public delegate void AxisEventDelegate(GameObject go, AxisEventData eventData);

    /// <summary>
    /// 开始拖拽
    /// </summary>
    public event PointerEventDelegate onBeginDrag;

    /// <summary>
    /// 拖拽中事件
    /// </summary>
    public event PointerEventDelegate onDrag;

    /// <summary>
    /// 放下事件
    /// </summary>
    public event PointerEventDelegate onDrop;

    /// <summary>
    /// 拖拽结束事件
    /// </summary>
    public event PointerEventDelegate onEndDrag;

    /// <summary>
    /// 初始化拖拽
    /// </summary>
    public event PointerEventDelegate onInitializePotentialDrag;

    /// <summary>
    /// 点击事件
    /// </summary>
    public event PointerEventDelegate onPointerClick;

    /// <summary>
    /// 按下事件
    /// </summary>
    public event PointerEventDelegate onPointerDown;

    /// <summary>
    /// 进入事件 
    /// </summary>
    public event PointerEventDelegate onPointerEnter;

    /// <summary>
    /// 退出事件
    /// </summary>
    public event PointerEventDelegate onPointerExit;

    /// <summary>
    /// 手指抬起事件
    /// </summary>
    public event PointerEventDelegate onPointerUp;

    /// <summary>
    /// 滚动事件
    /// </summary>
    public event PointerEventDelegate onScroll;

    /// <summary>
    /// 取消事件
    /// </summary>
    public event BaseEventDelegate onCancel;

    /// <summary>
    /// 反选事件
    /// </summary>
    public event BaseEventDelegate onDeselect;

    /// <summary>
    /// 选择事件
    /// </summary>
    public event BaseEventDelegate onSelect;

    /// <summary>
    /// 提交事件
    /// </summary>
    public event BaseEventDelegate onSubmit;

    /// <summary>
    /// 更新选择
    /// </summary>
    public event BaseEventDelegate onUpdateSelected;

    /// <summary>
    /// 移动事件
    /// </summary>
    public event AxisEventDelegate onMove;

    /// <summary>
    /// 获取一个事件监听
    /// </summary>
    /// <param name="go"></param>
    /// <returns></returns>
    public static EventTriggerListener GetListener(GameObject go) {
        EventTriggerListener listener = go.GetComponent<EventTriggerListener>();
        if (listener == null) {
            listener = go.AddComponent<EventTriggerListener>();
        }
        return listener;
    }

    /// <summary>
    /// 开始拖拽
    /// </summary>
    /// <param name="eventData"></param>
    public override void OnBeginDrag(PointerEventData eventData)
    {
        base.OnBeginDrag(eventData);
        if (onBeginDrag!=null) {
            onBeginDrag(gameObject, eventData);
        }
    }
    
    /// <summary>
    /// 拖拽中
    /// </summary>
    /// <param name="eventData"></param>
    public override void OnDrag(PointerEventData eventData)
    {
        base.OnDrag(eventData);
        if (onDrag!=null) {
            onDrag(gameObject, eventData);
        }
    }

    /// <summary>
    /// 当放下的时候
    /// </summary>
    /// <param name="eventData"></param>
    public override void OnDrop(PointerEventData eventData)
    {
        base.OnDrop(eventData);
        if (onDrop!=null) {
            onDrop(gameObject,eventData);
        }
    }

    /// <summary>
    /// 拖拽结束
    /// </summary>
    /// <param name="eventData"></param>
    public override void OnEndDrag(PointerEventData eventData)
    {
        base.OnEndDrag(eventData);
        if (onEndDrag!=null) {
            onEndDrag(gameObject, eventData);
        }
    }

    /// <summary>
    /// 初始化拖拽
    /// </summary>
    /// <param name="eventData"></param>
    public override void OnInitializePotentialDrag(PointerEventData eventData)
    {
        base.OnInitializePotentialDrag(eventData);
        if (onInitializePotentialDrag!=null) {
            onInitializePotentialDrag(gameObject, eventData);
        }
    }

    /// <summary>
    /// 点击事件
    /// </summary>
    /// <param name="eventData"></param>
    public override void OnPointerClick(PointerEventData eventData)
    {
        base.OnPointerClick(eventData);
        if (onPointerClick!=null) {
            onPointerClick(gameObject, eventData);
        }
    }

    /// <summary>
    /// 按下事件
    /// </summary>
    /// <param name="eventData"></param>
    public override void OnPointerDown(PointerEventData eventData)
    {
        base.OnPointerDown(eventData);
        if (onPointerDown!=null) {
            onPointerDown(gameObject, eventData);
        }
    }

    /// <summary>
    /// 手指和指针进入事件
    /// </summary>
    /// <param name="eventData"></param>
    public override void OnPointerEnter(PointerEventData eventData)
    {
        base.OnPointerEnter(eventData);
        if (onPointerEnter!=null) {
            onPointerEnter(gameObject, eventData);
        }
    }

    /// <summary>
    /// 退出事件
    /// </summary>
    /// <param name="eventData"></param>
    public override void OnPointerExit(PointerEventData eventData)
    {
        base.OnPointerExit(eventData);
        if (onPointerExit!=null) {
            onPointerExit(gameObject,eventData);
        }
    }

    /// <summary>
    /// 手指抬起事件
    /// </summary>
    /// <param name="eventData"></param>
    public override void OnPointerUp(PointerEventData eventData)
    {
        base.OnPointerUp(eventData);
        if (onPointerUp!=null) {
            onPointerUp(gameObject, eventData);
        }
    }

    /// <summary>
    /// 滚动
    /// </summary>
    /// <param name="eventData"></param>
    public override void OnScroll(PointerEventData eventData)
    {
        base.OnScroll(eventData);
        if (onScroll!=null) {
            onScroll(gameObject, eventData);
        }

    }

    /// <summary>
    /// 取消
    /// </summary>
    /// <param name="eventData"></param>
    public override void OnCancel(BaseEventData eventData)
    {
        base.OnCancel(eventData);
        if (onCancel!=null) {
            onCancel(gameObject, eventData);
        }
    }

    /// <summary>
    /// 反选
    /// </summary>
    /// <param name="eventData"></param>
    public override void OnDeselect(BaseEventData eventData)
    {
        base.OnDeselect(eventData);
        if (onDeselect!=null) {
            onDeselect(gameObject, eventData);
        }
    }

    /// <summary>
    /// 选择事件
    /// </summary>
    /// <param name="eventData"></param>
    public override void OnSelect(BaseEventData eventData)
    {
        base.OnSelect(eventData);
        if (onSelect!=null) {
            onSelect(gameObject, eventData);
        }
    }

    /// <summary>
    /// 提交事件
    /// </summary>
    /// <param name="eventData"></param>
    public override void OnSubmit(BaseEventData eventData)
    {
        base.OnSubmit(eventData);
        if (onSubmit!=null) {
            onSubmit(gameObject, eventData);
        }
    }

    /// <summary>
    /// 更新选择事件
    /// </summary>
    /// <param name="eventData"></param>
    public override void OnUpdateSelected(BaseEventData eventData)
    {
        base.OnUpdateSelected(eventData);
        if (onUpdateSelected!=null) {
            onUpdateSelected(gameObject, eventData);
        }
    }

    /// <summary>
    /// 移动事件
    /// </summary>
    /// <param name="eventData"></param>
    public override void OnMove(AxisEventData eventData)
    {
        base.OnMove(eventData);
        if (onMove!=null) {
            onMove(gameObject, eventData);
        }
    }

}
