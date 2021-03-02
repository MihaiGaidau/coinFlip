using UnityEngine;
using UnityEngine.UI;

public class ListControl : MonoBehaviour
{

    [SerializeField]
    private GameObject buttonTemplate;

    // Start is called before the first frame update
    void Start()
    {
        buttonTemplate.SetActive(false);
        foreach (var element in GameHistory.games)
        {
            GameObject hisElement = Instantiate(buttonTemplate) as GameObject;
            hisElement.SetActive(true);

            hisElement.GetComponent<ButtonListButton>().SetData(element);
            hisElement.GetComponent<Image>().color = element.actual == element.guessed ? Color.green: Color.red;

            hisElement.transform.SetParent(buttonTemplate.transform.parent, false);

        }

    }
}
