﻿using UnityEngine;
using System.Collections;

public class ManageCreator : MonoBehaviour {

    //Awakeより前に自動でマネージャーを作成する
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void CreatorManager()
    {
#if UNITY_EDITOR
        Screen.SetResolution(450, 800, false, 60);
#elif UNITY_ANDROID
        Screen.fullScreen = true;
#endif

        //Cursor.visible = false;
        GameObject ManagerObj = new GameObject("Manager", typeof(DataManager),typeof(InputManager));
        DontDestroyOnLoad(ManagerObj);
    }
}
