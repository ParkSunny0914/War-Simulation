using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class Create : MonoBehaviour
{
    [SerializeField] Product product;

    [SerializeField] Image border;
    [SerializeField] Image picture;
    [SerializeField] Image pricetag;

    [SerializeField] Text price;
    [SerializeField] Button createButton;

    private void Start()
    {
        border.sprite = product.border;
        picture.sprite = product.Picture;
        pricetag.sprite = product.pricetag;

        price.text = product.price.ToString() + "$";
    }

    public void CreateUnit(int count)
    {
        SoundManager.instance.Sound(0);

        switch (count)
        {
            case 0 :
                Instance("Goblin",product.price);
                StartCoroutine(Wait(3.0f));
                break;
            case 1 :
                Instance("Wizard",product.price);
                StartCoroutine(Wait(5.0f));
                break;
        }
    }

    public void Instance(string name, int price)
    {
        if(DataManager.instance.money > price)
        {
            DataManager.instance.money -= price;

            Instantiate
                    (
                         Resources.Load<GameObject>(name),
                         new Vector3(-15, 1, 15),
                         Quaternion.Euler(0, 90, 0)
                    );
            DataManager.instance.Save();
        }
            StartCoroutine(Wait(3.0f));
    }

    public IEnumerator Wait(float timer)
    {
        createButton.interactable = false;

        while(timer > 1.0f)
        {
            timer -= Time.deltaTime;
            createButton.image.fillAmount = (1.0f / timer);
            yield return new WaitForFixedUpdate();
        }
        SoundManager.instance.Sound(2);
        createButton.interactable = true;
    }
}
