using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class LoadingBar : MonoBehaviour
{
    private Slider slider;
    private float targetProgress = 0;

    public float FillSpeed =0.5f;
    public int NextScene = 1;


    private void Awake()
    {
        slider = gameObject.GetComponent<Slider>();
    }
    // Start is called before the first frame update
    void Start()
    {
        IncrementProgress(1f);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(slider.value);
        if (slider.value <= targetProgress){
            slider.value += FillSpeed * Time.deltaTime;
        }
       if (slider.value == 1)
        {
            SceneManager.LoadSceneAsync(NextScene);
        }
        
    }
    public void IncrementProgress(float newProgress)
    {
        targetProgress = slider.value + newProgress;
    }
}
