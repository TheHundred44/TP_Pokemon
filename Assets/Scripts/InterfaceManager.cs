using UnityEngine;

public class InterfaceManager : MonoBehaviour
{

    public void OpenInterface(GameObject GameObjectInterfaceToOpen)
    {
        GameObjectInterfaceToOpen.SetActive(true);
    }

    public void CloseInterface(GameObject GameObjectInterfaceToClose)
    {
        GameObjectInterfaceToClose.SetActive(false);
    }
}
