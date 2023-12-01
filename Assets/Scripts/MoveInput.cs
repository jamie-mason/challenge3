using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.AI;
using UnityEngine.UI;
using UnityEngine.PlayerLoop;
using System;
using System.Linq;
using Unity.PlasticSCM.Editor.WebApi;
using static UnityEditor.PlayerSettings;
using System.Threading;

public class MoveInput : MonoBehaviour
{
    public float minDetectionValue;
    private float timeCount, speed = 1.0f;
    public Controller PlayerControls;
    private bool walking, running;
    protected Animator animator;

    private InputAction dodge;
    private InputAction attack;
    private InputAction vault;
    private void Awake()
    {
        animator = GetComponent<Animator>();
        PlayerControls = new Controller();
    }
    private void OnEnable()
    {
        dodge = PlayerControls.ActionMap.Dodge;
        attack = PlayerControls.ActionMap.LightAttack;
        vault = PlayerControls.ActionMap.Vault;

        attack.Enable();
        dodge.Enable();
        vault.Enable();
    }
    private void OnDisable()
    {
        dodge.Disable();
        attack.Disable();
        vault.Disable();


    }
    private void Start()
    {
        walking = false;
        running = false;
    }
    public Vector2 getLStick(Gamepad gamepad)
    {
        Vector2 move = gamepad.leftStick.ReadValue();
       
        if(Mathf.Abs(move.x) < minDetectionValue)
        {
            move = new Vector2(0f, move.y);
        }
        if (Mathf.Abs(move.y) < minDetectionValue)
        {
            move = new Vector2(move.x, 0f);
        }
        return move;
    }
    void ProcessGamepadControls(Gamepad gamepad)
    {
        var l = getLStick(gamepad);
        var run = (1.0f - minDetectionValue) * 2 / 3 + minDetectionValue;
        var angle = Mathf.Atan2(l.y, l.x) * 180 / Mathf.PI;
        
        if (l.magnitude < run && l.magnitude > 0f)
        {
            walking = true;
            running = false;
        }
        else if(l.magnitude >= run) 
        {
            running = true;
            walking = false;
        }
        else
        {
            running = false;
            walking = false;
        }
        if(l != Vector2.zero && transform.eulerAngles.y != angle)
        {
            transform.eulerAngles = Vector3.Lerp(transform.eulerAngles, new Vector3(transform.eulerAngles.x, angle, transform.eulerAngles.z),speed);
            
        }
        if(speed * timeCount >= 1f)
        {
            timeCount = 0.0f;
        }

    }
    
    private void Update()
    {
        Gamepad gamepad = Gamepad.current;
        if (gamepad == null)
            return;
        ProcessGamepadControls(gamepad);
        
        animator.SetBool("IsDodge", dodge.inProgress);
        animator.SetBool("IsAttack", attack.inProgress);
        animator.SetBool("IsRun", running);
        animator.SetBool("IsWalk", walking);
    }
    public bool getVaultProgress()
    {
        return vault.inProgress;
    }
}
