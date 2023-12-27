using System.Collections;
using UnityEngine;

public class GenerateLevel : MonoBehaviour
{
    public GameObject[] section;
    private int zPos = 10;

    public bool creatingSection = false;
    public int secNum;

    // Update is called once per frame
    void Update()
    {
        if (creatingSection == false)
        {
            creatingSection = true;
            StartCoroutine(GenerateSection());
        }
    }

    IEnumerator GenerateSection()
    {
        secNum = Random.Range(0, 3);
        Instantiate(section[secNum], new Vector3(0, 0, zPos), Quaternion.identity);
        zPos += 20;

        // Adjust the WaitForSeconds duration to make the level generation faster
        yield return new WaitForSeconds(0.5f); // Example: Decreased waiting time to 0.5 seconds

        creatingSection = false;
    }
}
