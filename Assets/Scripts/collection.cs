using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collection : MonoBehaviour
{
    public Text countText;
    public Text winText;
    public GameObject Pickup;

    private int count;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick up"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }

    }

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 5)
        {
            winText.text = "You Win!";
        }
    }

}