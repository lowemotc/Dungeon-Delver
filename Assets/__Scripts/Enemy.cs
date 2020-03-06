using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    protected static Vector3[] directions = new Vector3[]
    {
        Vector3.right, Vector3.up, Vector3.left, Vector3.down
    };

    [Header("Set in Inspector: Enemy")]
    public float maxHealth = 1;

    [Header("Set Dynamically: Enemy")]
    public float health;
    protected Animator anim;
    protected Rigidbody2D rigid;
    protected SpriteRenderer sRend;

    // Use this for initialization
    void Awake()
    {
        health = maxHealth;
        anim = GetComponent<Animator>();
        rigid = GetComponent<Rigidbody2D>();
        sRend = GetComponent<SpriteRenderer>();
    }
}