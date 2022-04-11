using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform[] firingPositions;

    private int difficultyLocalScale;
    private float shootTime;
    private float shootRate = 1f;
    private float rotationTime = 5f;
    private bool isTurning;
    private bool isActive;

    void Start()
    {
        shootTime = shootRate;
        isTurning = true;
        difficultyLocalScale = 1;
    }

    void Update() {
        //firing script
        if(isActive)
        {
            if (shootTime <= 0f)
            {
                Shoot();
                shootTime = (shootRate-(.2f * difficultyLocalScale));
            }
            shootTime -= Time.deltaTime;
        }

        //rotation script
        if(rotationTime > 0) 
        {
            Rotation();
        } 
        else if(rotationTime < 0) 
        {
            ResetRotation();
        }
    }

    public void Activate(bool isPrimed)
    {
        isActive = isPrimed;
    }
    public void SetDifficulty(int difficulty)
    {
        this.difficultyLocalScale = difficulty;
    }

    //ShootingCode
    void Shoot()
    {
        for(int i = 0; i < firingPositions.Length; i++)
        {
            GameObject bulletObject = Instantiate(bulletPrefab, firingPositions[i].position, firingPositions[i].rotation);
            bulletObject.SendMessage("SetSpeed", difficultyLocalScale);
        }
    }

    //RotationCode
    void Rotation()
    {
        if(isTurning) 
        {
            transform.Rotate(new Vector3 (0, 0, 20) * Time.deltaTime);
            for(int i = 0; i < firingPositions.Length; i++)
            {
                firingPositions[i].Rotate(new Vector3(0, 0, 20) * Time.deltaTime);
            }
        } 
        else if(!isTurning) 
        {
            transform.Rotate(new Vector3 (0, 0, -20) * Time.deltaTime);
            for(int i = 0; i < firingPositions.Length; i++)
            {
                firingPositions[i].Rotate(new Vector3(0, 0, -20) * Time.deltaTime);
            }
        } 
        rotationTime -= Time.deltaTime; 
    }
    void ResetRotation()
    {
        rotationTime = 10f;
        isTurning = !isTurning;
    }
}
