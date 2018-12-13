using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Wavespawner : MonoBehaviour
{


    public enum SpawnState { SPAWNING,WAITING,COUNTING };

    public GameObject victoryhud;

    public GameObject cam2;

    public GameObject wavecountertext;

    public GameObject skipbutton;

    public GameObject buytime;

    public GameObject spawn;

    public GameObject[] enemies;

    [System.Serializable]
    public class Wave
    {
        public string name;
        public Transform enemy;
        public Transform enemy2;
        public Transform enemy3;
        public Transform enemy4;
        public Transform enemy5;
        public Transform enemy6;
        public int count;
        public int count2;
        public int count3;
        public int count4;
        public int count5;
        public int count6;
        public float rate;
    }

    public Wave[] waves;
    private int nextWave = 0;
    private float one = 0;
    

    public float timeBetweenWaves = 2f;
   public float countdown;


    private float searchCountdown = 1f;

    //public Transform enemyprefabs;
    private SpawnState state = SpawnState.COUNTING;


    [Header("Buynodes")]

    public GameObject shop;
    public GameObject Trinode;
    public GameObject Dianode;
    public GameObject Rhomnodes;
    public GameObject Kitenodes;
    public GameObject Heartnodes;
    public GameObject Pentagonnodes;



    void Start()
    {
        countdown = timeBetweenWaves;


    }

    
    void Update()
    {
        wavecountertext.GetComponent<TextMeshProUGUI>().text = "Wave:" + one.ToString();

        if (state == SpawnState.WAITING)
        {
            if (!EnemyIsAlive())
            {
                
                shop.SetActive(true);
                skipbutton.SetActive(true);
                buytime.SetActive(true);
                timeBetweenWaves = 10;
                WaveCompleted();
            }
            else
            {
               
                return;
            }
        }

        if (countdown <= 0f)
        {
            if (state != SpawnState.SPAWNING)
            {
                Trinode.SetActive(false);
                Dianode.SetActive(false);
                Rhomnodes.SetActive(false);
                Kitenodes.SetActive(false);
                Heartnodes.SetActive(false);
                Pentagonnodes.SetActive(false);
                skipbutton.SetActive(false);
                shop.SetActive(false);
                buytime.SetActive(false);
                StartCoroutine(Spawnwave(waves[nextWave]));
                countdown = timeBetweenWaves;
                one++;
            }
        }
        else
        {
            countdown -= Time.deltaTime;
        }

        buytime.GetComponent<TextMeshProUGUI>().text = "Buy time:" + countdown.ToString();

    }

    void WaveCompleted()
    {
        Debug.Log("Wave Completed");

        state = SpawnState.COUNTING;
        countdown = timeBetweenWaves;

       
            if (nextWave + 1 > waves.Length - 1)
            {
            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("level1"))
            {//nextWave = 0;
                SceneManager.LoadScene("level2");
                Debug.Log("LevelCompleted");

            }
            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("level2"))
            {//nextWave = 0;
                SceneManager.LoadScene("level3");
                Debug.Log("LevelCompleted");

            }
            if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("level3"))
            {//nextWave = 0;
                cam2.SetActive(true);
                victoryhud.SetActive(true);

            }

        }
            else
            {
                nextWave++;

            }
        
        
    }

    bool EnemyIsAlive()
    {
        searchCountdown -= Time.deltaTime;
        if (searchCountdown <= 0f)
        {

            searchCountdown = 1f; 
            if (GameObject.FindGameObjectWithTag("Enemy") == null)
            {
                return false;
            }
        }
            return true;

        }
    

    IEnumerator Spawnwave(Wave _wave)
    {
        
       

        Debug.Log("roundwave" + _wave.name);
        state = SpawnState.SPAWNING;

        for (int i = 0; i < _wave.count; i++)
        {
            SpawnEnemy(_wave.enemy);
            
            yield return new WaitForSeconds( 1f / _wave.rate);

        }
        for (int i = 0; i < _wave.count2; i++)
        {
            
            SpawnEnemy(_wave.enemy2);
            yield return new WaitForSeconds(1f / _wave.rate);

        }
        for (int i = 0; i < _wave.count3; i++)
        {

            SpawnEnemy(_wave.enemy3);
            yield return new WaitForSeconds(1f / _wave.rate);

        }
        for (int i = 0; i < _wave.count4; i++)
        {

            SpawnEnemy(_wave.enemy4);
            yield return new WaitForSeconds(1f / _wave.rate);

        }
        for (int i = 0; i < _wave.count5; i++)
        {

            SpawnEnemy(_wave.enemy5);
            yield return new WaitForSeconds(1f / _wave.rate);

        }
        for (int i = 0; i < _wave.count6; i++)
        {

            SpawnEnemy(_wave.enemy6);
            yield return new WaitForSeconds(1f / _wave.rate);

        }


        state = SpawnState.WAITING;

        yield break;
    }


    void SpawnEnemy (Transform _enemy)
    {
        Debug.Log("spawnenemy" + _enemy.name);
        Instantiate(_enemy,spawn.transform.position,transform.rotation);

        

    }

    public void Skipbuytime ()
    {
        countdown = 0f;
    }
   

}






