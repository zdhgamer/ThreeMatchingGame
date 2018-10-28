local transform;
local gameObject;

PromptPanel = {};
local this = PromptPanel;

--启动事件--
function PromptPanel.Awake(obj)
	gameObject = obj;
	transform = obj.transform;
	this.InitPanel();
	logWarn("Awake lua--->>"..gameObject.name);
end

--初始化面板--
function PromptPanel.InitPanel()
	this.btnOpen = transform:Find("Open").gameObject;
	this.gridParent = transform:Find('ScrollView/Grid');
	this.btnListener = EventTriggerListener.GetListener(this.btnOpen);
	this.btnListener.onPointerClick = this.btnListener.onPointerClick + PromptPanel.OnBtnOpenClick;
end

--单击事件--
function PromptPanel.OnDestroy()
	logWarn("OnDestroy---->>>");
end

---@param go UnityEngine.GameObject
function PromptPanel.OnBtnOpenClick(go,eventData)
	log(go.name);
	log(eventData:ToString())
end