using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class Orange : MonoBehaviour, IPointerClickHandler
{
    private const string ClickCountKey = "ClickCount";
    [SerializeField] TextMeshProUGUI text;
    int count;

    void Start()
    {
        count = PlayerPrefs.GetInt(ClickCountKey, 0);
        text.text = count.ToString();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        PlayerPrefs.SetInt(ClickCountKey, ++count);
        text.text = count.ToString();
    }
}
