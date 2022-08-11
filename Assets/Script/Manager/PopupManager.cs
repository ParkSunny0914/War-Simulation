using UnityEngine;
using UnityEngine.UI;

public class PopupManager : MonoBehaviour
{
    [SerializeField] Text title;
    [SerializeField] Text timer;

    private static GameObject prefab;

    // PopUp Manager�� �������� ���� �� �� �ִ� �Լ�
    public static PopupManager Show(string massage, string timer)
    {
        if (prefab == null)
        {
            prefab = (GameObject)Resources.Load("Game Result Window");
        }
        GameObject obj = Instantiate(prefab);

        PopupManager resultPopup = obj.GetComponent<PopupManager>();
        resultPopup.UpdateContent(massage, timer);

        return resultPopup;
    }

    // �˾��� ������ �����ϴ� �Լ�
    public void UpdateContent(string titleMessage, string timerMassage)
    {
        title.text = titleMessage;
        timer.text = timerMassage;
    }

    public void CanclePopup()
    {
        Destroy(gameObject);
    }
}
