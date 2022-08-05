using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightManager : MonoBehaviour
{
    bool condition = false;
    public GameObject[] lightEffact;

    public void LightSetting(int number)
    {
        condition = !condition;

        lightEffact[number].SetActive(condition);
    }
}
