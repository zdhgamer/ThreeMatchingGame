using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdatePanel : MonoBehaviour {

    /// <summary>
    /// 进度条
    /// </summary>
    private Slider progressSlider;
    /// <summary>
    /// 进度显示文字
    /// </summary>
    private Text progressText;
    /// <summary>
    /// 下载的网速显示
    /// </summary>
    private Text downloadKbs;
    /// <summary>
    /// 进度前缀
    /// </summary>
    private string preText = "解包中：";

    private void Awake()
    {
        progressSlider = gameObject.GetComponentInChildren<Slider>();
        if (progressSlider!=null) {
            progressText = progressSlider.transform.Find("Progress_Text").GetComponent<Text>();
            downloadKbs = progressSlider.transform.Find("Kbs_Text").GetComponent<Text>();
            progressText.text = preText + "0" + "%";
            downloadKbs.text = "0 kb/s";
            downloadKbs.gameObject.SetActive(false);
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    /// <summary>
    /// 开始解包
    /// </summary>
    public void SetStartExtractResource() {
        preText = "解包中：";
        progressText.text = preText + "0" + "%";
        downloadKbs.gameObject.SetActive(false);
    }

    /// <summary>
    /// 开始下载更新
    /// </summary>
    public void SetStartUpdateResource()
    {
        preText = "更新中：";
        progressText.text = preText + "0" + "%";
        downloadKbs.gameObject.SetActive(true);
        downloadKbs.text = "0 kb/s";
    }

    /// <summary>
    /// 更新解包进度
    /// </summary>
    /// <param name="progress"></param>
    public void UpdateExtractProgress(float progress) {
        progressSlider.value = progress;
        progressText.text = preText + (int)(progress * 100) + "%";
    }

    /// <summary>
    ///  更新下载进度
    /// </summary>
    /// <param name="progress"></param>
    public void UpdateDownloadProgress(float progress) {
        progressSlider.value = progress;
        progressText.text = preText + (int)(progress * 100) + "%";
    }

    /// <summary>
    /// 更新下载的网速
    /// </summary>
    /// <param name="value"></param>
    public void UpdateDownloadKbs(string value) {
        downloadKbs.gameObject.SetActive(true);
        downloadKbs.text = value;
    }

    /// <summary>
    /// 更新完成
    /// </summary>
    public void UpdateDownloadFinish() {
        preText = "已是最新版本";
        progressText.text = preText;
        downloadKbs.gameObject.SetActive(false);
    }

}
