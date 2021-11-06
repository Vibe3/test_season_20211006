using UnityEngine;    //引用Unity 引擎命名空間:可以使用此空間的API

// 單行註解
// 澄 2021
// class 類別:一個物件的藍圖
//語法:類別 類別名稱 {類別內容 (類別成員) }
//此類別要在 Unity 內使用必須繼承 MonoBehaviour
public class Car : MonoBehaviour
{
    #region
    private void Start()
    {
        Test();
        Drive80();
    }
    #endregion

    #region
    private void Test()
    {
        print("哈囉，沃德");

    }
    private void Drive80()
    {
        print("開車時速:" + 80);
    }
    #endregion
}