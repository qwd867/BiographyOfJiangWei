using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ͳһ������Ϸ�еĹ��������ٴ�����г�ʼ��
/// </summary>
public class GameApp : Singleton<GameApp>
{
    public static SoundManager SoundManager; //��Ƶ����������

    public static ControllerManager ControllerManager;//������������

    public override void Init()
    {
        SoundManager = new SoundManager();
        ControllerManager = new ControllerManager();
    }
}
