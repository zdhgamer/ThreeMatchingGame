---
--- Generated by EmmyLua(https://github.com/EmmyLua)
--- Created by zdh.
--- DateTime: 2018/10/29 23:30
---

require("Logic/GameLogic")

GameCtrl = {};
local this = GameCtrl;

local panel;
---@type UnityEngine.Transform
local transform;
---@type UnityEngine.GameObject
local gameObject;

--构建函数--
function GameCtrl.New()
    logWarn("gameCtrl.New--->>");
    return this;
end

function GameCtrl.Awake()
    logWarn("gameCtrl.Awake--->>");
    panelMgr:CreatePanel('Game', this.OnCreate);
end

--启动事件--
function GameCtrl.OnCreate(obj)
    gameObject = obj;
    transform = gameObject.transform;
    panel = gameObject:GetComponent('LuaBehaviour');
    this.lastTime = 60
    this.backBtnListener = EventTriggerListener.GetListener(GamePanel.backBtn);
    this.backBtnListener.onPointerClick = this.backBtnListener.onPointerClick + GameCtrl.OnBackBtnClick
    coroutine.start(this.LastTimaShow);
end

--关闭事件--
function GameCtrl.Close()
    log('开始关闭游戏界面界面')
    panelMgr:ClosePanel('Start');
end


---@param go UnityEngine.GameObject
function GameCtrl.OnBackBtnClick(go,eventData)
    log('点击返回按钮')
end

--显示倒计时
function GameCtrl:LastTimaShow()
    while true do
        GamePanel.lastTimeText.text = this.lastTime .. 's'
        coroutine.wait(1.0)
        if this.lastTime <=0 then
            --todo 弹出游戏结束
            break
        end
    end
end
