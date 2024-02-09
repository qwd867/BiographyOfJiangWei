using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 声音管理器
/// </summary>
public class SoundManager
{
    public AudioSource bgmSource;//播放的bgm音频组件

    private Dictionary<string, AudioClip> clips;//音频缓存字典

    public SoundManager()
    {
        bgmSource = GameObject.Find("Game").GetComponent<AudioSource>();
    }

    //播放bgm
    public void PlayBGM(string res)
    {
        //没有当前音频
        if (clips.ContainsKey(res) == false)
        {
            //加载音频
            AudioClip clip = Resources.Load<AudioClip>($"Sounds/{res}");
            clips.Add(res, clip);
        }
        bgmSource.clip = clips[res];
        bgmSource.Play();//播放
    }
}
