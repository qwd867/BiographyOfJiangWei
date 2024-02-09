using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//����mono�Ľű�  ��Ҫ������Ϸ����
public class GameSence : MonoBehaviour
{
    public Texture2D mouseTxt;//���ͼƬ
    float dt;

    private void Awake()
    {
        GameApp.Instance.Init();
    }

    // Start is called before the first frame update
    void Start()
    {
        //���������ʽ????????????
        Cursor.SetCursor(mouseTxt, Vector2.zero, CursorMode.Auto);
        //���ű�������
        GameApp.SoundManager.PlayBGM("Hiiro_SadWater");
    }

    // Update is called once per frame
    void Update()
    {
        dt = Time.deltaTime;
        GameApp.Instance.Update(dt);
    }
}
