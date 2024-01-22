using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterfaceManager : MonoBehaviour
{
    public GameObject GameObjectInterfaceToOpen;
    public GameObject GameObjectInterfaceToClose;

    public void OpenInterface()
    {
        GameObjectInterfaceToOpen.SetActive(true);
        GameObjectInterfaceToClose.SetActive(false);
    }

    public void CloseInterface()
    {
        GameObjectInterfaceToClose.SetActive(true);
        GameObjectInterfaceToOpen.SetActive(false);
    }
}
