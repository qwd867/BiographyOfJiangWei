using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ģ�ͻ���
/// </summary>
public class BaseModel
{
    public BaseController controller;
    public BaseModel(BaseController ctl)
    {
        this.controller = ctl;
    }

    public virtual void Init()
    { 
        
    }
}
