using UnityEngine;
using UnityEngine.UI;
public class Inventory : MonoBehaviour
{
    public GameObject[] item;
    [SerializeField] private Image[] invenSlots;
    public void AddItem(GameObject obj, int pos)
    {
        if (!item[pos])
        {
            item[pos] = obj;
            invenSlots[pos].gameObject.SetActive(true);
            invenSlots[pos].sprite = obj.GetComponent<InvenItem>().icon;
            obj.SetActive(false);
        }
    }
    public bool RemoveItem(int pos)
    {
        if (!item[pos])
            return false;
        invenSlots[pos].gameObject.SetActive(false);
        return true;
    }
}