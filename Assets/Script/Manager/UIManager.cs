using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    [SerializeField] Text moneyText;

    // Update is called once per frame
    void Update()
    {
        moneyText.text = DataManager.instance.money.ToString();
    }
}
