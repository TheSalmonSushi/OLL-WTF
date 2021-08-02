using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LightRay : MonoBehaviour
{
    [SerializeField] public ParticleSystem RayParticle;

    public int iLevelToLoad;
    public int RLevelToLoad;
    public bool useIntegerToLoadLevel = false;
    public float timedelaytoNextLvl;
    public float timedelaytoResLvl;


    public int reflections;
    public float maxLength;
    
    public GameObject
        cmfollow1,
        cmfollow2,
        cmfollow3,
        cmfollow4,
        cmfollow5,
        cmfollow6,
        cmfollow7,
        cmfollow8,
        cmfollow9,
        cmfshpere, 
        cmfray;
    
    public GameObject 
        lightsource1;
    
    public GameObject 
        door1;
    
    public GameObject
        Button1;


    private LineRenderer lineRenderer;
    private Ray ray;
    private RaycastHit hit;
    private Vector2 direction;

    

    private void Awake()
    {
        lineRenderer = GetComponent<LineRenderer>();
    }

     void Start()
    {
        RayParticle.Play();
        
    }

    void Update()
    {
        CreateRay();
    }

    void CreateRay()
    {
        ray = new Ray(transform.position, transform.right);
        lineRenderer.positionCount = 1;
        lineRenderer.SetPosition(0, transform.position);
        float remainingLength = maxLength;

        for (int i = 0; i < reflections; i++)
        {
            if (Physics.Raycast(ray.origin, ray.direction, out hit, remainingLength))
            {
                lineRenderer.positionCount += 1;
                lineRenderer.SetPosition(lineRenderer.positionCount - 1, hit.point);
                remainingLength -= Vector2.Distance(ray.origin, hit.point);
                ray = new Ray(hit.point, Vector2.Reflect(ray.direction, hit.normal));
                // Kalo Mau naro apa yang udah di hit sama si ray harus ditambahin disini!!
                if (hit.collider.tag != "Mirror" && hit.collider.tag != "Sphere" && hit.collider.tag != "Button" && hit.collider.tag != "BadRay")
                {
                    break;
                }
             
                if (hit.collider.tag == "Button")
                {
                   DestroyDoor();
                }

                if (hit.collider.tag == "Sphere")
                {
                    StartNextLevel();
                }

                if (hit.collider.tag == "BadRay")
                {
                    StartRestartLevel();
                }



            }
            else
            {
                lineRenderer.positionCount += 1;
                lineRenderer.SetPosition(lineRenderer.positionCount - 1, ray.origin + ray.direction * remainingLength);
            }

        }
    }

   
    void DestroyDoor()
    {
        Destroy(door1);
        Destroy(Button1);
    }
   

    void StartNextLevel()
    {
        cmfollow1.SetActive(false);
        cmfollow2.SetActive(false);
        cmfollow3.SetActive(false);
        cmfollow4.SetActive(false);
        cmfollow5.SetActive(false);
        cmfollow6.SetActive(false);
        cmfollow7.SetActive(false);
        cmfollow8.SetActive(false);
        cmfollow9.SetActive(false);

        cmfshpere.SetActive(true);
        cmfray.SetActive(false);
        
        lightsource1.SetActive(false);
        Invoke("LoadNextLevel", timedelaytoNextLvl);
    }

    void StartRestartLevel()
    {
        cmfollow1.SetActive(false);
        cmfollow2.SetActive(false);
        cmfollow3.SetActive(false);
        cmfollow4.SetActive(false);
        cmfollow5.SetActive(false);
        cmfollow6.SetActive(false);
        cmfollow7.SetActive(false);
        cmfollow8.SetActive(false);
        cmfollow9.SetActive(false);
        
        cmfshpere.SetActive(false);
        cmfray.SetActive(true);
        
        lightsource1.SetActive(false);
        Invoke("RestartLevel", timedelaytoResLvl);
    }

     void LoadNextLevel()
        {
           if (useIntegerToLoadLevel)
            {
               SceneManager.LoadScene(iLevelToLoad);
            }

        }

    void RestartLevel()
    {
        if (useIntegerToLoadLevel)
        {
            SceneManager.LoadScene(RLevelToLoad);
        }
    }

}
