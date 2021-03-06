---
--- Generated by EmmyLua(https://github.com/EmmyLua)
--- Created by zdh.
--- DateTime: 2018/10/29 23:30
---

require("EventDispatcher")
require('Common/eventids')

GameOverCtrl = {};
local this = GameOverCtrl;

local panel;
---@type UnityEngine.Transform
local transform;
---@type UnityEngine.GameObject
local gameObject;

--构建函数--
function GameOverCtrl.New()
    logWarn("GameOverCtrl.New--->>");
    return this;
end

function GameOverCtrl.Awake()
    logWarn("GameOverCtrl.Awake--->>");
    EventDispatcher:AddEventListener(EventIds.ShowScore, function(score)
        GameOverCtrl.GetScore(score)
    end)
    panelMgr:CreatePanel('GameOver', this.OnCreate);
end

--启动事件--
function GameOverCtrl.OnCreate(obj)
    gameObject = obj;
    transform = gameObject.transform;
    panel = gameObject:GetComponent('LuaBehaviour');
    this.backBtnListener = EventTriggerListener.GetListener(GameOverPanel.backBtn.gameObject);
    this.backBtnListener.onPointerClick = this.backBtnListener.onPointerClick + GameOverCtrl.OnBackBtnClick
end

---@param go UnityEngine.GameObject
function GameOverCtrl.OnBackBtnClick(go, eventData)
    log('点击返回按钮')
    local ctrl = CtrlManager.GetCtrl(CtrlNames.Start);
    if ctrl ~= nil then
        ctrl:Awake();
    end
    coroutine.stop(this.LastTimeShow)
    EventDispatcher:Dispatcher(EventIds.BackStart)
    EventDispatcher:RemoveEventListeners(EventIds.GetScore)
    EventDispatcher:RemoveEventListeners(EventIds.GameOver)
    EventDispatcher:RemoveEventListeners(EventIds.ShowScore)
    panelMgr:ClosePanel('Game')
    panelMgr:ClosePanel('GameOver')
end

function GameOverCtrl.GetScore(score)
    GameOverPanel.scoreText.text = score .. ''
end

