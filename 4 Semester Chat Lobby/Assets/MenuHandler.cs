using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuHandler : MonoBehaviour
{
    public static MenuHandler instance;

    public List<GameObject> menus = new List<GameObject>();

    void Awake ()
    {
        if (instance == null) instance = this; else Destroy (this);

        Set_Menu (0);
    }

    public void Set_Menu (int choice)
    {
        for (int m = 0; m < menus.Count; m++) {
            if (choice >= 0 && choice < menus.Count) {
                bool isCur = choice == m ? true : false;
                menus[m].SetActive (isCur);
            }
        }

        // TODO SFX
    }

}
