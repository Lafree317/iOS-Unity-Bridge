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
    
    // 按钮点击后切换到iOS界面发送一个字符串
    public void ButtonClick()
    {
        unityToIOS("Hello iOS");
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
