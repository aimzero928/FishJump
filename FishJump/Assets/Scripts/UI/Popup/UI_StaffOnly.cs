using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UI_StaffOnly : UI_Popup
{
    enum Buttons
    {
        CloseButton,
        NoButton,
        YesButton,
    }

    public override void Init()
    {
        base.Init();

        Bind<Button>(typeof(Buttons));

        GetButton((int)Buttons.CloseButton).gameObject.BindEvent(OnCloseButton);
    }

    public void OnCloseButton(PointerEventData data)
    {
        Managers.UI.ClosePopupUI();
    }
}
