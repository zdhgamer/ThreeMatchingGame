using UnityEngine;
using LuaFramework;
using System.Collections.Generic;
using System.IO;

public class AppView : View {

    /// <summary>
    /// 更新和解包的消息
    /// </summary>
    private string message;

    /// <summary>
    /// AssetBundleManifest
    /// </summary>
    private AssetBundleManifest manifest;

    /// <summary>
    /// 更新显示的对象
    /// </summary>
    private GameObject updatePanelGo;
    /// <summary>
    /// 更新显示的脚本
    /// </summary>
    private UpdatePanel updatePanel;

    /// <summary>
    /// 界面的父对象
    /// </summary>
    private Transform parent;

    /// <summary>
    /// 界面的父对象
    /// </summary>
    Transform Parent
    {
        get
        {
            if (parent == null)
            {
                GameObject go = GameObject.FindWithTag("GuiCamera");
                if (go != null) parent = go.transform.parent;
            }
            return parent;
        }
    }

    ///<summary>
    /// 监听的消息
    ///</summary>
    List<string> MessageList {
        get {
            return new List<string>()
            { 
                NotiConst.UPDATE_EXTRACT_PROGRESS,
                NotiConst.START_EXTRACT,
                NotiConst.START_DOWNLOAD,
                NotiConst.UPDATE_DOWNLOAD_KBPERS,
                NotiConst.UPDATE_DOWNLOAD_PROGRESS,
                NotiConst.UPDATE_DOWNLOAD_FINISH,
            };
        }
    }

    void Awake() {
        LoadUpdatePanel();
        RemoveMessage(this, MessageList);
        RegisterMessage(this, MessageList);
    }

    /// <summary>
    /// 处理View消息
    /// </summary>
    /// <param name="message"></param>
    public override void OnMessage(IMessage message) {
        if (updatePanel == null) {
            updatePanel = updatePanelGo.GetComponent<UpdatePanel>();
        }
        string name = message.Name;
        object body = message.Body;
        switch (name) {
            case NotiConst.UPDATE_EXTRACT_PROGRESS://更新解包进度
                updatePanel.UpdateExtractProgress((float)body);
            break;
            case NotiConst.START_EXTRACT:      //开始解包
                updatePanel.SetStartExtractResource();
            break;
            case NotiConst.START_DOWNLOAD:     //开始下载更新 文件 
                updatePanel.SetStartUpdateResource();
            break;
            case NotiConst.UPDATE_DOWNLOAD_KBPERS:     //更新下载网速
                updatePanel.UpdateDownloadKbs(body.ToString());
            break;
            case NotiConst.UPDATE_DOWNLOAD_PROGRESS://更新下载进度
                updatePanel.UpdateDownloadProgress((float)body);
                break;
            case NotiConst.UPDATE_DOWNLOAD_FINISH://更新完成
                break;
        }
    }

    public void UpdateMessage(string data) {
        this.message = data;
    }

    public void UpdateExtract(string data) {
        this.message = data;
    }

    public void UpdateDownload(string data) {
        this.message = data;
    }

    public void UpdateProgress(string data) {
        this.message = data;
    }

    /// <summary>
    ///  加载AssetBundleManifest
    /// </summary>
    /// <returns>是否加载成功</returns>
    private bool LoadAssetBundleManifest()
    {
        byte[] stream = null;
        string uri = string.Empty;
        uri = Util.DataPath + AppConst.AssetDir;
        if (!File.Exists(uri)) {
            return false;
        }
        stream = File.ReadAllBytes(uri);
        AssetBundle assetbundle = AssetBundle.LoadFromMemory(stream);
        if (assetbundle != null)
        {
            manifest = assetbundle.LoadAsset<AssetBundleManifest>("AssetBundleManifest");
            if (manifest != null)
            {
                return true;
            }
            else {
                return false;
            }
        }
        else {
            return false;
        }
    }

    /// <summary>
    /// 加载更新的显示界面
    /// </summary>
    /// <returns></returns>
    private void LoadUpdatePanel() {
        if (LoadAssetBundleManifest())
        {
            PanelManager panelManager = facade.GetManager<PanelManager>(ManagerName.Panel);
            panelManager.CreatePanel("Update");
        }
        else {
            if (Parent.Find("UpdatePanel") != null) {
                return;
            };
            GameObject go = Resources.Load<GameObject>("Builds/Panels/Update/UpdatePanel");
            updatePanelGo = Instantiate(go,parent);
            // updatePanel.transform.SetParent(Parent);
            updatePanelGo.name = "UpdatePanel";
            updatePanelGo.transform.localPosition = Vector3.zero;
            updatePanelGo.transform.localScale = Vector3.one;
            (updatePanelGo.transform as RectTransform).offsetMax = new Vector2(0, 0);
            (updatePanelGo.transform as RectTransform).offsetMin = new Vector2(0, 0);
            updatePanelGo.layer = LayerMask.NameToLayer("Default");

        }
    }

    /// <summary>
    /// 关闭更新界面
    /// </summary>
    private void DestroyUpdatePanel() {
        if (updatePanel!=null) {
            Destroy(updatePanel.gameObject);
        }
    }

    void OnGUI() {
        GUI.Label(new Rect(10, 120, 960, 50), message);

        GUI.Label(new Rect(10, 0, 500, 50), "(1) 单击 \"Lua/Gen Lua Wrap Files\"。");
        GUI.Label(new Rect(10, 20, 500, 50), "(2) 运行Unity游戏");
        GUI.Label(new Rect(10, 40, 500, 50), "PS: 清除缓存，单击\"Lua/Clear LuaBinder File + Wrap Files\"。");
        GUI.Label(new Rect(10, 60, 900, 50), "PS: 若运行到真机，请设置Const.DebugMode=false，本地调试请设置Const.DebugMode=true");
        GUI.Label(new Rect(10, 80, 500, 50), "PS: 加Unity+ulua技术讨论群：>>341746602");
    }
}
