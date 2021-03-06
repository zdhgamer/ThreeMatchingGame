---
--- Generated by EmmyLua(https://github.com/EmmyLua)
--- Created by zdh.
--- DateTime: 2018/10/29 23:30
---

require("Logic/GameLogic")

StartCtrl = {};
local this = StartCtrl;

local panel;
---@type UnityEngine.Transform
local transform;
---@type UnityEngine.GameObject
local gameObject;

--构建函数--
function StartCtrl.New()
    logWarn("StartCtrl.New--->>");
    return this;
end

function StartCtrl.Awake()
    logWarn("StartCtrl.Awake--->>");
    panelMgr:CreatePanel('Start', this.OnCreate);
end

--启动事件--
function StartCtrl.OnCreate(obj)
    gameObject = obj;
    transform = gameObject.transform;
    panel = gameObject:GetComponent('LuaBehaviour');
    log(StartPanel.startBtn.name)
    log(StartPanel.exitGameBtn.name)
    this.startBtnListener = EventTriggerListener.GetListener(StartPanel.startBtn);
    this.exitBtnListener = EventTriggerListener.GetListener(StartPanel.exitGameBtn);
    this.startBtnListener.onPointerClick = this.startBtnListener.onPointerClick + this.OnStartGameBtnClick;
    this.exitBtnListener.onPointerClick = this.exitBtnListener.onPointerClick + this.OnExitGameBtnClick;
    logWarn("Start lua--->>"..gameObject.name);
end

--关闭事件--
function StartCtrl.Close()
    log('开始关闭Start界面')
    panelMgr:ClosePanel('Start');
end

--开始游戏点击--
---@param go UnityEngine.GameObject
function StartCtrl.OnStartGameBtnClick(go,eventData)
    log('开始游戏点击')
    resMgr:LoadPrefab('gameprefabs',{'GameScene'},function (objs)
        log(objs[0].name)
        this.gameScene = newObject(objs[0])
        this.gameSceneTable = GameLogic:New('GameLogic',this.gameScene);
        log(this.gameSceneTable.componentName)
        this.gameScneneComponent = LuaComponent.AddLuaComponent(this.gameScene,this.gameSceneTable)
        this:LoadGamePanel()
    end)
    this.Close()
end

--退出游戏点击--
---@param go UnityEngine.GameObject
function StartCtrl.OnExitGameBtnClick(go,eventData)
    log('OnExitGameBtnClick')
    log(go.name);
    log(eventData:ToString())
end

function StartCtrl:LoadGamePanel()
    log('加载游戏界面UI')
    local ctrl = CtrlManager.GetCtrl(CtrlNames.Game);
    if ctrl ~= nil then
        ctrl:Awake();
    end
end