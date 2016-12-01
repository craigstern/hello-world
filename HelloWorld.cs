using UnityEngine;
using System.Collections;

//as a public static class, HelloWorld is *always* accessible to any other script that we 
//create; there's no need to instantiate it or make it a component of a gameobject!
public static class HelloWorld {

      //as a public static method of this class, we can easily call sayHello()
      //from anywhere in our code with nothing more than 'HelloWorld.sayHello()'
      public static void sayHello () {
            
            //'Debug.Log' is the bit that actually prints a string in the Unity console; 
            //it's just a built-in Unity function that takes a string as an argument
            Debug.Log( "hello world" );
      }
}
