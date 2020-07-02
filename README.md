# Unity_UI_Button_CustomArea
 Unity 介面 按鈕 自訂感應區域

展示：https://kid421.github.io/Unity_UI_Button_CustomArea/Web

1. 要自訂感應區域的圖片要先設定

![Unity 按鈕 自訂感應區](/Tutorial1.png "Unity 按鈕 自訂感應區")

2. 添加 C# 給予按鈕

    using UnityEngine;
    using UnityEngine.UI;

    public class ButtonCustomArea : MonoBehaviour
    {
        private void Start()
        {
            GetComponent<Image>().alphaHitTestMinimumThreshold = 0.5f;
        }
    }
