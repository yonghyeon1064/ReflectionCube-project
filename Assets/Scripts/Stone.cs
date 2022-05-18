using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : MonoBehaviour
{
    GameManager gmMana;
    Vector3 target;
    private void OnTriggerEnter(Collider collider) {
        Debug.Log(collider.gameObject.name);
        if (collider.gameObject.name == "ball") {
            //gm.SendMessage("RestartGame"); // "RestartGame" 이라는 method가 있으면 실행하라는 신호
            gmMana.RestartGame();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        gmMana = GameObject.Find("GameManager").GetComponent<GameManager>();
        target = GameObject.Find("ball").transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, 0.1f);
        transform.Rotate(new Vector3(0, 0, 5));
    }
}
