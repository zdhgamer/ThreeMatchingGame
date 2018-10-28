using UnityEngine;
using System.Collections;

public class NotiConst
{
    /// <summary>
    ///启动框架
    /// </summary>
    public const string START_UP = "StartUp";
    /// <summary>
    /// 派发网络信息
    /// </summary>
    public const string DISPATCH_MESSAGE = "DispatchMessage";    

    /// <summary>
    /// 更新解包进度
    /// </summary>
    public const string UPDATE_EXTRACT_PROGRESS = "UpdateExtractMessage";
    /// <summary>
    /// 开始解包 
    /// </summary>
    public const string START_EXTRACT = "StartExtract";
    /// <summary>
    /// 开始下载更新
    /// </summary>
    public const string START_DOWNLOAD = "StartDownload";
    /// <summary>
    /// 下载更新文件 facede内部通知使用
    /// </summary>
    public const string UPDATE_DOWNLOAD = "UpdateDownload";
    /// <summary>
    /// 更新下载进度
    /// </summary>
    public const string UPDATE_DOWNLOAD_PROGRESS = "UpdateDownloadProgress";
    /// <summary>
    /// 更新下载的网速
    /// </summary>
    public const string UPDATE_DOWNLOAD_KBPERS = "UpdateDownloadKbpers";
    /// <summary>
    /// 更新下载完成
    /// </summary>
    public const string UPDATE_DOWNLOAD_FINISH = "UpdateDownloadFinish";

}
