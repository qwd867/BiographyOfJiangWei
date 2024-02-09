using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//集成mono的脚本  需要挂在游戏物体
public class GameSence : MonoBehaviour
{
    public Texture2D mouseTxt;//鼠标图片
    float dt;

    private void Awake()
    {
        GameApp.Instance.Init();
    }

    // Start is called before the first frame update
    void Start()
    {
        //设置鼠标样式????????????
        Cursor.SetCursor(mouseTxt, Vector2.zero, CursorMode.Auto);
        //播放背景音乐
        GameApp.SoundManager.PlayBGM("Hiiro_SadWater");
    }

    // Update is called once per frame
    void Update()
    {
        dt = Time.deltaTime;
        GameApp.Instance.Update(dt);
    }
}
