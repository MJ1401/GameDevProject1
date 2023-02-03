using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance {get; private set;}

    private int score;

    public TextMeshProUGUI Score;
    public GameObject Diamond;
    public GameObject banner;
    public GameObject button;

    public GameObject building;

    void Awake() {
        if (Instance == null) {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        } else {
            Destroy(gameObject);
        }

    }

    public void IncScore(int ds) {
        score += ds;
        Score.text = "Score : " + score;
    }

    public void StartGame() {
        score = 0;
        Score.text = "Score : " + score;

        //Diamond.GetComponent<Diamond>().Drop();
        banner.SetActive(false);
        button.SetActive(false);
    }

    public void StopGame() {
        //Diamond.GetComponent<Diamond>().StopDropping();
        banner.SetActive(true);
        button.SetActive(true);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
