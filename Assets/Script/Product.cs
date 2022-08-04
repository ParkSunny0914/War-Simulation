using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Product", menuName = "Scriptable Objact/Product", order = 2)]


public class Product : ScriptableObject
{
    public int price;
    public Sprite pricetag;
    public Sprite border;
    public Sprite Picture;
}
