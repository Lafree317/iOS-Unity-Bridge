using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;
public class BridgeManager : MonoBehaviour
{
    public GameObject cube;
    public Text bridgeMessage;
    [DllImport("__Internal")]
    private static extern void unityToIOS (string str);

    // 导入OC文件
    [DllImport("__Internal")]
    static extern void outputAppendString (string str1, string str2);

    // 按钮点击后切换到iOS界面发送一个字符串
    public void ButtonClickJumpToiOS()
    {
        #if UNITY_IPHONE  
        unityToIOS("Hello iOS");
        #endif
    } 

    public void ButtonClickCalliOS()
    {
        #if UNITY_IPHONE    
        outputAppendString("Hello", "World");
        #endif
    }

        // 向右转函数接口
    void turnRight(string num){
        Vector3 r = new Vector3 (cube.transform.rotation.x, cube.transform.rotation.y - 10f, cube.transform.rotation.z);
        cube.transform.Rotate (r);
    }
    // 向左转函数接口
    void turnLeft(string num){
        Vector3 r = new Vector3 (cube.transform.rotation.x, cube.transform.rotation.y + 10f, cube.transform.rotation.z);
        cube.transform.Rotate (r);
    }
}
