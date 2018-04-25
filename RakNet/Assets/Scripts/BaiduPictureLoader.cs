using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaiduPictureLoader : MonoBehaviour
{
    private UITexture _texture;

    void Awake()
    {
        _texture = GetComponent<UITexture>();
    }

    void Start()
    {
        string path = "https://pan.baidu.com/share/qrcode";

        StartCoroutine(DoLoadPicture(path));
    }

    private IEnumerator DoLoadPicture(string path)
    {
        WWWForm form = new WWWForm();
        form.AddField("w", 150);
        form.AddField("h", 150);
        form.AddField("url", "5BV8BYDBADDA");
        form.AddField("qq-pf-to", "pcqq.group");

        WWW www = new WWW(path, form);
        yield return www;

        Debug.Log(www.error);

        _texture.mainTexture = www.texture;

        // www.Dispose();
    }
}
