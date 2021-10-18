using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    // Start is called before the first frame update
    public float LookRadius = 30f;
    Transform target;
    NavMeshAgent agent;
    public Material blue;
    public Material Defmat;
    public MeshRenderer ren;
    public GameManager men;
    //public Rigidbody bullet;
    //public float firerate;
    //public float nextfire;
    //public float enemylife;
    public Collider col;
    public AudioSource la;
    //public GameObject expl;
    void Start()
    {
        target = PlayerManager.instance.player.transform;
        agent = GetComponent<NavMeshAgent>();
        //firerate = 1f;
        //nextfire = Time.time;
        //enemylife = 3f;
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(target.position, transform.position);
        if(distance <= LookRadius)
        {
            //Rigidbody bullett;
            FaceTarget();
            //if (Time.time > nextfire)
            //{
            //    la.Play();
            //    bullett = Instantiate(bullet, pb.transform.position, pb.transform.rotation);
            //    bullett.AddForce(pb.forward * 9000);
            //    nextfire = Time.time + firerate;
            //}
            agent.SetDestination(target.position);
            if (men.isPill == true)
            {
                
                ren.material = blue;
            }
            if (men.isPill == false)
            {

                ren.material = Defmat;
            }

        }
        //if (enemylife == 0f)
        //{
        //    Instantiate(expl, transform.position, transform.rotation);
        //    Destroy(gameObject);
        //    GameManager.scor += 1f;
        //}
    }
    void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Player")
        {
            if (men.isPill == true)
            {
                GameManager.scor += 10;
                men.isPill = false;
                Destroy(gameObject);
            }
            //enemylife -= 1f;
            GameManager.life -= 1;
            Debug.Log("playerhit");

        }
       
    }
    void FaceTarget ()
    {
        Vector3 direction = (target.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5f);

    }
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, LookRadius);
    }
}
