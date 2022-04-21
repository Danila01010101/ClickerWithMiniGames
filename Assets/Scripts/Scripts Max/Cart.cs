using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cart : MonoBehaviour
{
    [SerializeField] private float nitroDuration;
    [SerializeField] private float coolDownNitro;
    private float usingNitroStart;
    private float usingNitroEnd;
    private float horizontalInput;
    private float speed = 10f;
    private float zRange = 10;
    private bool isUsingNitro = false;
    public int maxHealth = 100;
    public int currentHealth;
    public HealthBar healthBar;

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }

    private void StartNitro()
    {
        isUsingNitro = true;
        speed = 50f;
        usingNitroStart = Time.time;
    }

    private void EndNitro()
    {
        isUsingNitro = false;
        speed = 10f;
        usingNitroEnd = Time.time;
    }

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);

        usingNitroEnd = -coolDownNitro;
        usingNitroStart = -nitroDuration;
    }

    void Update()
    {

        if (Input.GetKey(KeyCode.LeftShift) && !isUsingNitro && Time.time - usingNitroEnd > coolDownNitro)
        {
            StartNitro();
        }

        if (isUsingNitro &&(Input.GetKeyUp(KeyCode.LeftShift) || Time.time - usingNitroStart > nitroDuration))
        {
            EndNitro();
        }



        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.forward * horizontalInput * Time.deltaTime * speed);

        if (transform.position.z < -zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zRange);
        }
        if (transform.position.z > zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
        }
    }

    private void OnEnable()
    {
        MonsterMove.OnBorderCrossed += TakeDamage;
    }

    private void OnDisable()
    {
        MonsterMove.OnBorderCrossed -= TakeDamage;
    }
}
