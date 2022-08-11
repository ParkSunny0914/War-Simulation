using UnityEngine;
using UnityEngine.UI;

public class PopupManager : MonoBehaviour
{
    [SerializeField] Text title;
    [SerializeField] Text timer;

    private static GameObject prefab;

    // PopUp Manager로 전역에서 접근 할 수 있는 함수
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

    // 팝업의 내용을 갱신하는 함수
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
