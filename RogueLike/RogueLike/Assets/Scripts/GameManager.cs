using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    public static GameManager instance = null;

    public BoardManager boardScript;

    private int level = 3;

	// Use this for initialization
	void Awake () {

        if (instance == null)
            instance = this;
        else if (instance != null)
            Destroy(gameObject);

        DontDestroyOnLoad(gameObject);

        boardScript = GetComponent<BoardManager>();
        InitGame();
	}

    void InitGame()
    {
        boardScript.SetupScene(level);
    }
	
	// Update is called once per frame
	void Update () {
	
	}


}
