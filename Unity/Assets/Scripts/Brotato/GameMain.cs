using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class GameMain : MonoBehaviour
{
    public Button btn;

    // Start is called before the first frame update
    void Start()
    {
        btn = FindObjectOfType<Button>();
        btn.onClick.AddListener(Enter);
    }

    private void Enter()
    {
        Debug.Log("点击");
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("开始");
        }
    }
    [Button]
    void Test()
    {
        Debug.Log("dwad");
    }
}