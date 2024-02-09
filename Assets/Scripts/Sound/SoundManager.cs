using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ����������
/// </summary>
public class SoundManager
{
    public AudioSource bgmSource;//���ŵ�bgm��Ƶ���

    private Dictionary<string, AudioClip> clips;//��Ƶ�����ֵ�

    public SoundManager()
    {
        bgmSource = GameObject.Find("Game").GetComponent<AudioSource>();
    }

    //����bgm
    public void PlayBGM(string res)
    {
        //û�е�ǰ��Ƶ
        if (clips.ContainsKey(res) == false)
        {
            //������Ƶ
            AudioClip clip = Resources.Load<AudioClip>($"Sounds/{res}");
            clips.Add(res, clip);
        }
        bgmSource.clip = clips[res];
        bgmSource.Play();//����
    }
}
