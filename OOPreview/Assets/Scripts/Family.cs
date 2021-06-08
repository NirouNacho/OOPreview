using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Family : MonoBehaviour
{
    public Person father;
    public Person mother;
    public Person son;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        father = new Person();
        father.name = "Patricio";
        father.lastName = "Rosero";
        father.secondLastName = "Jacome";
        father.age = 67;
        father.isMarried = true;


        mother = new Person();
        mother.name = "Praxedes";
        mother.lastName = "Urrutia";
        mother.secondLastName = "Sepulveda";
        mother.age = 64;
        mother.isFather = false;
        mother.isMarried = true;

        son = new Person();
        son.name = "Nicolas";
        son.lastName = father.lastName;
        son.secondLastName = mother.lastName;
        son.age = 25;
        son.isFather = false;
        son.isMarried = false;


        print(father.name + "and" + mother.name + "have a son called :"
            + son.name + "who's" + son.age + " years old."
            );

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
