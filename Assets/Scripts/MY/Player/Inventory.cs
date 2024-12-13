using UnityEngine;
using UnityEngine.UI;
public class Inventory : MonoBehaviour
{
    public GameObject[] item;
    [SerializeField] private Image[] invenSlots;
    [SerializeField] private Image[] invenIcons;
    [SerializeField] private Sprite defaultSlot;
    [SerializeField] private Sprite selectedSlot;
    public void AddItem(GameObject obj, int pos)
    {
        if (!item[pos])
        {
            item[pos] = obj;
            invenIcons[pos].gameObject.SetActive(true);
            invenIcons[pos].sprite = obj.GetComponent<InvenItem>().icon;
            obj.SetActive(false);
        }
    }
    public bool RemoveItem(int pos)
    {
        if (!item[pos])
            return false;
        invenIcons[pos].gameObject.SetActive(false);
        return true;
    }
    public void ChangeSlots(int pos)
    {
        for (int i = 1; i < invenSlots.Length; i++)
            invenSlots[i].sprite = defaultSlot;
        invenSlots[pos].sprite = selectedSlot;
    }
}