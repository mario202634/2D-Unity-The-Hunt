using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdScene : MonoBehaviour
{
    public Dialogue DManager;
    public GameObject Panel;
    // Start is called before the first frame update
    void Start()
    {
        //Panel = GameObject.Find("Panel"); Panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            string[] dialogue = { "Daryl: Yep i knew , school is not the place to survive an apocolypse" };
            DManager.SetSentences(dialogue);
            DManager.StartCoroutine(DManager.TypeDialogue());
            Panel.SetActive(true);
            //test();
            Destroy(this.gameObject, 1f);

        }

    }



    IEnumerator RemoveAfterSeconds(int seconds, GameObject obj)
    {
        yield return new WaitForSeconds(seconds);
        obj.SetActive(false);
    }


}