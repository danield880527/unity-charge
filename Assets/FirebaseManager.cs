using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Firebase;
using Firebase.Database;

public class FirebaseManager : MonoBehaviour
{
    public Firebase.Auth.FirebaseAuth auth;
    public Firebase.Auth.FirebaseUser user;
    

   
    // Start is called before the first frame update
    void Start()
    {
        auth = Firebase.Auth.FirebaseAuth.DefaultInstance;
        auth.StateChanged += AuthStateChanged;
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Register(string email, string password)
    {
       
        auth.CreateUserWithEmailAndPasswordAsync(email, password).ContinueWith(task =>
         {

            if(task.IsCanceled)
            {
        
                return;
               
            }
            if(task.IsFaulted)
            {
                print(task. Exception.InnerException.Message);
                return;
               
            }
            if(task.IsCompletedSuccessfully)
            {
                print(" Registered");
                
                
            }

        });
    }

    public async void Login(string email, string password)
    {
        await auth.SignInWithEmailAndPasswordAsync(email, password).ContinueWith(task =>
        {
            if(task.IsCompletedSuccessfully)
            {
                print("Login");

            }
            if(task.IsFaulted)
            {
                print(task. Exception.InnerException.Message);
                return;
               
            }
        });
    }
    

    public void Logout()
    {
      
       auth.SignOut();

    }
    
     void AuthStateChanged(object sender, System.EventArgs eventArgs)
     {
        if(auth.CurrentUser != user)
        {
            user = auth.CurrentUser;
            if(user != null){
                print($"Login - {user.Email}");
            }
        }
     }








     public void SaveData(string data)
     {
        if(user != null)
        {
        DatabaseReference reference = FirebaseDatabase.DefaultInstance.RootReference;
        reference.Child(user.UserId).Child("carnumber").SetValueAsync(data).ContinueWith(task =>
        {
            if(task.IsCompletedSuccessfully)
            {
                print("saved!");
            }
        

        

        });
        }
        else{
            print("mustlogin");
        }


     }

     public void LoadData()
     {

     }
     


     void OnDestroy()
     {
        auth.StateChanged -= AuthStateChanged;
        auth=null;
     }
}
