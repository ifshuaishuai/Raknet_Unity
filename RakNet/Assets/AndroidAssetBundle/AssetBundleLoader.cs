using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssetBundleLoader : MonoBehaviour
{
    void Start()
    {
        string path = Utils.GetBundlePathForLoadFromFile("temp/cube.assetbundle");

        var assetBundle = AssetBundle.LoadFromFile(path);

        Object obj = assetBundle.LoadAsset("cube");
        if (obj)
        {

            Object.Instantiate(obj);
        }
    }
}
