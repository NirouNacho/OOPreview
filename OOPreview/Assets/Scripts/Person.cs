using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Person 
{
    public string name = "";
    public string lastName = "";
    public string secondLastName = "";
    public int age = 0;
    public string address = "";
    public bool isMarried = false;
    public bool isFather = true;
    public Car car;
    public Person spouse;

    //methods
    public bool IsmarriedTo(Person spouse) {
        
        if (spouse == null)
        {
            return false;
        }
        Debug.Log(spouse.name);
        return this.spouse == spouse ;
    }

}
