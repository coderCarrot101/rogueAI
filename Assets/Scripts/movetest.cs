using System.Collections;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using UnityEngine.SceneManagement;

public class movetest : MonoBehaviour
{
    public string pattern;
    public Text gameLabel;
    void Start()
    {

        statecontroller.scrollAmount = 0;
        StartCoroutine(ExampleCoroutineThree());
            IEnumerator ExampleCoroutineThree() {

            yield return new WaitForSeconds(30);

            statecontroller.scrollAmount = 15;

        }
    }
    public float speed = 10;
    void Update()
    {    
        
        pattern = @"\n";
        if ( Input.GetKeyDown(KeyCode.Return))
        {
            
            //foreach (Match match in Regex.Matches(gameLabel.text, pattern))
            //{
            statecontroller.scrollAmount++;
            Debug.Log(statecontroller.scrollAmount);
            //}
    
        }
        if (Input.GetAxis("Mouse ScrollWheel") > 0f )
        {
            if(transform.localPosition.y <= -50)
            {
            Vector3 scrollUp = new Vector3(0, 10000, 0);
            transform.Translate(scrollUp * Time.deltaTime, Space.World);
            }
            
        }
        if(statecontroller.scrollAmount >= 15)
        {
            if (Input.GetAxis("Mouse ScrollWheel") < 0f )
            {
                
                Vector3 scrollDown = new Vector3(0, -10000, 0);
                transform.Translate(scrollDown * Time.deltaTime, Space.World);
            }
        }
    }
}
