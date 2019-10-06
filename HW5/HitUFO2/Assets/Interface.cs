﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//新增：运动学、物理运动接口
public interface MyActionManager
{
    void playDisk(GameObject UFO, float angle, float power, bool isPhysical);
}

public interface ISceneController
{
    //加载场景
    void LoadResources();
}

public interface IUserAction
{
    //用户点击游戏界面
    void Hit(Vector3 pos);
    //获得分数
    int GetScore();
    //游戏结束
    void GameOver();
    //游戏重新开始
    void ReStart();
    //游戏开始
    void BeginGame();
}
public enum SSActionEventType : int { Started, Competeted }
public interface ISSActionCallback
{
    void SSActionEvent(SSAction source, SSActionEventType events = SSActionEventType.Competeted,
        int intParam = 0, string strParam = null, Object objectParam = null);
}