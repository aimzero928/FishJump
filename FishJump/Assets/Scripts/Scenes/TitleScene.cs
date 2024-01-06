using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleScene : BaseScene
{
    protected override void Init()
    {
        base.Init();

        SceneType = Define.Scene.Title;

        Screen.SetResolution(2960, 1440, true);

        Managers.UI.ShowSceneUI<UI_TitleScene>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Managers.Scene.LoadScene(Define.Scene.Game);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
    }

    public override void Clear()
    {

    }
}
