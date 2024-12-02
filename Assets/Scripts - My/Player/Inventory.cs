using UnityEngine;
public class Inventory : MonoBehaviour
{
    public GameObject[] item;
    public void AddItem(GameObject obj, int pos)
    {
        if (!item[pos])
        {
            item[pos] = obj;
            obj.SetActive(false);
        }
    }
    public bool RemoveItem(int pos)
    {
        if (!item[pos])
            return false;
        return true;
    }
}