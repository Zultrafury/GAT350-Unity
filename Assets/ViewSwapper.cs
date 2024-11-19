using UnityEngine;

public class ViewSwapper : MonoBehaviour
{
    public GameObject[] Objects;

    private int currobj;
    private bool toggled;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.position = Objects[0].transform.position;
        currobj = 1;
        toggled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (toggled && Input.GetKeyDown(KeyCode.E))
        {
            currobj++;
            if (currobj >= Objects.Length)
            {
                currobj = 1;
            }
            transform.position = Objects[currobj].transform.position;
            Debug.Log("Look at "+currobj);
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (toggled)
            {
                transform.position = Objects[0].transform.position;
                toggled = false;
                Debug.Log("Off");
            }
            else
            {
                transform.position = Objects[currobj].transform.position;
                toggled = true;
                Debug.Log("On");
            }
        }
    }
}
