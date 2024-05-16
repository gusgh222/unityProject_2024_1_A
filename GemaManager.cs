using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemaManager : MonoBehaviour
{
    public GameObject[] circleObject;
    public Transform genTransform;
    public float timeCheck;
    public bool isGen;
    // Start is called before the first frame up

    public void GenObject()
    {
        isGen = false;
        timeCheck = 1.0f;
    }
    void Start()
    {
        GenObject();
    }

    // Update is called once per frame
    void Update()
    {
        if(isGen == false)
        {
            timeCheck -= Time.deltaTime;
            if(timeCheck < 0.0f)
            {
                int RandNumber = Random.Range(0, 3);
                GameObject Temp = Instantiate(circleObject[RandNumber]);
                Temp.transform.position = genTransform.position;
                isGen = true;
            }
        }
    }

    public void MergeObject(int index, Vector3 position)
    {
        GameObject Temp = Instantiate(circleObject[index]);
        Temp.transform.position = position;
        Temp.GetComponent<CircleObject>().Used();
    }
}
