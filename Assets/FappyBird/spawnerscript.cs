using UnityEngine;

public class spawnerscript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnrate = 2;
    private float timer = 0;
    public float height = 5;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnpipe();
    }

    // Update is called once per frame
    void Update()
    {

        if (timer < spawnrate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnpipe();
            timer = 0;

        }
    }
    void spawnpipe() 
    {
        float lowestPoint = transform.position.y - height;
        float highestPoint = transform.position.y + height;

        Instantiate(pipe, new Vector3 (transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);

    }
}
