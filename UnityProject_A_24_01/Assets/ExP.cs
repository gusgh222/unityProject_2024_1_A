using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Linq;

public class ExP : MonoBehaviour
{
    public Rigidbody m_Rigidbody;
    public int Count = 0;
    public int power = 100;

    public int point = 0;
    public float checkTime = 0.0f;
    public float checkEndTime = 30.0f;
    public Text m_Text = null;

    public int Point { get; private set; }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        checkEndTime -= Time.deltaTime;

        if(checkEndTime <= 0)
        {
            PlayerPrefs.SetInt("Point", Point);
            SceneManager.LoadScene("ResultScene");
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            m_Rigidbody.AddForce(transform.up * Force);
        }

        checkTime += Time.deltaTime;
        if(checkTime >= 1.0f)
        {
            point += 1;
            checkTime = 0.0f;
        }

        m_Text.text = point.ToString();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision != null)
        {
            Debug.Log(collision.gameObject.tag);
            point = 0;
            gameObject.transform.position = Vector3.zero;
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ltems")
        {
            point += 10;
            Destroy(other.gameObject);

        }
    }
}


