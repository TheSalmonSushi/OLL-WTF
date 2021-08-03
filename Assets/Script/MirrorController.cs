using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorController : MonoBehaviour
{
    [SerializeField] protected KeyCode whichObject; //keybind untuk menentukan object yang ingin diputar
    [SerializeField] protected KeyCode rotateLeft; //keybind untuk rotasi ke ke kiri atau ccw
    [SerializeField] protected KeyCode rotateRight; //keybind untuk rotasi ke kanan atau cw
    [SerializeField] protected KeyCode moveLeft; //keybind untuk gerak ke kiri
    [SerializeField] protected KeyCode moveRight; //keybind untuk gerak ke kanan
    [SerializeField] protected KeyCode moveUp; //keybind untuk gerak ke atas
    [SerializeField] protected KeyCode moveDown; //keybind untuk gerak ke bawah
    [SerializeField] protected float speed; //angka kecepatan pergerakan object
    [SerializeField] protected float RotationSpeed = 90;
    [SerializeField] protected Vector2 direction;
    [SerializeField] protected Vector3 RotDir;

    public GameObject
        cmfollow1,
        cmfollow2,
        cmfollow3,
        cmfollow4,
        cmfollow5,
        cmfollow6,
        cmfollow7,
        cmfollow8,
        cmfollow9;

    public GameObject
        Outline1,
        Outline2,
        Outline3,
        Outline4,
        Outline5,
        Outline6,
        Outline7,
        Outline8,
        Outline9;
   
    public bool choose = false;
    
    private float x, y, z;
    


    // Start is called before the first frame update
    void Start()
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
        
        Outline1.SetActive(false);
        Outline2.SetActive(false);
        Outline3.SetActive(false);
        Outline4.SetActive(false);
        Outline5.SetActive(false);
        Outline6.SetActive(false);
        Outline7.SetActive(false);
        Outline8.SetActive(false);
        Outline9.SetActive(false);
       
    }

    // Update is called once per frame
    void Update()
    {
        InputGetkeyMovement();
        WitchMirror();
    }

    public void InputGetkeyMovement()
    {
        if (Input.GetKey(KeyCode.Alpha1) || Input.GetKey(KeyCode.Alpha2) 
                                         || Input.GetKey(KeyCode.Alpha3) 
                                         || Input.GetKey(KeyCode.Alpha4)
                                         || Input.GetKey(KeyCode.Alpha5)
                                         || Input.GetKey(KeyCode.Alpha6)
                                         || Input.GetKey(KeyCode.Alpha7)
                                         || Input.GetKey(KeyCode.Alpha8)
                                         || Input.GetKey(KeyCode.Alpha9))
        {
            choose = false;
        }
        
        if (Input.GetKeyUp(whichObject))
        {
            choose = true;
        }

        if (choose && Input.GetKey(rotateLeft))
        {
            //z++;
            Rotate();
            RotDir.z = 1;
        }
        if (choose && Input.GetKey(rotateRight))
        {
            //z--;
            Rotate();
            RotDir.z = -1;
        }

        if (choose && Input.GetKey(moveLeft))
        {
            direction.x = -1;
            Move();
        }
        if (choose && Input.GetKey(moveRight))
        {
            direction.x = 1;
            Move();
        }
        if (choose && Input.GetKey(moveUp))
        {
            direction.y = 1;
            Move();
        }
        if (choose && Input.GetKey(moveDown))
        {
            direction.y = -1;
            Move();
        }
        direction.x = 0;
        direction.y = 0;
    }

    public void WitchMirror()
    {
        // Mirror 1
        if (Input.GetKey(KeyCode.Alpha1)) 
        {
            cmfollow1.SetActive(true);
            
            cmfollow2.SetActive(false);
            cmfollow3.SetActive(false);
            cmfollow4.SetActive(false);
            cmfollow5.SetActive(false);
            cmfollow6.SetActive(false);
            cmfollow7.SetActive(false);
            cmfollow8.SetActive(false);
            cmfollow9.SetActive(false);
            
            Outline1.SetActive(true);
            
            Outline2.SetActive(false);
            Outline3.SetActive(false);
            Outline4.SetActive(false);
            Outline5.SetActive(false);
            Outline6.SetActive(false);
            Outline7.SetActive(false);
            Outline8.SetActive(false);
            Outline9.SetActive(false);
        }
        
        
        // Mirror 2
        if (Input.GetKey(KeyCode.Alpha2))
        {
            cmfollow1.SetActive(false);
            
            cmfollow2.SetActive(true);
            
            cmfollow3.SetActive(false);
            cmfollow4.SetActive(false);
            cmfollow5.SetActive(false);
            cmfollow6.SetActive(false);
            cmfollow7.SetActive(false);
            cmfollow8.SetActive(false);
            cmfollow9.SetActive(false);
            
            Outline1.SetActive(false);
            
            Outline2.SetActive(true);
            
            Outline3.SetActive(false);
            Outline4.SetActive(false);
            Outline5.SetActive(false);
            Outline6.SetActive(false);
            Outline7.SetActive(false);
            Outline8.SetActive(false);
            Outline9.SetActive(false);
        }
       
        
        if (Input.GetKey(KeyCode.Alpha3))
        {
            cmfollow1.SetActive(false);
            cmfollow2.SetActive(false);
            
            cmfollow3.SetActive(true);
            
            cmfollow4.SetActive(false);
            cmfollow5.SetActive(false);
            cmfollow6.SetActive(false);
            cmfollow7.SetActive(false);
            cmfollow8.SetActive(false);
            cmfollow9.SetActive(false);
            
            Outline1.SetActive(false);
            Outline2.SetActive(false);
            
            Outline3.SetActive(true);
            
            Outline4.SetActive(false);
            Outline5.SetActive(false);
            Outline6.SetActive(false);
            Outline7.SetActive(false);
            Outline8.SetActive(false);
            Outline9.SetActive(false);
        }
        
        if (Input.GetKey(KeyCode.Alpha4))
        {
            cmfollow1.SetActive(false);
            cmfollow2.SetActive(false);
            cmfollow3.SetActive(false);
            
            cmfollow4.SetActive(true);
            
            cmfollow5.SetActive(false);
            cmfollow6.SetActive(false);
            cmfollow7.SetActive(false);
            cmfollow8.SetActive(false);
            cmfollow9.SetActive(false);
            
            Outline1.SetActive(false);
            Outline2.SetActive(false);
            Outline3.SetActive(false);
            
            Outline4.SetActive(true);
            
            Outline5.SetActive(false);
            Outline6.SetActive(false);
            Outline7.SetActive(false);
            Outline8.SetActive(false);
            Outline9.SetActive(false);
        }
        
        if (Input.GetKey(KeyCode.Alpha5))
        {
            cmfollow1.SetActive(false);
            cmfollow2.SetActive(false);
            cmfollow3.SetActive(false);
            cmfollow4.SetActive(false);
            
            cmfollow5.SetActive(true);
            
            cmfollow6.SetActive(false);
            cmfollow7.SetActive(false);
            cmfollow8.SetActive(false);
            cmfollow9.SetActive(false);
            
            Outline1.SetActive(false);
            Outline2.SetActive(false);
            Outline3.SetActive(false);
            Outline4.SetActive(false);
            
            Outline5.SetActive(true);
            
            Outline6.SetActive(false);
            Outline7.SetActive(false);
            Outline8.SetActive(false);
            Outline9.SetActive(false);
        }
        
        if (Input.GetKey(KeyCode.Alpha6))
        {
            cmfollow1.SetActive(false);
            cmfollow2.SetActive(false);
            cmfollow3.SetActive(false);
            cmfollow4.SetActive(false);
            cmfollow5.SetActive(false);
            
            cmfollow6.SetActive(true);
            
            cmfollow7.SetActive(false);
            cmfollow8.SetActive(false);
            cmfollow9.SetActive(false);
            
            Outline1.SetActive(false);
            Outline2.SetActive(false);
            Outline3.SetActive(false);
            Outline4.SetActive(false);
            Outline5.SetActive(false);
            
            Outline6.SetActive(true);
            
            Outline7.SetActive(false);
            Outline8.SetActive(false);
            Outline9.SetActive(false);
        }
        
        if (Input.GetKey(KeyCode.Alpha7))
        {
            cmfollow1.SetActive(false);
            cmfollow2.SetActive(false);
            cmfollow3.SetActive(false);
            cmfollow4.SetActive(false);
            cmfollow5.SetActive(false);
            cmfollow6.SetActive(false);
            
            cmfollow7.SetActive(true);
            
            cmfollow8.SetActive(false);
            cmfollow9.SetActive(false);
            
            Outline1.SetActive(false);
            Outline2.SetActive(false);
            Outline3.SetActive(false);
            Outline4.SetActive(false);
            Outline5.SetActive(false);
            Outline6.SetActive(false);
            
            Outline7.SetActive(true);
            
            Outline8.SetActive(false);
            Outline9.SetActive(false);
        }
        
        if (Input.GetKey(KeyCode.Alpha8))
        {
            cmfollow1.SetActive(false);
            cmfollow2.SetActive(false);
            cmfollow3.SetActive(false);
            cmfollow4.SetActive(false);
            cmfollow5.SetActive(false);
            cmfollow6.SetActive(false);
            cmfollow7.SetActive(false);
            
            cmfollow8.SetActive(true);
            
            cmfollow9.SetActive(false);
            
            Outline1.SetActive(false);
            Outline2.SetActive(false);
            Outline3.SetActive(false);
            Outline4.SetActive(false);
            Outline5.SetActive(false);
            Outline6.SetActive(false);
            Outline7.SetActive(false);
            
            Outline8.SetActive(true);
            
            Outline9.SetActive(false);
        }
        
        if (Input.GetKey(KeyCode.Alpha9))
        {
            cmfollow1.SetActive(false);
            cmfollow2.SetActive(false);
            cmfollow3.SetActive(false);
            cmfollow4.SetActive(false);
            cmfollow5.SetActive(false);
            cmfollow6.SetActive(false);
            cmfollow7.SetActive(false);
            cmfollow8.SetActive(false);
            
            cmfollow9.SetActive(true);
            
            Outline1.SetActive(false);
            Outline2.SetActive(false);
            Outline3.SetActive(false);
            Outline4.SetActive(false);
            Outline5.SetActive(false);
            Outline6.SetActive(false);
            Outline7.SetActive(false);
            Outline8.SetActive(false);
            
            Outline9.SetActive(true);
        }

        
    }

    public void Rotate()
    {
       // transform.localRotation = Quaternion.Euler(0, 0, z) ;
        float angle = RotationSpeed * Time.deltaTime;
        transform.rotation *= Quaternion.AngleAxis(angle, RotDir);
    }

    public void Move()
    {
        //transform.Translate(direction * speed * Time.deltaTime);
        if(direction.x == 1)
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
           

        }
        if(direction.x == -1)
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
           
        }
        if(direction.y == 1)
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
            
        }
        if(direction.y == -1)
        {
            transform.position += Vector3.down * speed * Time.deltaTime;
           
        }
    }
}
